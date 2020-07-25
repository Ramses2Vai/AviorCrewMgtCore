using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class PnIdiagnoses
    {
        public int PnIdiagnoseId { get; set; }
        public string DiagnoseType { get; set; }
        public DateTime? Date { get; set; }
        public string DiagnoseNote { get; set; }
        public bool FitToWork { get; set; }
        public int PnIid { get; set; }

        public virtual PnImodels PnI { get; set; }
    }
}
