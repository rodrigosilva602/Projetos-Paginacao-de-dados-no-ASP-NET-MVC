using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaginacaoAspNetMvc.Models
{
	[Table("Produtos")]
	public class Produto
	{
		public int Id { get; set; }

		public string Nome { get; set; }

		[Display(Name = "Preço")]
		[DisplayFormat(DataFormatString = "{0:C}")]
		public decimal Preco { get; set; }
	}
}
