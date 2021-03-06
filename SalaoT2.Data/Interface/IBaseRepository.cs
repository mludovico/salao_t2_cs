using SalaoT2.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaoT2.Data.Interface
{
    public interface IBaseRepository<T> where T: class, IEntity
    {
        public void Incluir(T entity);
        public T Selecionar(int id);
        public void Excluir(int id);
        public void Alterar(T entity);
        public List<T> SelecionarTudo();
    }
}
