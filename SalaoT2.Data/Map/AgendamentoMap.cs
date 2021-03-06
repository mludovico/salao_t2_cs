using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Anotacao)
                .HasColumnType("varchar(150)")
                .IsRequired();
            builder.HasOne( => )
                .WithMany()
        }
    }
}
