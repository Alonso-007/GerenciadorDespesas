﻿using GerenciadorDespesas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDespesas.Mapeamento
{
    public class DespesasMap : IEntityTypeConfiguration<Despesas>
    {
        public void Configure(EntityTypeBuilder<Despesas> builder)
        {
            builder.HasKey(d => d.DespesaId);
            builder.Property(d => d.Valor).IsRequired();

            //relacionamentos
            builder.HasOne(d => d.Meses).WithMany(d => d.Despesas).HasForeignKey(d => d.MesId);
            builder.HasOne(d => d.TipoDespesas).WithMany(d => d.Despesas).HasForeignKey(d => d.TipoDespesaId);

            builder.ToTable(nameof(Despesas));
        }
    }
}
