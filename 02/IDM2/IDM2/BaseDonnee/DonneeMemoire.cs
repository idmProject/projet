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
        private static CoTaxe _controllerTaxe;
        public static Taxe Tps  { get; set; }
        public static Taxe Tvq { get; set; }

        static DonneeMemoire()
        {
            _controllerTaxe = new CoTaxe();
            Tps = _controllerTaxe.ObtenirTpsPlusRecente();
            Tvq = _controllerTaxe.ObtenirTvqPlusRecente();
        }

        public static void Initialiser()
        {
            
        }
    }
}
