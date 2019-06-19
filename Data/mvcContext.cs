using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc.Models
{
    public class mvcContext : DbContext
    {
        public mvcContext (DbContextOptions<mvcContext> options)
            : base(options)
        {
        }

        public DbSet<mvc.Models.Department> Department { get; set; }
    }
}
