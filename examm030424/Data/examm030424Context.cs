using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using examm030424.Models;

namespace examm030424.Data
{
    public class examm030424Context : DbContext
    {
        public examm030424Context (DbContextOptions<examm030424Context> options)
            : base(options)
        {
        }

        public DbSet<examm030424.Models.Employee> Employee { get; set; } = default!;
    }
}
