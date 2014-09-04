using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.Controleur;

namespace IDM2.BaseDonnee
{
    public static class DonneeMemoire
    {
        public static Taxe Tps  { get; set; }
        public static Taxe Tvq { get; set; }

        static DonneeMemoire()
        {
            Tps = Controller.Taxe.ObtenirTpsPlusRecente();
            Tvq = Controller.Taxe.ObtenirTvqPlusRecente();
        }

        public static void Initialiser()
        {
            
        }
    }
}
