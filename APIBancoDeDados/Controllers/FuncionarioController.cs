using APIBancoDeDados.Database;
using APIBancoDeDados.Entity;
using APIBancoDeDados.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIBancoDeDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FuncionarioController : ControllerBase
    {
        private readonly Context _context;

        public FuncionarioController(Context context)
        {
            _context = context;
        }

        [HttpGet("ObterTodosFuncionarios")]
        public List<FuncionarioModel> Get()
        {
            /* List<FuncionarioModel> lista = new List<FuncionarioModel>();
             lista = new FuncionarioDB().ObterTodosFuncionarios();
             return lista;*/

            //return new FuncionarioDB().ObterTodosFuncionarios();
            return _context.Funcionarios.ToList();
        }

        [HttpGet("ObterDadosFuncionarios")]

        public FuncionarioModel Get([FromQuery] string cpf)
        {
            //return new FuncionarioDB().ObterDadosFuncionarios(cpf);

            return _context.Funcionarios.Single(x => x.Cpf == cpf);

        }

        [HttpPost()]
        public void Post([FromBody] FuncionarioModel cli)
        {
            //new FuncionarioDB().Inserir(cli);

            _context.Funcionarios.Add(cli);
            _context.SaveChanges();
        }

        [HttpPut()]
        public void Put([FromBody] FuncionarioModel c)
        {
            //new FuncionarioDB().Alterar(c);

            _context.Funcionarios.Update(c);
            _context.SaveChanges();
        }


        [HttpDelete()]
        public void delete([FromQuery] string cpf)
        {
            //Utilizando ADO
            //new clientedb().Excluir(cpf);


            //Utilizando o Entity
            FuncionarioModel funcionario = _context.Funcionarios.Single(x => x.Cpf == cpf);
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
        }
    }
}
