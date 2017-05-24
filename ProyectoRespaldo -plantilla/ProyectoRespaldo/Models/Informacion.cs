using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoRespaldo.Models
{
    public class Informacion
    {
        public string nombre { set; get; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public bool status { get; set; }
        public DateTime fecha_nac { get; set; }

        public Informacion( string nombre, string apellido, int edad, bool status, DateTime fecha_nac ) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.status = status;
            this.fecha_nac = fecha_nac;
        }
    }
}