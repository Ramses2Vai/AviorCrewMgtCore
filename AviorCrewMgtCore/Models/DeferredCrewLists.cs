using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class DeferredCrewLists
    {
        public int CrewDefferedId { get; set; }
        public int ChangeDeferredId { get; set; }
        public string CrewName { get; set; }
        public string RankCode { get; set; }
        public int CrewId { get; set; }
        public int? RankId { get; set; }

        public virtual CrewChangeDeferreds ChangeDeferred { get; set; }
        public virtual People Crew { get; set; }
        public virtual Ranks Rank { get; set; }
    }
}
