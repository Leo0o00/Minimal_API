using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_API.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set;}
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        
        //Aqui puedo ver que tareas tiene asignada cada categoria
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
