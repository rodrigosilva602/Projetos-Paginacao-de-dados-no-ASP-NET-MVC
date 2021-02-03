using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PaginacaoAspNetMvc.Models
{
	public class LojaContext:DbContext
	{
		public LojaContext():base("Loja")
		{
		}

		public DbSet<Produto> Produtos { get; set; }
	}
}
