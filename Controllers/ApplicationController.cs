using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebFormulario.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signo(int Dia,string Mes, string Usuario)
        {
            var Resultado = "";
         

            switch (Mes)
            {
                case "1": //Enero-Diciembre, con sus números respectivos del 1 al 12
                    if (Dia < 21)
                        Resultado = "Capricornio";
                    else
                        Resultado = "Acuario";
                    break;
                case "2":
                    if (Dia < 19)
                        Resultado = "Acuario";
                    else
                        Resultado = "Piscis";
                    break;
                case "3":
                    if (Dia < 21)
                        Resultado = "Piscis";
                    else
                        Resultado = "Aries";
                    break;
                case "4":
                    if (Dia < 21)
                        Resultado = "Aries";
                    else
                        Resultado = "Tauro";
                    break;
                case "5":
                    if (Dia < 22)
                        Resultado = "Tauro";
                    else
                        Resultado = "Geminis";
                    break;
                case "6":
                    if (Dia < 22)
                        Resultado = "Geminis";
                    else
                        Resultado = "Cancer";
                    break;
                case "7":
                    if (Dia < 23)
                        Resultado = "Cancer";
                    else
                        Resultado = "Leo";
                    break;
                case "8":
                    if (Dia < 24)
                        Resultado = "Leo";
                    else
                        Resultado = "Virgo";
                    break;
                case "9":
                    if (Dia < 24)
                        Resultado = "Virgo";
                    else
                        Resultado = "Libra";
                    break;
                case "10":
                    if (Dia < 24)
                        Resultado = "Libra";
                    else
                        Resultado = "Escorpió";
                    break;
                case "11":
                    if (Dia < 23)
                        Resultado = "Escorpió";
                    else
                        Resultado = "Sagitario";
                    break;
                case "12":
                    if (Dia < 22)
                        Resultado = "Sagitario";
                    else
                        Resultado = "Capricornio";
                    break;
            }

            return RedirectToAction("Resultado", new { Resultado = Resultado, Hola = Usuario });

        }

        public IActionResult Resultado(string Resultado, string Hola)
        {
            ViewBag.Resultado = Resultado;
            ViewBag.Hola = Hola;
            return View();
        }
    }
}