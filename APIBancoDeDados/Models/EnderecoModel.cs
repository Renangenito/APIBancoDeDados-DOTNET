﻿using System.ComponentModel.DataAnnotations;

namespace APIBancoDeDados.Models
{
    public class EnderecoModel
    {
        [Required(ErrorMessage = "O Logradouro é obrigatório!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Este campo deve ter no mínimo 5 e no máximo 50 caracteres!")]
        public string Logradouro { get; set; } = "";

        [Required(ErrorMessage = "O Numero é obrigatório!")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Este campo deve ter no mínimo 1 e no máximo 20 caracteres!")]
        public string Numero { get; set; } = "";

        public string? Complemento { get; set; }

        [Required(ErrorMessage = "O Cidade é obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Este campo deve ter no mínimo 3 e no máximo 50 caracteres!")]
        public string Cidade { get; set; } = "";

        [Required(ErrorMessage = "O Estado é obrigatório!")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Este campo deve ter no mínimo 9 e no máximo 30 caracteres!")]
        public string Estado { get; set; } = "";


    }
}
