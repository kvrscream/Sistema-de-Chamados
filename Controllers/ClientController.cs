using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avaliacao.Data;
using avaliacao.Models;
using Microsoft.AspNetCore.Mvc;
using avaliacao.services;
using Microsoft.AspNetCore.Authorization;

namespace avaliacao.Controllers
{
    public class ClientController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();
            if (ModelState.IsValid)
            {
                retorno = new ClienteService(context: _context).Create(cliente: cliente);
                if(retorno.Count > 0)
                {
                    ViewBag.retorno = "<p class='alert alert-danger'>Cliente não pode ser cadastrado! Motivo: " + retorno.FirstOrDefault().Value + "</p>";
                } else
                {
                    ViewBag.retorno = "<p class='alert alert-success'>Cliente cadastrado com sucesso!</p>";
                }

            } 

            return View(cliente);
        }


        [Authorize]
        public IActionResult Edit(int Id)
        {
            Cliente client = new ClienteService(context: _context).GetSingleClient(Id: Id);
            return View(client);
        }


        [Authorize]
        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            Dictionary<string, string> retorno = new Dictionary<string, string>();
            if (ModelState.IsValid)
            {
                retorno = new ClienteService(context: _context).Edit(cliente: cliente);
                if (retorno.Count > 0)
                {
                    ViewBag.retorno = "<p class='alert alert-danger'>Cliente não pode ser editado! Motivo: " + retorno.FirstOrDefault().Value + "</p>";
                }
                else
                {
                    ViewBag.retorno = "<p class='alert alert-success'>Cliente ediado com sucesso!</p>";
                }

            }

            return View(cliente);
        }

        [HttpPost]
        public JsonResult ClientDetails([FromBody] int clientId)
        {
            Cliente client = new ClienteService(context: _context).GetSingleClient(Id: clientId);
            return Json(new { success = true, cliente = client });
        }

    }
}