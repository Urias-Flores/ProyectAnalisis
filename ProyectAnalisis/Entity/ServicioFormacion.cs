//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectAnalisis.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServicioFormacion
    {
        public int ServicioFormacionID { get; set; }
        public int ModuloID { get; set; }
        public int UsuarioID { get; set; }
        public int DepartamentoID { get; set; }
        public int MunicipioID { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFinal { get; set; }
        public string Modalidad { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Modulo Modulo { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
