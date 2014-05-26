using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Controleur
{

    public class CoSite
    {
        private IDM_DATAEntities _bd;

        public CoSite()
        {
            _bd = Contexte.Bd;
        }

        public void AjouterSite(Site site)
        {
            _bd.Site.Add(site);
            _bd.SaveChanges();
        }

        public Site ObtenirSite(int id)
        {
            return _bd.Site.Find(id);
        }
    }
}
