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

        public Espace[] ObtenirEspacesParType(int typeEspaceId)
        {
            return _bd.TypeEspace.Find(typeEspaceId).Espace.ToArray();
        }

        public Espace[] ObtenirTousEspaces()
        {
            return _bd.Espace.ToArray();
        }

        public bool EstLocal(int espaceId)
        {
            return _bd.Espace.Find(espaceId).TypeEspace.EstLocal;
        }

        public Espace ObtenirEspaceParContrat(int contratId)
        {
            Contrat contrat = _bd.Contrat.Find(contratId);
            return _bd.Espace.Find(contrat.EspaceId);
        }

        public void ChangerDisponibilite(int espaceId, bool disponibilite)
        {
            _bd.Espace.Find(espaceId).Disponible = disponibilite;
        }

        public void MiseAJourDisponibilite()
        {
            Espace[] espaces = _bd.Espace.ToArray();
            Contrat[] contratsActifs = Controller.Contrat.ContratsActifs();

            for (int i = 0; i < contratsActifs.Length; i++)
                _bd.Espace.Find(contratsActifs[i].EspaceId).Disponible = false;

            for (int i = 0; i < espaces.Length; i++)
            {
                int n = contratsActifs.Count(c => c.EspaceId == espaces[i].EspaceId);

                switch (n)
                {
                    case 0:
                        espaces[i].Disponible = true;
                        break;
                    case 1:
                        espaces[i].Disponible = false;
                        break;
                    default:
                        throw new Exception("espace associer a plus d'un contrat " + n + " espaceId" + espaces[i].EspaceId);
                        break;
                }
            }

        }
    }
}
