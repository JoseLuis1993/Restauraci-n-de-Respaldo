//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoRespaldo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class servidor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public servidor()
        {
            this.maquina_virtual = new HashSet<maquina_virtual>();
            this.Comando = new HashSet<Comando>();
        }
    
        public int id_servidor { get; set; }
        public string nombre { get; set; }
        public string direccion_ip { get; set; }
        public string tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<maquina_virtual> maquina_virtual { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comando> Comando { get; set; }
    }
}
