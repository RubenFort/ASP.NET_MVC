using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_app.Models
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Paginas { get; set; }
        public string Descrip { get; set; }
        public string CorreoContacto { get; set; }
        public bool Adoptado { get; set; }
    }
}