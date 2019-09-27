using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using avaliacao.Models;
using avaliacao.services;
using avaliacao.Data;
using Microsoft.AspNetCore.Authorization;

namespace avaliacao.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            List<Chamados> chamados = new ChamadosService(context: _context).GetAllChamados();
            ViewBag.Clientes = new ClienteService(context: _context).GetAllClients();
            return View(chamados);
        }


        [Authorize]
        [HttpPost]
        public JsonResult Abrir([FromBody] int cliente)
        {
            Cliente client = new ClienteService(context: _context).GetSingleClient(Id:cliente);
            Chamados chamado = new Chamados();
            chamado.cliente = client;
            chamado.DataHoraAbertura = DateTime.Now;
            chamado.Fechado = false;

            Dictionary<string, string> retorno = new Dictionary<string, string>();

            retorno = new ChamadosService(context: _context).Create(chamado: chamado);

            if(retorno.Count > 0)
            {
                return Json(new { success = false, erro = retorno.FirstOrDefault().Key + " " + retorno.FirstOrDefault().Value });
            }

            return Json(new { success = true });
        }

        [Authorize]
        [HttpPost]
        public JsonResult Fechar([FromBody] int chamadoId)
        {
            Chamados chamado = new ChamadosService(context: _context).GetSingleChamado(Id: chamadoId);
            chamado.Fechado = true;
            chamado.DataHoraFechamento = DateTime.Now;

            Dictionary<string, string> retorno = new Dictionary<string, string>();

            retorno = new ChamadosService(context: _context).Edit(chamado: chamado);

            if (retorno.Count > 0)
            {
                return Json(new { success = false, erro = retorno.FirstOrDefault().Key + " " + retorno.FirstOrDefault().Value });
            }

            return Json(new { success = true });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
