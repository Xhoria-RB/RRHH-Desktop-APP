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
    
    public partial class Idiomas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Idiomas()
        {
            this.REL_Idioma_Candidatos = new HashSet<REL_Idioma_Candidatos>();
        }
    
        public int IdIdioma { get; set; }
        public string Nombre_Idiomas { get; set; }
        public Nullable<bool> Estado_Idiomas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REL_Idioma_Candidatos> REL_Idioma_Candidatos { get; set; }
    }
}
