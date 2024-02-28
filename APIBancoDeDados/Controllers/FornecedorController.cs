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

    public class FornecedorController : ControllerBase
    {
        private readonly Context _context;

        public FornecedorController(Context context)
        {
            _context = context;
        }

        [HttpGet("ObterTodosFornecedores")]
        public List<FornecedorModel> Get()
        {
            /* List<FornecedorModel> lista = new List<FornecedorModel>();
             lista = new FornecedorDB().ObterTodosFornecedores();
             return lista;*/

            //return new FornecedorDB().ObterTodosFornecedores();
            return _context.Fornecedores.ToList();
        }

        [HttpGet("ObterDadosFornecedores")]

        public FornecedorModel Get([FromQuery]string cnpj)
        {
            //return new FornecedorDB().ObterDadosFornecedores(cnpj);
            return _context.Fornecedores.Single(x => x.CNPJ == cnpj);

        }

        [HttpPost()]
        public void Post([FromBody] FornecedorModel cli)
        {
            //new FornecedorDB().Inserir(cli);
            _context.Fornecedores.Add(cli);
            _context.SaveChanges();
        }

        [HttpPut()]
        public void Put([FromBody] FornecedorModel c)
        {
            //new FornecedorDB().Alterar(c);
            _context.Fornecedores.Update(c);
            _context.SaveChanges();
        }

        [HttpDelete()]
        public void delete([FromQuery] string cnpj)
        {
            //Utilizando ADO
            //new clientedb().Excluir(cpf);


            //Utilizando o Entity
            FornecedorModel fornecedor = _context.Fornecedores.Single(x => x.CNPJ == cnpj);
            _context.Fornecedores.Remove(fornecedor);
            _context.SaveChanges();
        }
    }
}
