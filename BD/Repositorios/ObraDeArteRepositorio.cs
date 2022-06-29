using BD.ModeloEF;
using BD.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Repositorios
{
    public class ObraDeArteRepositorio : IObraDeArteRepositorio
    {
        private Parcial2_DbContext _ctx;

        public ObraDeArteRepositorio(Parcial2_DbContext ctx)
        {
            _ctx = ctx;
        }

        public void Grabar(ObraDeArte obraDeArte)
        {
            _ctx.ObraDeArtes.Add(obraDeArte);
        }
                

        public List<ObraDeArte> ObtenerTodos()
        {
            return _ctx.ObraDeArtes.OrderBy(o => o.Nombre).ToList();
        }

        public List<ObraDeArte> ObtenerTodosSigloxix()
        {
            return _ctx.ObraDeArtes.Where(p=>p.AnioCreacion >= 1800 && p.AnioCreacion <= 1899).OrderByDescending(o => o.AnioCreacion).ToList();
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }

        
    }
}
