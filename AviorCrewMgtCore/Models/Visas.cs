using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Visas
    {
        public Visas()
        {
            CrewVisas = new HashSet<CrewVisas>();
        }

        public int VisaId { get; set; }
        public string VisaCode { get; set; }
        public string VisaType { get; set; }
        public string VisaInfo { get; set; }

        public virtual ICollection<CrewVisas> CrewVisas { get; set; }
    }
}
