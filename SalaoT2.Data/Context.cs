using Microsoft.EntityFrameworkCore;
using SalaoT2.Data.Map;
using SalaoT2.Dominio;
using System;

namespace SalaoT2.Data
{
    public class Context : DbContext
    {
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<ServicoSolicitado> ServicoSolicitado { get; set; }
        public DbSet<Turno> Turno { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=VAIO-MARCELO\\SQLEXPRESS; Database=SalaoT2; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AgendamentoMap());
            builder.ApplyConfiguration(new CaixaMap());
            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new EnderecoMap());
            builder.ApplyConfiguration(new FuncionarioMap());
            builder.ApplyConfiguration(new ServicoMap());
            builder.ApplyConfiguration(new ServicoSolicitadoMap());
        }
    }
}
