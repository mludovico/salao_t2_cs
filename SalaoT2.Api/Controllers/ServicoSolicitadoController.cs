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
    public class ServicoSolicitadoController : Controller
    {
        private readonly ServicoSolicitadoRepository repo;

        public ServicoSolicitadoController()
        {
            repo = new ServicoSolicitadoRepository();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<ServicoSolicitado> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ServicoSolicitado Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<ServicoSolicitado> Post([FromBody] ServicoSolicitado servicoSolicitado)
        {
            repo.Incluir(servicoSolicitado);
            return repo.SelecionarTudo();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<ServicoSolicitado> Put([FromBody] ServicoSolicitado servicoSolicitado)
        {
            repo.Alterar(servicoSolicitado);
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
