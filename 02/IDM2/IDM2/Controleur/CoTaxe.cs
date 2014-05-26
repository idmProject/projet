using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;

namespace IDM2.Controleur
{
    public class CoTaxe
    {
        private IDM_DATAEntities _bd;

        public CoTaxe()
        {
            _bd = Contexte.Bd;
        }

        public Taxe AjouterTaxe(Taxe taxe)
        {
            _bd.Taxe.Add(taxe);
            _bd.SaveChanges();
           
            return taxe;
        }

        public Taxe ObtenirTpsPlusRecente()
        {
           return  _bd.Taxe.OrderByDescending(t => t.DateModification).Where(t => t.Type == "TPS").First();
        }

        public Taxe ObtenirTvqPlusRecente()
        {
            return _bd.Taxe.OrderByDescending(t => t.DateModification).Where(t => t.Type == "TVQ").First();
        }

    }
}
