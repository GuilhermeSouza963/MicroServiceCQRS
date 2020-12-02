using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class ObjetoBibliotecaVirtualMap : IEntityTypeConfiguration<ObjetoBibliotecaVirtual>
    {
        public void Configure(EntityTypeBuilder<ObjetoBibliotecaVirtual> builder)
        {
            builder.ToTable("ObjetoBibliotecaVirtual", "dbo");
            builder.HasKey(x => x.ObjetoId);

            builder.Property(x => x.ObjetoId)
                .HasColumnName(@"ObjetoID")
                .HasColumnType("int").IsRequired();

            builder.Property(x => x.PaginaInicial).HasColumnName(@"PaginaInicial").HasColumnType("int");
            builder.Property(x => x.PaginaFinal).HasColumnName(@"PaginaFinal").HasColumnType("int");
            builder.Property(x => x.Paragrafo).HasColumnName(@"Paragrafo").HasColumnType("varchar(50)").IsUnicode(false);
            builder.Property(x => x.StatusId).HasColumnName(@"StatusID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
