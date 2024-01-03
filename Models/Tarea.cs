using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_API.Models
{
    public class Tarea
    {
        public Guid TareaId { get; set; }
        public Guid CategoriaId { get; set; }
        public String Titulo { get; set; }

        public Prioridad PrioridadTarea { get; set; }

        public DateTime FechaCreacion { get; set; }

        //Con esta linea le asigno a cada tarea una categoria y a su vez puedo solicitar una tarea por su categoria asignada 
        public virtual Categoria Categoria { get; set; }  
    }

    public enum Prioridad
    {
        Baja,

        Media,

        Alta,
    }
}

