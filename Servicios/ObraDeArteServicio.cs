using BD.ModeloEF;
using BD.Repositorios.Interfaces;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ObraDeArteServicio : IObraDeArteServicio
    {

        private IObraDeArteRepositorio _obraDeArteRepo;
        public ObraDeArteServicio(IObraDeArteRepositorio obraDeArteRepo)
        {
            _obraDeArteRepo = obraDeArteRepo;
        }
        public void Grabar(ObraDeArte obraDeArte)
        {
            _obraDeArteRepo.Grabar(obraDeArte);
            _obraDeArteRepo.SaveChanges();
        }

        public List<ObraDeArte> ObtenerTodos()
        {
            return _obraDeArteRepo.ObtenerTodos();
        }

        public List<ObraDeArte> ObtenerTodosSigloxix()
        {
            return _obraDeArteRepo.ObtenerTodosSigloxix();
        }

        public void SaveChanges()
        {
            _obraDeArteRepo.SaveChanges();
        }
    }
}
