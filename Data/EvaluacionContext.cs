using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using platzi_asp_net_core.Models;

    public class EvaluacionContext : DbContext
    {
        public EvaluacionContext (DbContextOptions<EvaluacionContext> options)
            : base(options)
        {
        }

        public DbSet<platzi_asp_net_core.Models.Evaluacion> Evaluacion { get; set; }
    }
