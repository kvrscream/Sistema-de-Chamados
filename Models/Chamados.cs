using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avaliacao.Models
{
    public class Chamados
    {

        public long Id { get; set; }

        public Cliente cliente { get; set; }

        public DateTime DataHoraAbertura { get; set; }

        public bool Fechado { get; set; }

        public DateTime DataHoraFechamento { get; set; }

    }


    public class ChamadosMap : IEntityTypeConfiguration<Chamados>
    {
        public void Configure(EntityTypeBuilder<Chamados> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Fechado)
                .HasDefaultValue(0);
        }
    }
}
