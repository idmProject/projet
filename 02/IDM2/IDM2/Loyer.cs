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
    
    public partial class Loyer
    {
        public Loyer()
        {
            this.Paiement = new HashSet<Paiement>();
        }
    
        public System.DateTime DateLoyer { get; set; }
        public int ContratId { get; set; }
        public decimal MontantLoyer { get; set; }
        public decimal MontantPayer { get; set; }
        public Nullable<bool> EstPayer { get; set; }
    
        public virtual Contrat Contrat { get; set; }
        public virtual ICollection<Paiement> Paiement { get; set; }
    }
}
