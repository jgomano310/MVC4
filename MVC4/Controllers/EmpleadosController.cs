using DAL.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace MVC4.Controllers
{
    public class EmpleadosController : Controller
    {

        public DAL.Modelo.DeveloferContext db = new DeveloferContext();
        public IActionResult Index()
        {
            var empleados = db.Empleados.ToList();


            return View(empleados);
        }

       
        
    }
}
