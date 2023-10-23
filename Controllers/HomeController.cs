using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series=BD.ObtenerSeries();
        return View();
    }
    public Serie VerInfoSerie(int idS){
        return BD.ObtenerInfoSerie(idS);
    }
    public List<Actor> VerActores(int idS){
        return BD.ObtenerActores(idS);
    }
    public List<Temporada> VerTemporadas(int idS){
        return BD.ObtenerTemporadas(idS);
    }
}
