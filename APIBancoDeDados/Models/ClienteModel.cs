using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIBancoDeDados.Models
{
    public class ClienteModel : EnderecoModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required(ErrorMessage = "O CPF completo é obrigatório!")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Este campo deve ter 14 caracteres!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório!")]
        [StringLength(30, MinimumLength = 9, ErrorMessage = "Este campo deve ter no mínimo 9 e no máximo 30 caracteres!")]
        public string Rg { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O nome completo é obrigatório!")]
        [StringLength(100, MinimumLength = 5,ErrorMessage = "Este campo deve ter no mínimo 5 e no máximo 100 caracteres!")]
        public string Nome { get; set; }

        [StringLength(15, MinimumLength = 0, ErrorMessage = "Este campo não pode ser em branco!")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O celular é obrigatório!")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Este campo deve ter no mínimo 10 e no máximo 15 caracteres!")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "A data de inclusão é obrigatória!")]
        [Display(Name = "Data Inclusão")]
        public DateTime DataInclusao { get; set; }

        [Display(Name = "Data Alteração")]
        public DateTime? DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
