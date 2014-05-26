using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;

namespace IDM2.Controleur
{
    public class CoVille
    {
        private IDM_DATAEntities _bd;

        public CoVille()
        {
            _bd = Contexte.Bd;
        }

        public Ville ObtenirVille(int villeId)
        {
            return _bd.Ville.Find(villeId);
        }

        //private MoVille DataToModel(Ville ville)
        //{
        //    MoVille mVille = new MoVille();
        //    mVille.Ville = ville.Ville1;
        //    mVille.VilleId = ville.VilleId;

        //    return mVille;
        //}

        public bool ValiderVille(string ville)
        {
            return (_bd.Ville.Count(v => v.Ville1 == ville)) == 1;
        }
    }
}
