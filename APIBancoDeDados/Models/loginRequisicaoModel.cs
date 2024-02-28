using System.ComponentModel.DataAnnotations;

namespace APIBancoDeDados.Models
{
    public class loginRequisicaoModel
    {

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Senha { get; set; }

       
    }
}
