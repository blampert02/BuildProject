//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTCONSTRUCCIONES
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salida_Inventario
    {
        public Salida_Inventario()
        {
            this.DetalleSalidas = new HashSet<DetalleSalida>();
            this.Entrada_Inventario = new HashSet<Entrada_Inventario>();
        }
    
        public int IdSalida { get; set; }
        public System.DateTime FechaSalida { get; set; }
        public string Descripcion { get; set; }
        public int IdEmpleado { get; set; }
        public Nullable<int> IdProyecto { get; set; }
    
        public virtual ICollection<DetalleSalida> DetalleSalidas { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<Entrada_Inventario> Entrada_Inventario { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}
