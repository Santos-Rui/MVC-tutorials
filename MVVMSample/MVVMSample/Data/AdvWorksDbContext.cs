using Microsoft.EntityFrameworkCore;
using MVVMSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.Data
{
    public partial class AdvWorksDbContext : DbContext
    {
        public AdvWorksDbContext(DbContextOptions<AdvWorksDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
