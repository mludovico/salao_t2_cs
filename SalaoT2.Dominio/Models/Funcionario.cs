using System;
using System.Collections.Generic;
using SalaoT2.Dominio.Models;

namespace SalaoT2.Dominio
{
    public class Funcionario : IEntity
    {
        public Funcionario()
        {
            Servicos = new List<Servico>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public CargoFunc Cargo { get; set; }
        public DateTime HorarioEntrada { get { return Convert.ToDateTime("10:00"); } }
        public DateTime HorarioSaida { get { return Convert.ToDateTime("19:00"); } }
        public List<Servico> Servicos { get; set; }
        public enum CargoFunc
        {
            Cabelereira,
            Manicure,
            Esteticista
        }

        public void IncluirServico(Servico serv)
        {
            Servicos.Add(serv);
        }

        public void ExcluirServico(int id)
        {
            //Servicos.RemoveAll(s => s.Id == id);

            List<Servico> remover = Servicos.FindAll(f => f.Id == id);
            foreach (var remove in remover)
            {
                Servicos.Remove(remove);
            }
        }
    }


}
