using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoT2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Map
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            throw new NotImplementedException();
        }
    }
}
