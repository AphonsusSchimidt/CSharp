using DataReaderMVC.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReaderMVC.Models
{
   public class HS:ClassBase
    {
        public string name { get; set; }
        public string Place { get; set; }
        public string Result { get; set; }
        public string Score { get; set; }
        public string Level { get; set; }
    }
}
