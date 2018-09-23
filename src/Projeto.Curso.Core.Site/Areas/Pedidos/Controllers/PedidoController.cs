using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto.Curso.Core.Application.Pedido.Interfaces.AgregracaoPedidos;

namespace Projeto.Curso.Core.Site.Areas.Pedidos.Controllers
{
    [Area("Pedidos")]
    public class PedidoController : Controller
    {
        private readonly IApplicationPedidos apppedidos;

        public PedidoController(IApplicationPedidos _apppedidos)
        {
            apppedidos = _apppedidos;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ListagemPedidosJson()
        {
            var lista = apppedidos.ObterListagemPedidos();
            var settings = new JsonSerializerSettings();
            return Json(lista, settings);
        }



    }
}