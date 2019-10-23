using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace PP_LR6
{

    public class DBRequest
    {
        private OleDbConnection DBCon = new OleDbConnection();
        public void ConnectTo(string DataSource, string InitialCatalog)
        {

            DBCon.ConnectionString = "Provider=.NET Framework Data Provider for SQL Server;" +
                                    
                                     "Data Source=" + DataSource + ";" +
                                     "AttachDbFilename=|DataDirectory|" + InitialCatalog + ".mdf" + "Integrated Security=True;";
            //DBCon.ConnectionString = "Provider=SQLOLEDB;Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=C: /USERS/ALMAZ/DESKTOP/УЧЕБА/3КУРС_1СЕМ/ПРИКЛАДНОЕ ПРОГРАММИРОВАНИЕ/PP_LR6/PP_LR6/APP_DATA/COMPSAL.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            try { DBCon.Open(); }
            catch (Exception e) { throw e; }
        }
        public void Disconnect()
        {
            try
            {
                if (DBCon.State == ConnectionState.Open)
                    DBCon.Close();
            }
            catch
            {

            }
        }
        ~DBRequest()
        {
            Disconnect();
        }
        public string GetTableFields(string TableName)
        {
            if (DBCon.State == ConnectionState.Open)
            {
                DataTable CurTable = new DataTable("ConnectedTab");
                OleDbDataAdapter DBAdapt;
                try
                {
                    DBAdapt = new OleDbDataAdapter("SELECT * FROM " + TableName, DBCon);
                    DBAdapt.Fill(CurTable);
                }
                catch (Exception e)
                {
                    throw e;
                }
                string ResStr = "";
                int ColCount = CurTable.Columns.Count;
                for (int i = 0; i < ColCount; i++)
                {
                    string StrCon = ", ";
                    if (i == ColCount - 1) StrCon = ";";
                    ResStr += CurTable.Columns[i].ColumnName + "[" + CurTable.Columns[i].DataType.Name + "]" + StrCon;
                }
                return ResStr;
            }
            else
                return null;
        }
        public DataTable SQLRequest(string RequestStr)
        {
            if (DBCon.State == ConnectionState.Open)
            {
                DataTable ResultTab = new DataTable("SQLresult");
                OleDbDataAdapter DBAdapt;
                try
                {
                    DBAdapt = new OleDbDataAdapter(RequestStr, DBCon);
                    DBAdapt.Fill(ResultTab);
                }
                catch (Exception e)
                {
                    throw e;
                }
                return ResultTab;
            }
            else
                return null;
        }

    }
}