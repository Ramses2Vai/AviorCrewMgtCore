using System;
using System.Collections.Generic;
using System.Text;
using AviorCrewMgtCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AviorCrewMgtCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MenuMaster> MenuMaster { get; set; }
    }
}
