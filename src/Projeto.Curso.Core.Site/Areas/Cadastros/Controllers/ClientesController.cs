using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto.Curso.Core.Application.Pedido.Interfaces;
using Projeto.Curso.Core.Application.Pedido.ViewModels;
using Projeto.Curso.Core.Application.Shared.Intefaces;

namespace Projeto.Curso.Core.Site.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class ClientesController : CadastroBaseController
    {

        private readonly IApplicationClientes appclientes;
        private readonly IApplicationShared appshared;

        public ClientesController(IApplicationClientes _appclientes,
                                  IApplicationShared _appshared)
        {
            appclientes = _appclientes;
            appshared = _appshared;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ListagemClientesJson()
        {
            var lista = appclientes.ObterTodos();
            var settings = new JsonSerializerSettings();
            return Json(lista, settings);
        }

        public IActionResult Incluir()
        {
            ViewBag.ListaEstados = appshared.ObterEstados();
            return View();
        }

        [HttpPost]
        public IActionResult Incluir(ClientesViewModel model)
        {
            ViewBag.ListaEstados = appshared.ObterEstados();
            if (!ModelState.IsValid) return View();
            var cliente = appclientes.Adicionar(model);
            ViewBag.RetornoPost = "success,Cliente incluído com sucesso!";
            if (VerificaErros(cliente.ListaErros))
            {
                ViewBag.RetornoPost = "error,Não foi possível incluir o cliente!";
            }
            return View(model);
        }
    }
}