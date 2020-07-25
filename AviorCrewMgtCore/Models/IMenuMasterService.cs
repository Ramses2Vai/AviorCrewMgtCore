using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AviorCrewMgtCore.Models
{
    interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();
        IEnumerable<MenuMaster> GetMenuMaster(String UserRole);
    }
}
