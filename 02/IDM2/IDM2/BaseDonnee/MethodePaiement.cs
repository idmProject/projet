//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDM2.BaseDonnee
{
    using System;
    using System.Collections.Generic;
    
    public partial class MethodePaiement
    {
        public MethodePaiement()
        {
            this.Client = new HashSet<Client>();
        }
    
        public int MethodePaiementId { get; set; }
        public string MethodeDescription { get; set; }
    
        public virtual ICollection<Client> Client { get; set; }
    }
}