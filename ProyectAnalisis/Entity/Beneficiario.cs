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
    
    public partial class Beneficiario
    {
        public int BenficiarioID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string CorreoElectronico { get; set; }
        public int DepartamentoID { get; set; }
        public int MunicipioID { get; set; }
        public int UsuarioID { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual Municipio Municipio { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}