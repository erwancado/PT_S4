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
    
    public partial class Employés
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employés()
        {
            this.Formations = new HashSet<Formations>();
        }
    
        public int idEmployés { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Téléphone { get; set; }
        public string Email { get; set; }
        public string Salaire { get; set; }
        public System.DateTime DébutContrat { get; set; }
        public System.DateTime FinContrat { get; set; }
        public int Utilisateurs_idUtilisateurs { get; set; }
        public int Fonctions_idFonctions { get; set; }
    
        public virtual Fonctions Fonctions { get; set; }
        public virtual Utilisateurs Utilisateurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Formations> Formations { get; set; }
    }
}
