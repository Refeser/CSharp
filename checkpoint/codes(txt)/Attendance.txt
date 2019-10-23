using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropusknoiPunkt.Models
{
    public class Attendance
    {
        public uint Id { get; set; }
        public string Full_name { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
