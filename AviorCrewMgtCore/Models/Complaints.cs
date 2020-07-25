using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Complaints
    {
        public Complaints()
        {
            ComplaintFiles = new HashSet<ComplaintFiles>();
        }

        public int ComplaintId { get; set; }
        public string UserEntry { get; set; }
        public string UserGroup { get; set; }
        public int PrincipalId { get; set; }
        public string PrincipalName { get; set; }
        public string RaisedBy { get; set; }
        public DateTime? DateRecieved { get; set; }
        public string Description { get; set; }
        public bool Careport { get; set; }
        public string ReportDesc { get; set; }
        public string Status { get; set; }
        public DateTime? DateFiled { get; set; }
        public DateTime? DateResolved { get; set; }

        public virtual ICollection<ComplaintFiles> ComplaintFiles { get; set; }
    }
}
