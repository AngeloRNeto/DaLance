using DaLance.Domain.Models;
using DaLance.Domain.Services;
using DaLance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DaLance.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService produtoService;
        public ProdutoController(IProdutoService service)
        {
            produtoService = service;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduto(Produto produto)
        {
            try
            {
                return Json(produtoService.Insert(produto));
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, ex = ex });
            }

        }

        [HttpGet]
        public ActionResult GetList()
        {
            try
            {
                return Json(produtoService.GetAll<Produto>());
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, ex = ex });
            }

        }

    }
}
