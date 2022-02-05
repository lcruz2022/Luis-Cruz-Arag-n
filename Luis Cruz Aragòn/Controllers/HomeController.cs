using Luis_Cruz_Aragòn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Luis_Cruz_Aragòn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Simulacion
            List<ClassCliente> cliente = new List<ClassCliente>();

            cliente.Add(new ClassCliente()
            {
                Nombre = "Luis",
                Direccion= "Granada",
                Telefono = "8888888",
                Edad = 30
            });

            cliente.Add(new ClassCliente()
            {
                Nombre = "Jose",
                Direccion = "Managua",
                Telefono = "8888888",
                Edad = 30
            });
            cliente.Add(new ClassCliente()
            {
                Nombre = "Jose",
                Direccion = "Managua",
                Telefono = "8888888",
                Edad = 30
            });
            cliente.Add(new ClassCliente()
            {
                Nombre = "Jose",
                Direccion = "Managua",
                Telefono = "8888888",
                Edad = 30
            });
            cliente.Add(new ClassCliente()
            {
                Nombre = "Jose",
                Direccion = "Managua",
                Telefono = "8888888",
                Edad = 30
            });

            return View(cliente);
        }
        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
