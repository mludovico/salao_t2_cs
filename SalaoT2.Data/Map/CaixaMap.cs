using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class CaixaMap : IEntityTypeConfiguration<Caixa>
    {
        public void Configure(EntityTypeBuilder<Caixa> builder)
        {
            throw new NotImplementedException();
        }
    }
}
