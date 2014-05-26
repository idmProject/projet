using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Controleur
{

    public class CoEspace
    {
        private IDM_DATAEntities _bd;

        public CoEspace()
        {
            _bd = Contexte.Bd;
        }

        public Espace AjouterEspace(Espace espace)
        {
            _bd.Espace.Add(espace);
            _bd.SaveChanges();

            return espace;
        }

        public Espace ObtenirEspace(int id)
        {
            return _bd.Espace.Find(id);
        }

        public Espace[] ObtenirEspaces(int typeEspaceId)
        {
            return _bd.TypeEspace.Find(typeEspaceId).Espace.ToArray();
        }
    }
}
