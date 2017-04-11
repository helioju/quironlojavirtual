using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosporPagina = 3;

        // GET: Vitrine
        public ActionResult ListaProdutos(int Pagina = 1)
        {

            _repositorio = new ProdutosRepositorio();
            var Produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((Pagina - 1) * ProdutosporPagina)
                .Take(ProdutosporPagina);

            return View(Produtos);
        }
    }
}