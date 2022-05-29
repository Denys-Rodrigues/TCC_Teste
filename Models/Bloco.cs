using System.ComponentModel.DataAnnotations;

namespace TCC_Teste.Models
{
    public class Bloco
    {
        [Key]
        public Guid IDBloco { get; set; }

        public string NomeBloco { get; set; }

        public int ApartamentoInicial { get; set; }

        public int ApartamentoFinal { get; set; }

        [
        public Guid IDCondominio { get; set; }
    }
}
