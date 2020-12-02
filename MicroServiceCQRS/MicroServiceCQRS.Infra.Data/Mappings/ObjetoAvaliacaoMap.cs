using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class ObjetoAvaliacaoMap : IEntityTypeConfiguration<ObjetoAvaliacao>
    {

        public void Configure(EntityTypeBuilder<ObjetoAvaliacao> builder)
        {
            builder.ToTable("ObjetoAvaliacao", "dbo");
            builder.HasKey(x => new { x.ObjetoId });

            builder.Property(x => x.ObjetoId).HasColumnName(@"ObjetoId").HasColumnType("int").IsRequired();
            builder.Property(x => x.NroTentativa).HasColumnName(@"NroTentativa").HasColumnType("smallint");
            builder.Property(x => x.Pontuacao).HasColumnName(@"Pontuacao").HasColumnType("numeric");
            builder.Property(x => x.DataExibirRespostaPadrao).HasColumnName(@"DataExibirRespostaPadrao").HasColumnType("datetime");
            builder.Property(x => x.QuestaoRandomica).HasColumnName(@"QuestaoRandomica").HasColumnType("bit").IsRequired();
            builder.Property(x => x.AlternativaRandomica).HasColumnName(@"AlternativaRandomica").HasColumnType("bit").IsRequired();
            builder.Property(x => x.SugerirQuestao).HasColumnName(@"SugerirQuestao").HasColumnType("bit").IsRequired();
            builder.Property(x => x.StatusId).HasColumnName(@"StatusId").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Expectativa).HasColumnName(@"Expectativa").HasColumnType("numeric(15,4)");
            builder.Property(x => x.MensagemExpectativaPositiva).HasColumnName(@"MensagemExpectativaPositiva").HasColumnType("varchar(8000)");
            builder.Property(x => x.MensagemExpectativaNegativa).HasColumnName(@"MensagemExpectativaNegativa").HasColumnType("varchar(8000)");
            builder.Property(x => x.ExibirGabarito).HasColumnName(@"ExibirGabarito").HasColumnType("bit").IsRequired();
            builder.Property(x => x.ExibirQuestao).HasColumnName(@"ExibirQuestao").HasColumnType("bit").IsRequired();
            builder.Property(x => x.DataExibirGabarito).HasColumnName(@"DataExibirGabarito").HasColumnType("datetime");
            builder.Property(x => x.DataExibirQuestao).HasColumnName(@"DataExibirQuestao").HasColumnType("datetime");
            builder.Property(x => x.ProvaOnline).HasColumnName(@"ProvaOnline").HasColumnType("bit").IsRequired();
            builder.Property(x => x.ModeloAvaliacaoID).HasColumnName(@"ModeloAvaliacaoID").HasColumnType("int");
            builder.Property(x => x.Individual).HasColumnName(@"Individual").HasColumnType("bit").IsRequired();
            builder.Property(x => x.TempoDuracao).HasColumnName(@"TempoDuracao").HasColumnType("time");
        }
    }
}
