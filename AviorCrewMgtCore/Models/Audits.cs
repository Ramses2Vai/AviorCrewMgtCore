using System;
using System.Collections.Generic;

namespace AviorCrewMgtCore.Models
{
    public partial class Audits
    {
        public Guid AuditId { get; set; }
        public string SessionId { get; set; }
        public string Ipaddress { get; set; }
        public string UserName { get; set; }
        public string Urlaccessed { get; set; }
        public DateTime TimeAccessed { get; set; }
        public string Data { get; set; }
    }
}
