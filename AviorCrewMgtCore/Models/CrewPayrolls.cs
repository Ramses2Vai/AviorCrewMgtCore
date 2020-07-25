using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewPayrolls
    {
        public int CrewPayId { get; set; }
        public int AllotNumber { get; set; }
        public string AllotName { get; set; }
        public string CrewRelationship { get; set; }
        public string AllotAddress { get; set; }
        public decimal Amount { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public int? CrewId { get; set; }

        public virtual People Crew { get; set; }
    }
}
