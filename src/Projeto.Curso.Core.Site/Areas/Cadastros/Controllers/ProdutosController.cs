using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto.Curso.Core.Application.Pedido.Interfaces;

namespace Projeto.Curso.Core.Site.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class ProdutosController : Controller
    {
        private readonly IApplicationProdutos appprodutos;

        public ProdutosController(IApplicationProdutos _appprodutos)
        {
            appprodutos = _appprodutos;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ListagemProdutosJson()
        {
            var lista = appprodutos.ObterTodos();
            var settings = new JsonSerializerSettings();
            return Json(lista, settings);
        }


    }
}