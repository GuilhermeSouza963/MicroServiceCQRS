using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class ObjetoTipoMap : IEntityTypeConfiguration<ObjetoTipo>
    {

        public void Configure(EntityTypeBuilder<ObjetoTipo> builder)
        {
            builder.ToTable("ObjetoTipo", "dbo");
            builder.HasKey(x => x.ObjetoTipoId);

            builder.Property(x => x.ObjetoTipoId)
                .HasColumnName(@"ObjetoTipoID")
                .HasColumnType("smallint").IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("varchar(128)").IsRequired().IsUnicode(false);
            builder.Property(x => x.BackgroundCss).HasColumnName(@"BackgroundCss").HasColumnType("varchar(56)").IsUnicode(false);
            builder.Property(x => x.IconeUrl).HasColumnName(@"IconeUrl").HasColumnType("varchar(256)").IsRequired().IsUnicode(false);
            builder.Property(x => x.SaveUrl).HasColumnName(@"SaveUrl").HasColumnType("varchar(256)").IsUnicode(false);
            builder.Property(x => x.IndexUrl).HasColumnName(@"IndexUrl").HasColumnType("varchar(256)").IsUnicode(false);
            builder.Property(x => x.ListUrl).HasColumnName(@"ListUrl").HasColumnType("varchar(256)").IsUnicode(false);
            builder.Property(x => x.Controller).HasColumnName(@"Controller").HasColumnType("varchar(256)").IsUnicode(false);
            builder.Property(x => x.PodeCopiar).HasColumnName(@"PodeCopiar").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.SituacaoId).HasColumnName(@"SituacaoId").HasColumnType("int").IsUnicode(false);
            builder.Property(x => x.SaveDisciplina).HasColumnName(@"SaveDisciplina").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.Popup).HasColumnName(@"Popup").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.InserirCalendario).HasColumnName(@"InserirCalendario").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.RequerAvaliacao).HasColumnName(@"RequerAvaliacao").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.IconeApp).HasColumnName(@"IconeApp").HasColumnType("varchar(100)").IsUnicode(false);

            builder.Property(x => x.StatusId).HasColumnName(@"StatusID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
