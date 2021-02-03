using PaginacaoAspNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using X.PagedList;

namespace PaginacaoAspNetMvc.Controllers
{
    public class ProdutosController : Controller
    {
		private LojaContext db = new LojaContext();
        // GET: Produtos
        public ActionResult Index(int pagina = 1)
        {
			var produtos = db.Produtos.OrderBy(p => p.Id).ToPagedList(pagina, 10);
            return View(produtos);
        }
    }
}
