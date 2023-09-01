using System.ComponentModel.DataAnnotations;
namespace ProjetoRoupas.Models
{
    public class Roupas
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Marca { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Cor { get; set; } = null!;
        public double Preco { get; set; }  
        public bool NoEstoque { get; set; }

    }
}
