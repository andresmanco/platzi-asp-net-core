using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using platzi_asp_net_core.Models;

    public class AsignaturaContext : DbContext
    {
        public AsignaturaContext (DbContextOptions<AsignaturaContext> options)
            : base(options)
        {
        }

        public DbSet<platzi_asp_net_core.Models.Asignatura> Asignatura { get; set; }
    }
