using System.ComponentModel.DataAnnotations;

namespace Financeiro.Models
{
    public class Tipo
    {
        [Key]
        public int Id { get; set; }

        public string Metodo { get; set; }
    }
}
