using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWeek5.Models
{
    class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string tz_id { get; set; }
        public string localtime_epoch { get; set; }
        public string localtime { get; set; }
    }
}
