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
    public class EnderecoController : Controller
    {
        private readonly EnderecoRepository repo;

        public EnderecoController()
        {
            repo = new EnderecoRepository();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Endereco> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Endereco Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Endereco> Post([FromBody] Endereco endereco)
        {
            repo.Incluir(endereco);
            return repo.SelecionarTudo();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Endereco> Put(int id, [FromBody] Endereco endereco)
        {
            repo.Alterar(endereco);
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
