using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoRespaldo.Models
{
    public class Informacion
    {
        public string nombre { set; get; }
        public string servidor { get; set; }
        public int porcentaje { get; set; }
        public bool status { get; set; }
        public DateTime fecha_inicio { get; set; }

        public Informacion( string nombre, string servidor, int porcentaje, bool status, DateTime fecha_inicio ) 
        {
            this.nombre = nombre;
            this.servidor = servidor;
            this.porcentaje = porcentaje;
            this.status = status;
            this.fecha_inicio = fecha_inicio;
        }
    }
}