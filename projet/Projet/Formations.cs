//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Formations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Formations()
        {
            this.Employés = new HashSet<Employés>();
        }
    
        public int idFormations { get; set; }
        public string Ville { get; set; }
        public System.DateTime DateDébut { get; set; }
        public System.DateTime DateFin { get; set; }
        public string Descript { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employés> Employés { get; set; }
    }
}
