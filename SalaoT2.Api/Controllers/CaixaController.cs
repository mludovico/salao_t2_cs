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
    public class CaixaController : Controller
    {
        private readonly CaixaRepository repo;

        public CaixaController()
        {
            repo = new CaixaRepository();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Caixa> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Caixa Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Caixa> Post([FromBody] Caixa caixa)
        {
            repo.Incluir(caixa);
            return repo.SelecionarTudo();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Caixa> Put([FromBody] Caixa caixa)
        {
            repo.Alterar(caixa);
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
