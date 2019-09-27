using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace avaliacao.Models
{
    public class Cliente
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Documento precisa ser digitado")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "Nome ou Razão Social precisa ser digitado")]
        public string RazaoSocialNome { get; set; } //Razão social ou Nome

        [Required(ErrorMessage = "CEP precisa ser digitado")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Logradouro precisa ser digitado")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Número precisa ser digitado")]
        public int LogradouroNumero { get; set; }

        public string LogradouroComplemento { get; set; }

        [Required(ErrorMessage = "Bairro precisa ser digitado")]
        public string LogradouroBairro { get; set; }

        [Required(ErrorMessage = "Cidade precisa ser digitado")]
        public string LogradouroCidade  { get; set; }

        [Required(ErrorMessage = "Estado UF precisa ser digitado")]
        public string LogradouroUF { get; set; }

        [Required(ErrorMessage = "Telefone precisa ser digitado")]
        public string Telefone { get; set; }

        public int SLARespostaTempo { get; set; }
        

    }

    //Classe para configurar o banco usando Entity
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.HasKey(k => k.Id);

            builder.Property(p => p.CpfCnpj)
                .HasMaxLength(14)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.RazaoSocialNome)
                .HasMaxLength(60)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.CEP)
                .HasMaxLength(8)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.Logradouro)
                .HasMaxLength(60)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.LogradouroNumero)
                .HasMaxLength(10)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.LogradouroComplemento)
                .HasMaxLength(60)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.LogradouroBairro)
                .HasMaxLength(60)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.LogradouroCidade)
                .HasMaxLength(60)
                .HasColumnType("VARCHAR");


            builder.Property(p => p.LogradouroUF)
                .HasMaxLength(2)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.Telefone)
                .HasMaxLength(12)
                .HasColumnType("VARCHAR");

            builder.Property(p => p.SLARespostaTempo)
                .HasDefaultValue(4);


        }
    }

}
