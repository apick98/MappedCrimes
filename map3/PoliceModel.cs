using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map3
{
    public class PoliceModel
    {
        public string category { get; set; }
        public string location_type { get; set; }
        public MapLocation location { get; set; }
        public string context { get; set; }
        public OutcomeStatus Outcome_Status { get; set; }
        public string persistent_id { get; set; }
        public string id { get; set; }
        public string location_subtype { get; set; }

        public string Month { get; set; }
    }
}
