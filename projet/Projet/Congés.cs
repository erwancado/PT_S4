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
    
    public partial class Congés
    {
        public int idCongés { get; set; }
        public System.DateTime Datedébut { get; set; }
        public System.DateTime DateFin { get; set; }
        public int Utilisateurs_idUtilisateurs { get; set; }
        public int Type_congés_idType_congés { get; set; }
    
        public virtual Type_congés Type_congés { get; set; }
        public virtual Utilisateurs Utilisateurs { get; set; }
    }
}
