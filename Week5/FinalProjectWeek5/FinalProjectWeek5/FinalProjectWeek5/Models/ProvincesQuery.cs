using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWeek5.Models
{
    public class ProvincesQuery
    {
        public string success { get; set; }
        public string error { get; set; }
        public List<Result> result {get; set;}
    }
}
