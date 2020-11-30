using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class ObjetoMap : IEntityTypeConfiguration<Objeto>
    {
        public void Configure(EntityTypeBuilder<Objeto> builder)
        {
            builder.ToTable("Objeto", "dbo");
            builder.HasKey(x => x.ObjetoId);

            builder.Property(x => x.ObjetoId)
                .HasColumnName(@"ObjetoID")
                .HasColumnType("int").IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.ObjetoIdPai).HasColumnName(@"ObjetoIDPai").HasColumnType("int");
            builder.Property(x => x.ObjetoTipoId).HasColumnName(@"ObjetoTipoID").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.ObjetoIdPaiPrincipal).HasColumnName(@"ObjetoIDPaiPrincipal").HasColumnType("[0]");
            builder.Property(x => x.ModeloId).HasColumnName(@"ModeloId").HasColumnType("smallint");
            builder.Property(x => x.Titulo).HasColumnName(@"Titulo").HasColumnType("varchar(256)").IsRequired().IsUnicode(false);
            builder.Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("text").IsUnicode(false);
            builder.Property(x => x.Conteudo).HasColumnName(@"Conteudo").HasColumnType("varchar(8000)").IsUnicode(false);
            builder.Property(x => x.DataExibirInicio).HasColumnName(@"DataExibirInicio").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataExibirFim).HasColumnName(@"DataExibirFim").HasColumnType("datetime");
            builder.Property(x => x.Ordem).HasColumnName(@"Ordem").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.SituacaoId).HasColumnName(@"SituacaoID").HasColumnType("int");
            builder.Property(x => x.PessoaId).HasColumnName(@"PessoaID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Urgente).HasColumnName(@"Urgente").HasColumnType("bool");
            builder.Property(x => x.DataAula).HasColumnName(@"DataAula").HasColumnType("datetime");
            builder.Property(x => x.StatusId).HasColumnName(@"StatusID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();

        }
    }
}
