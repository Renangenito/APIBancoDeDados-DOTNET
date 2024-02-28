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

    public class ClienteController : ControllerBase
    {
        private readonly Context _context;

        public ClienteController(Context context)
        {
            _context = context;
        }

        

       [HttpGet("ObterTodosClientes")]
       public List<ClienteModel> Get()
        {
            /* List<ClienteModel> lista = new List<ClienteModel>();
             lista = new ClienteDB().ObterTodosClientes();
             return lista;*/


            //Utilizando ADO
            //return new ClienteDB().ObterTodosClientes();


            //Utilizando o Entity
            return _context.Clientes.ToList();
        }

        [HttpGet("ObterDadosClientes")]

        public ClienteModel Get([FromQuery] string cpf)
        {
            //Utilizando ADO
            //return new ClienteDB().ObterDadosClientes(cpf);


            //Utilizando o Entity

            return _context.Clientes.Single(x => x.Cpf == cpf);
        }

        [HttpPost()]
        public void Post([FromBody] ClienteModel cli)
        {
            //Utilizando ADO
            //new ClienteDB().Inserir(cli);

            //Utilizando o Entity
            _context.Clientes.Add(cli);
            _context.SaveChanges();
        }

        [HttpPut()]
        public void Put([FromBody] ClienteModel c)
        {
            //Utilizando ADO
            //new ClienteDB().Alterar(c);


            //Utilizando o Entity
            _context.Clientes.Update(c);
            _context.SaveChanges();
        }



        [HttpDelete()]
        public void delete([FromQuery] string cpf)
        {
            //Utilizando ADO
            //new clientedb().Excluir(cpf);


            //Utilizando o Entity
            ClienteModel cliente = _context.Clientes.Single(x => x.Cpf == cpf);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }


    }
}
