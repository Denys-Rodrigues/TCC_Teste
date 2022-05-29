using System.ComponentModel.DataAnnotations;

namespace TCC_Teste.Models
{
    public class Condominio
    {
        [Key]
        public Guid IDCondominio { get; set; }

        [Required]
        public string NomeCondominio { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public string UF { get; set; }
    }
}
