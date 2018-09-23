using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto.Curso.Core.Application.Pedido.Interfaces;

namespace Projeto.Curso.Core.Site.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class FornecedoresController : Controller
    {
        private readonly IApplicationFornecedores appfornecedor;

        public FornecedoresController(IApplicationFornecedores _appfornecedor)
        {
            appfornecedor = _appfornecedor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ListagemFornecedoresJson()
        {
            var lista = appfornecedor.ObterTodos();
            var settings = new JsonSerializerSettings();
            return Json(lista, settings);
        }


    }
}