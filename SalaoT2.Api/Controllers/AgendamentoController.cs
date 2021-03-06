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
    public class AgendamentoController : Controller
    {
        private readonly AgendamentoRepository repo;

        public AgendamentoController()
        {
            repo = new AgendamentoRepository();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Agendamento> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Agendamento Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Agendamento> Post([FromBody] Agendamento agendamento)
        {
            repo.Incluir(agendamento);
            return repo.SelecionarTudo();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Agendamento> Put([FromBody] Agendamento agendamento)
        {
            repo.Alterar(agendamento);
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
