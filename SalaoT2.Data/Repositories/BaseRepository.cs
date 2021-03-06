using SalaoT2.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaoT2.Data.Repositories
{
    public class BaseRepository<T> where T: class, IEntity
    {
        public Context context { get; set; }
        public void Incluir(T entity)
        {
            context.Set<T>().Add(entity);
        }
        public T Selecionar(int id)
        {
            return context.Set<T>().FirstOrDefault(x => x.Id == id);
        }
        public void Excluir(int id)
        {
            var entity = Selecionar(id);
            context.Set<T>().Remove(entity);
        }
        public void Alterar(T entity)
        {
            context.Set<T>().Update(entity);
        }
        public List<T> SelecionarTudo() => context.Set<T>().ToList();
    }
}
