using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalaoT2.Dominio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalaoT2.Api.Controllers
{
    [Route("api/[controller]")]
    public class ServicoController : Controller
    {
        private readonly MinhaBaseServicos baseServicos;

        public ServicoController()
        {
            baseServicos = new MinhaBaseServicos();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Servico> Get()
        {
            return baseServicos.Servicos;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Servico Get(int id)
        {
            return baseServicos.ConsultarPorId(id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Servico> Post([FromBody] Servico servico)
        {
            baseServicos.Incluir(servico);
            return baseServicos.Servicos;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Servico> Put(int id, [FromBody] Servico servico)
        {
            baseServicos.AlterarUmServico(id, servico.Nome, servico.MinutosParaExecucao, servico.Preco);
            return baseServicos.Servicos;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
