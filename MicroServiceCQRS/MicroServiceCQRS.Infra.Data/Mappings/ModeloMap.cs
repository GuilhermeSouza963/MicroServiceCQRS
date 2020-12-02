using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class ModeloMap : IEntityTypeConfiguration<Modelo>
    {

        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.ToTable("Modelo", "dbo");
            builder.HasKey(x => x.ModeloId);

            builder.Property(x => x.ModeloId).HasColumnName(@"ModeloId").HasColumnType("smallint").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ObjetoTipoId).HasColumnName(@"ObjetoTipoId").HasColumnType("smallint");
            builder.Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("varchar(256)").IsRequired().IsUnicode(false);
            builder.Property(x => x.StatusId).HasColumnName(@"StatusID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
