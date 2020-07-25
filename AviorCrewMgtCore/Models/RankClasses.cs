using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class RankClasses
    {
        public RankClasses()
        {
            Ranks = new HashSet<Ranks>();
        }

        public int RankClassId { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<Ranks> Ranks { get; set; }
    }
}
