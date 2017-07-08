using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWeek5.Models
{
    class Current
    {
        public string last_updated_epoch { get; set; }
        public string last_updated { get; set; }
        public string temp_c { get; set; }
        public string temp_f { get; set; }
        public string is_day { get; set; }
        public Condition condition { get; set; }
        public string wind_mph { get; set; }
        public string wind_kph { get; set; }
        public string wind_degree { get; set; }
        public string wind_dir { get; set; }
        public string pressure_mb { get; set; }
        public string pressure_in { get; set; }
        public string precip_mm { get; set; }
        public string precip_in { get; set; }
        public string humidity { get; set; }
        public string cloud { get; set; }
        public string feelslike_c { get; set; }
        public string feelslike_f { get; set; }
        public string vis_km { get; set; }
        public string vis_miles { get; set; }
    }
}
