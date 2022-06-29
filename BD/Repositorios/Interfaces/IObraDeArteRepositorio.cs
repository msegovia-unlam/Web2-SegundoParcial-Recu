using BD.ModeloEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Repositorios.Interfaces
{
    public interface IObraDeArteRepositorio
    {
        public List<ObraDeArte> ObtenerTodos();

        public List<ObraDeArte> ObtenerTodosSigloxix();


        public void Grabar(ObraDeArte obraDeArte);
        public void SaveChanges();
    }
}
