using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Kpionboards
    {
        public Kpionboards()
        {
            Kpiprincipals = new HashSet<Kpiprincipals>();
            Kpiranks = new HashSet<Kpiranks>();
        }

        public int KpionboardId { get; set; }
        public int MonthInt { get; set; }
        public string MonthStr { get; set; }
        public int Year { get; set; }
        public int Officers { get; set; }
        public int Ratings { get; set; }
        public int Trainees { get; set; }
        public int Cadets { get; set; }
        public int ExCrew { get; set; }

        public virtual ICollection<Kpiprincipals> Kpiprincipals { get; set; }
        public virtual ICollection<Kpiranks> Kpiranks { get; set; }
    }
}
