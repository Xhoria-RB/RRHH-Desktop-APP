//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRHHProyectoFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Email_Usuarios { get; set; }
        public string Contrasena_Usuarios { get; set; }
        public string NombreUsuario_Usuarios { get; set; }
        public int IdPersona_Usuarios { get; set; }
        public string Roles_Usuarios { get; set; }
    
        public virtual Personas Personas { get; set; }
    }
}
