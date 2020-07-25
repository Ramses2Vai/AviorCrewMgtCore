using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class CrewBackgrounds
    {
        public int CrewBackgroundId { get; set; }
        public string BenLasttName { get; set; }
        public string BenFirstName { get; set; }
        public string BenMiddleName { get; set; }
        public string Relationship { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string ContactRelationship { get; set; }
        public string ContactAddress { get; set; }
        public string ContactMobile { get; set; }
        public int? CrewId { get; set; }

        public virtual People Crew { get; set; }
    }
}
