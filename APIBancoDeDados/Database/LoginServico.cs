using APIBancoDeDados.Models;

namespace APIBancoDeDados.Database
{
    public class LoginServico
    {
        public async Task<loginRespostaModel>Login(loginRequisicaoModel loginRequisicaoModel)
        {
            loginRespostaModel loginRespostaModel = new loginRespostaModel();
            loginRespostaModel.Autenticado = false;
            loginRespostaModel.Usuario = loginRequisicaoModel.Usuario;
            loginRespostaModel.Token = "";
            loginRespostaModel.DataExpiracao = null;


            if(loginRequisicaoModel.Usuario == "UsuarioDevPratica" && loginRequisicaoModel.Senha == "SenhaDevPratica")
            {
                loginRespostaModel = new GeradorToken().GerarToken(loginRespostaModel);
            }
            return loginRespostaModel;
        }
    }
}
