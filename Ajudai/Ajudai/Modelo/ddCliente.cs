using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajudai.Modelo
{
    public class ddCliente
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Login")]
        [StringLength(50, MinimumLength = 3)]
        public string login { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [StringLength(128, MinimumLength = 3)]
        public string senha { get; set; }
        public string confirmar { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(100, MinimumLength = 5)]
        public string nome { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [StringLength(100, MinimumLength = 5)]
        public string email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        [StringLength(20, MinimumLength = 8)]
        public string telefone { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Celular")]
        [StringLength(20, MinimumLength = 9)]
        public string celular { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [StringLength(9, MinimumLength = 8)]
        public string cep { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        [StringLength(255, MinimumLength = 5)]
        public string endereco { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        [StringLength(50, MinimumLength = 3)]
        public string cidade { get; set; }

        [Required]
        [Display(Name = "UF")]
        [StringLength(2, MinimumLength = 2)]
        public string uf { get; set; }
    }
}
