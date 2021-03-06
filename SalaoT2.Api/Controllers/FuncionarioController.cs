using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalaoT2.Data.Repositories;
using SalaoT2.Dominio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoT2.Api.Controllers
{
    [Route("api/[controller]")]
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioRepository repo;

        public FuncionarioController()
        {
            repo = new FuncionarioRepository();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Funcionario> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/values/5
        [HttpGet("{matricula}")]
        public Funcionario Get(int matricula)
        {
            return repo.Selecionar(matricula);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Funcionario> Post([FromBody] Funcionario funcionario)
        {
            repo.Incluir(funcionario);
            return repo.SelecionarTudo();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Funcionario> Put([FromBody] Funcionario funcionario)
        {
            repo.Alterar(funcionario);
            return repo.SelecionarTudo();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}
