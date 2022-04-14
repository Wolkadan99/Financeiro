using System.ComponentModel.DataAnnotations;

namespace Financeiro.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
