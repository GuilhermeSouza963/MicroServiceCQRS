using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class ObjetoForumMap : IEntityTypeConfiguration<ObjetoForum>
    {

        public void Configure(EntityTypeBuilder<ObjetoForum> builder)
        {
            builder.ToTable("ObjetoForum", "dbo");
            builder.HasKey(x => new { x.ObjetoId });

            builder.Property(x => x.ObjetoId).HasColumnName(@"ObjetoId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Moderado).HasColumnName(@"Moderado").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.ParticipantesCriamTopico).HasColumnName(@"ParticipantesCriamTopico").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.ParticipacaoUnicaPorTopico).HasColumnName(@"ParticipacaoUnicaPorTopico").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.VisualizaPostagensAposParticipacao).HasColumnName(@"VisualizaPostagensAposParticipacao").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.UnicaDiscurssaoSimples).HasColumnName(@"UnicaDiscurssaoSimples").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.StatusId).HasColumnName(@"StatusId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.PodeAnexar).HasColumnName(@"PodeAnexar").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.ReceberEmail).HasColumnName(@"ReceberEmail").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.Avaliado).HasColumnName(@"Avaliado").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.Pontuacao).HasColumnName(@"Pontuacao").HasColumnType("decimal(15,4)");
            builder.Property(x => x.RespostaPadrao).HasColumnName(@"RespostaPadrao").HasColumnType("text").IsUnicode(false);
        }
    }

}
