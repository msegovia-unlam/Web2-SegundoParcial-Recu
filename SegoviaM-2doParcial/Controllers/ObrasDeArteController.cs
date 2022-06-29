using BD.ModeloEF;
using Microsoft.AspNetCore.Mvc;
using Servicios.Interfaces;
using System.Collections.Generic;

namespace SegoviaM_2doParcial.Controllers
{
    public class ObrasDeArteController : Controller
    {

        private IObraDeArteServicio _obraDeArteServicio;

        public ObrasDeArteController(IObraDeArteServicio obraDeArteServicio)
        {
            _obraDeArteServicio = obraDeArteServicio;
        }

        public ActionResult Lista()
        {
            List<ObraDeArte> obrasDeArte = _obraDeArteServicio.ObtenerTodos();

            return View(obrasDeArte);
        }

        [HttpGet]
        public ActionResult Grabar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Grabar(ObraDeArte obraDeArte)
        {
            _obraDeArteServicio.Grabar(obraDeArte);
            return Redirect("/ObrasDeArte/sigloxix");
        }

        public ActionResult sigloxix()
        {
            List<ObraDeArte> obrasDeArte = _obraDeArteServicio.ObtenerTodosSigloxix();

            return View(obrasDeArte);
        }



    }
}
