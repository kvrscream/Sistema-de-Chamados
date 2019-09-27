using System;
using System.Collections.Generic;
using System.Text;
using avaliacao.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace avaliacao.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Chamados> Chamados { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new ChamadosMap());
            base.OnModelCreating(builder);
        }

    }
}
