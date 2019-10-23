using System;
using System.Data;
using System.Windows.Forms;

namespace PP_LR6
{
    public partial class MainForm : Form
    {

        // Класс выполняющий соединение с БД и запрос к ней:     
        public DBRequest UserReq;
        // Таблица-результат выполнения запроса:     
        private DataTable RequestTab;
        // Таблица структуры таблиц из БД:    
        private DataTable StructTab;
        // Название Таблицы, обработанной последний раз в StructTab_OnRowChanged    
        private string LastTabName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Создаём класс взаимодействия с Базой Данных       
            UserReq = new DBRequest();
            // Создаём таблицу и добавляем в неё столбцы: 
            StructTab = new DataTable("TabFields");
            DataColumn NewDatCol = new DataColumn("Tables", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new DataColumn("Fields", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            DatGridDBTables.DataSource = StructTab;
            DatGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab;
            // Подключаем к таблице обработчик события изменения строки:       
            StructTab.RowChanged += new DataRowChangeEventHandler(StructTab_OnRowChanged);
        }
        //**************** Обработчик изменения строки в БД *****************     
        private void StructTab_OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (LastTabName != (string)e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //************** Попытка Соединения с Базой Данных***************** 
        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            bool Connected = false;
            Cursor = Cursors.WaitCursor;
            // Пробуем соединиться с БД:       
            try
            {
                UserReq.Disconnect();
                UserReq.ConnectTo(tbDatSource.Text, tbInitCat.Text);
                Connected = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(this, e1.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connected = false;
            }
            if (Connected)
            {
                // Открываем доступ к управлению выполнением запросов:         
                tbRequest.Enabled = true;
                btnRequest.Enabled = true;
                datGridSQLResult.Enabled = true;
                DatGridDBTables.Enabled = true;
            }
            else
            {
                // Закрываем доступ к управлению выполнением запросов:         
                tbRequest.Enabled = false;
                btnRequest.Enabled = false;
                datGridSQLResult.Enabled = false;
                DatGridDBTables.Enabled = false;
            }
            Cursor = Cursors.Arrow;
            try
            {
                StructTab.Clear();
                RequestTab.Clear();
            }
            catch
            {
            }
        }

        //*************** Выполнение Заданного SQL-запроса ******************     
        private void btnRequest_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RequestTab = UserReq.SQLRequest(tbRequest.Text);
                datGridSQLResult.DataSource = RequestTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }
        //*************** Выводим Данные Выбранной Таблицы ******************    
        private void datGridDBTables_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DataGridView.HitTestInfo HitInfo = DatGridDBTables.HitTest(e.X, e.Y);

            if ((HitInfo.RowIndex >= 0) && (HitInfo.RowIndex < StructTab.Rows.Count))
            {
                tbRequest.Text = "SELECT * FROM " + (string)StructTab.Rows[HitInfo.RowIndex]["Tables"];
                btnRequest_Click(this, null);
            }
        }
        //****************** Изменение Размеров Таблицы *********************     
        /*private void datGridDBTables_Resize(object sender, System.EventArgs e)
        {
            int ColTablesWidth = DatGridDBTables.TableStyles[0].GridColumnStyles[0].Width;
            DatGridDBTables.TableStyles[0].GridColumnStyles[1].Width =
                DatGridDBTables.Width - ColTablesWidth - 57;
        }*/

    }
}
