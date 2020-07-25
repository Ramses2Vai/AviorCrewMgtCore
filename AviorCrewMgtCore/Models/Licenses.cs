using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Licenses
    {
        public Licenses()
        {
            CrewLicenses = new HashSet<CrewLicenses>();
        }

        public int LicenseId { get; set; }
        public string LicenseCode { get; set; }
        public string LicenseType { get; set; }
        public string LicenseInfo { get; set; }

        public virtual ICollection<CrewLicenses> CrewLicenses { get; set; }
    }
}
