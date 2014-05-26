using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Controleur
{
    public class CoStationnement
    {
        private IDM_DATAEntities _bd;

        public CoStationnement()
        {
            _bd = Contexte.Bd;
        }

        public Stationnement AjouterStationnement(Stationnement stationnement)
        {
            _bd.Stationnement.Add(stationnement);
            _bd.SaveChanges();
            return stationnement;
        }

        public Stationnement ObtenirStationnement(int espaceId)
        {
            return _bd.Stationnement.Find(espaceId);
        }
    }
}
