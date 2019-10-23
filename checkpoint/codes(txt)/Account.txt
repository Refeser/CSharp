using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropusknoiPunkt.Models
{
  public  class Account
    {
        public uint Id { get; set; }
        public string Full_name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Priority { get; set; }
        public string Short_name { get; set; }
        public string Position_ { get; set; }
        public DateTime pass_from { get; set; }
        public DateTime pass_untill { get; set; }
    }
}
