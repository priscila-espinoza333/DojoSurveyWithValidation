using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidation.Models;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        string titulo = "Bienvenido a Dojo Survey Validation";
        ViewBag.Titulo = titulo;
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("formulario")]
        public IActionResult Formulario (){
            return View("Formulario");
        }

        [HttpGet("gobackform")]
        public RedirectResult GoBackForm(){
            return Redirect("/formulario");
        }

        [HttpGet]
        [Route("procesa/formulario")]
        public RedirectResult ProcesaFormulario(){
            return Redirect ("/formulario");
        }


        [HttpPost]
        [Route("info/formulario")]
public IActionResult ProcesaFormulario(DatosFormulario model)
{
    if (ModelState.IsValid)
    {
        // El modelo es válido, puedes continuar con el procesamiento.
        string nombre = model.Nombre;
        string locacion = model.Locacion;
        string lenguajeFavorito = model.LenguajeFavorito;
        string comentario = model.Comentario;

        ViewBag.Nombre = nombre;
        ViewBag.Locacion = locacion;
        ViewBag.LenguajeFavorito = lenguajeFavorito;
        ViewBag.Comentario = comentario;

        return View("Result");
    }
    else
    {
        return View("Formulario", model);
    }
}
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
