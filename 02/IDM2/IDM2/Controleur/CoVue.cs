using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;

namespace IDM2.Controleur
{

    public class CoVue
    {
        private IDM_DATAEntities _bd;

        public CoVue()
        {
            _bd = Contexte.Bd;
            
        }

        public DossiersLocalView ObtenirDossierLocalView(int espaceId)
        {
            return _bd.DossiersLocalView.Find(espaceId);
        }

        public DossierStationnementView ObtenirDossierStationnementView(int espaceId)
        {
            return _bd.DossierStationnementView.Find(espaceId);
        }

        
        
    }
}
