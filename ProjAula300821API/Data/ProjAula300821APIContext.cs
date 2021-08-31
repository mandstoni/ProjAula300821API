using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAula300821API.Controllers.Model;

namespace ProjAula300821API.Models
{
    public class ProjAula300821APIContext : DbContext
    {
        public ProjAula300821APIContext (DbContextOptions<ProjAula300821APIContext> options)
            : base(options)
        {
        }

        public DbSet<ProjAula300821API.Controllers.Model.Cliente> Cliente { get; set; }

        public DbSet<ProjAula300821API.Controllers.Model.Padaria> Padaria { get; set; }

        public DbSet<ProjAula300821API.Controllers.Model.Produto> Produto { get; set; }
    }
}
