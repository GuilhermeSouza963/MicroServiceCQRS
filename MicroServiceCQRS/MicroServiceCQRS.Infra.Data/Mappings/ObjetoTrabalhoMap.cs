using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class ObjetoTrabalhoMap : IEntityTypeConfiguration<ObjetoTrabalho>
    {

        public void Configure(EntityTypeBuilder<ObjetoTrabalho> builder)
        {
            builder.ToTable("ObjetoTrabalho", "dbo");
            builder.HasKey(x => new { x.ObjetoId });

            builder.Property(x => x.ObjetoId).HasColumnName(@"ObjetoId").HasColumnType("int").IsRequired();
            builder.Property(x => x.DataInicioEntrega).HasColumnName(@"DataInicioEntrega").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataFimEntrega).HasColumnName(@"DataFimEntrega").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataFimEntregaProrrogacao).HasColumnName(@"DataFimEntregaProrrogacao").HasColumnType("datetime");
            builder.Property(x => x.NroTentativa).HasColumnName(@"NroTentativa").HasColumnType("smallint");
            builder.Property(x => x.Pontuacao).HasColumnName(@"Pontuacao").HasColumnType("numeric");
            builder.Property(x => x.PontuacaoProrrogada).HasColumnName(@"PontuacaoProrrogada").HasColumnType("numeric(15,4)");
            builder.Property(x => x.Observacao).HasColumnName(@"Observacao").HasColumnType("text").IsUnicode(false);
            builder.Property(x => x.StatusId).HasColumnName(@"StatusId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Grupo).HasColumnName(@"Grupo").HasColumnType("bit").IsRequired();
            builder.Property(x => x.RespostaPadrao).HasColumnName(@"RespostaPadrao").HasColumnType("text").IsUnicode(false);
        }
    }
}
