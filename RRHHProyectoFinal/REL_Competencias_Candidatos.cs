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
    
    public partial class REL_Competencias_Candidatos
    {
        public int IdRel_Competencias_Candidatos { get; set; }
        public int IdCandidato_Rel_Competencias_Candidatos { get; set; }
        public int IdCompetencia_Rel_Competencias_Candidatos { get; set; }
    
        public virtual Candidatos Candidatos { get; set; }
        public virtual Competencias Competencias { get; set; }
    }
}