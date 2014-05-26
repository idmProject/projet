using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;


namespace IDM2.Controleur
{
    public class CoTelephone
    {
        private IDM_DATAEntities _bd;

        public CoTelephone()
        {
            _bd = Contexte.Bd;
        }

        public void AjouterTelephone(Telephone telephone)
        {
            _bd.Telephone.Add(telephone);
            _bd.SaveChanges();
        }

        public void AjouterTelephones(List<Telephone> telephones, Client client)
        {
            for (int i = 0; i < telephones.Count; i++)
            {
                telephones[i].ClientId = client.ClientId;
                _bd.Telephone.Add(telephones[i]);
            }

            _bd.SaveChanges();
        }

        public Telephone[] ObtenirTelephones(Client client)
        {
            return _bd.Telephone.Where(t => t.ClientId == client.ClientId).ToArray();
        }

        public Telephone[] ObtenirTelephones(string noTel)
        {
            return _bd.Telephone.Where(t => t.NoTel == noTel).ToArray();
        }
    }
}
