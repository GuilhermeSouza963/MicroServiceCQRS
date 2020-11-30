using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class DisciplinaObjetoMap : IEntityTypeConfiguration<DisciplinaObjeto>
    {
        public void Configure(EntityTypeBuilder<DisciplinaObjeto> builder)
        {
            builder.ToTable("DisciplinaObjeto", "dbo");
            builder.HasKey(x => new { x.DisciplinaId, x.ObjetoId });

            builder.Property(x => x.DisciplinaId).HasColumnName(@"DisciplinaId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.ObjetoId).HasColumnName(@"ObjetoId").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Ordem).HasColumnName(@"Ordem").HasColumnType("smallint").IsRequired();
            builder.Property(x => x.PesquisaId).HasColumnName(@"PesquisaId").HasColumnType("int");
            builder.Property(x => x.StatusId).HasColumnName(@"StatusID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
        }
    }
}
