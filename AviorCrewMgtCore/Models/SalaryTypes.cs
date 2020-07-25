using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class SalaryTypes
    {
        public int SalaryTypeId { get; set; }
        public string SalaryTypeName { get; set; }
        public int? VesselId { get; set; }

        public virtual Vessels Vessel { get; set; }
    }
}
