using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using platzi_asp_net_core.Models;

    public class CursoContext : DbContext
    {
        public CursoContext (DbContextOptions<CursoContext> options)
            : base(options)
        {
        }

        public DbSet<platzi_asp_net_core.Models.Curso> Curso { get; set; }
    }
