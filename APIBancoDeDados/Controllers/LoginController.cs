using APIBancoDeDados.Database;
using APIBancoDeDados.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBancoDeDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        [AllowAnonymous]

        public async Task<ActionResult<loginRespostaModel>> Login([FromBody] loginRequisicaoModel loginRequisicaoModel)
        {
            return Ok(await new LoginServico().Login(loginRequisicaoModel));
        }

    }
}
