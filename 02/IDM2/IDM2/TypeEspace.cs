//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDM2
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeEspace
    {
        public TypeEspace()
        {
            this.Espace = new HashSet<Espace>();
        }
    
        public int TypeEspaceId { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Prix { get; set; }
        public int SiteId { get; set; }
        public Nullable<int> Largeur { get; set; }
        public Nullable<int> Longueur { get; set; }
        public bool EstLocal { get; set; }
    
        public virtual ICollection<Espace> Espace { get; set; }
        public virtual Site Site { get; set; }
    }
}
