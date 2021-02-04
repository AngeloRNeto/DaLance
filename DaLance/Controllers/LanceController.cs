using DaLance.Domain.Models;
using DaLance.Domain.Services;
using DaLance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DaLance.Controllers
{
    public class LanceController : Controller
    {
        private readonly ILanceService lanceService;
        private readonly IUsuarioService usuService;
        public LanceController(ILanceService service, IUsuarioService usuarioService)
        {
            lanceService = service;
            usuService = usuarioService;
        }

        public IActionResult Create()
        {
            ViewBag.lstUsers = usuService.GetAll<Usuario>();
            return View();
        }

        [HttpGet]
        public ActionResult GetList()
        {
            try
            {
                return Json(lanceService.GetAll<Lance>());
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, ex = ex });
            }

        }

    }
}
