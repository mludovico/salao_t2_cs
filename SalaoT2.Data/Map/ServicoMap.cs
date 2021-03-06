using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            throw new NotImplementedException();
        }
    }
}
