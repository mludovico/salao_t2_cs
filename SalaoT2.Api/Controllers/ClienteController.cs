using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalaoT2.Data.Repositories;
using SalaoT2.Dominio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoT2.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly ClienteRepository repo;

        public ClienteController()
        {
            repo = new ClienteRepository();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Cliente> Post([FromBody] Cliente cliente)
        {
            repo.Incluir(cliente);
            return repo.SelecionarTudo();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Cliente> Put(int id, [FromBody] Cliente cliente)
        {
            repo.Alterar(cliente);
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
