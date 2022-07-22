using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMCV.Models;

namespace SalesWebMvc_.Data
{
    public class SalesWebMvc_Context : DbContext
    {
        public SalesWebMvc_Context (DbContextOptions<SalesWebMvc_Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMCV.Models.Departament> Departament { get; set; }
    }
}
