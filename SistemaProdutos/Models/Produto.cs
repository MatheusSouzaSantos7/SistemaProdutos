using System.ComponentModel.DataAnnotations; // Nome: Matheus Angelo de Souza Santos - CB3025489
namespace SistemaProdutos.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser negativa.")]
        public int Quantidade { get; set; }
    }
}
