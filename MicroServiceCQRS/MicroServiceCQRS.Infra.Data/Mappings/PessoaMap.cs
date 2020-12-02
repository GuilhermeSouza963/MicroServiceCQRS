using MicroServiceCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Infra.Data.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {

        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa", "dbo");
            builder.HasKey(x => x.PessoaId);

            builder.Property(x => x.PessoaId)
                .HasColumnName(@"PessoaID")
                .HasColumnType("int").IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.UsuarioId).HasColumnName(@"UsuarioID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar(128)").IsRequired().IsUnicode(false);
            builder.Property(x => x.NomeExibicao).HasColumnName(@"NomeExibicao").HasColumnType("varchar(128)").IsRequired().IsUnicode(false);
            builder.Property(x => x.DtNascimento).HasColumnName(@"DtNascimento").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.Email).HasColumnName(@"Email").HasColumnType("varchar(256)").IsRequired().IsUnicode(false);
            builder.Property(x => x.Celular).HasColumnName(@"Celular").HasColumnType("varchar(15)").IsUnicode(false);
            builder.Property(x => x.Telefone).HasColumnName(@"Telefone").HasColumnType("varchar(15)").IsUnicode(false);
            builder.Property(x => x.BackgroundCss).HasColumnName(@"BackgroundCss").HasColumnType("varchar(56)").IsUnicode(false);
            builder.Property(x => x.Banner).HasColumnName(@"Banner").HasColumnType("varchar(128)").IsUnicode(false);
            builder.Property(x => x.Foto).HasColumnName(@"Foto").HasColumnType("varchar(256)").IsUnicode(false);
            builder.Property(x => x.AutoContraste).HasColumnName(@"AutoContraste").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.PrimeiroAcesso).HasColumnName(@"PrimeiroAcesso").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.StatusId).HasColumnName(@"StatusID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Usuario).HasColumnName(@"Usuario").HasColumnType("varchar(64)").IsRequired().IsUnicode(false);
            builder.Property(x => x.CriadoEm).HasColumnName(@"CriadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.AtualizadoEm).HasColumnName(@"AtualizadoEm").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.RA).HasColumnName(@"RA").HasColumnType("varchar(20)").IsUnicode(false);
            builder.Property(x => x.CPF).HasColumnName(@"CPF").HasColumnType("varchar(11)").IsRequired();
            builder.Property(x => x.EnviarEmail).HasColumnName(@"EnviarEmail").HasColumnType("bool").IsRequired();
            builder.Property(x => x.PrimeiroAcessoApp).HasColumnName(@"PrimeiroAcessoApp").HasColumnType("bool").IsRequired().IsUnicode(false);
            builder.Property(x => x.Bio).HasColumnName(@"Bio").HasColumnType("varchar(2000)").IsUnicode(false);
            builder.Property(x => x.Thumb).HasColumnName(@"Thumb").HasColumnType("varchar(256)").IsRequired().IsUnicode(false);
            builder.Property(x => x.PerfilReceberEmailCriacaoMaterial).HasColumnName(@"PerfilReceberEmailCriacaoMaterial").HasColumnType("bool");
        }
    }
}
