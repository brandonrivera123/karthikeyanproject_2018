using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace presem.Models
{
    public class Opportunity
    {
        public string OpportunityName { get; set; }
        public string Center { get; set; }
        public string CenterAddress { get; set; }
        public string Skill { get; set; }
        public string Times { get; set; }
        public bool College { get; set; }
    }
}
