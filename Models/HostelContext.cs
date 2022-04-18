using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hostels.Models;

namespace Hostels.Models
{
    public class HostelContext : DbContext
    {
        public HostelContext(DbContextOptions<HostelContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
