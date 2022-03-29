using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.API.Model
{
    internal struct Episodes
    {
        public Info? info { get; set; }
        public List<Episode>? results { get; set;}
    }
}
