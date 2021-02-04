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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;
        public UsuarioController(IUsuarioService service)
        {
            usuarioService = service;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUsuario(Usuario usuario)
        {
            try
            {
                return Json(usuarioService.Insert(usuario));
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
                return Json(usuarioService.GetAll<Usuario>());
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, ex = ex });
            }

        }

    }
}
