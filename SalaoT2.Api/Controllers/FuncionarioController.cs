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
    public class FuncionarioController : Controller
    {
        private readonly MinhaBaseFuncionarios baseFuncionarios;

        public FuncionarioController()
        {
            baseFuncionarios = new MinhaBaseFuncionarios();
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Funcionario> Get()
        {
            return baseFuncionarios.Funcionarios;
        }

        // GET api/values/5
        [HttpGet("{matricula}")]
        public Funcionario Get(int matricula)
        {
            return baseFuncionarios.Funcionarios.FirstOrDefault(item => item.Matricula == matricula);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Funcionario> Post([FromBody] Funcionario funcionario)
        {
            baseFuncionarios.Incluir(funcionario);
            return baseFuncionarios.Funcionarios;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IEnumerable<Funcionario> Put(int id, [FromBody] Funcionario funcionario)
        {
            baseFuncionarios.AlterarUmFuncionario(id, funcionario.Nome,
                funcionario.Telefone, funcionario.Endereco, funcionario.Cargo);
            return baseFuncionarios.Funcionarios;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
