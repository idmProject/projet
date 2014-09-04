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

        public void ModifierTelephones(Telephone[] newTelephones, Client client)
        {
            List<Telephone> oldTelephone = _bd.Telephone.Where(t => t.ClientId == client.ClientId).ToList();
            List<Telephone> telephones = newTelephones.ToList();

            while (telephones.Count != 0)
            {
                if (oldTelephone.Count > 0 && telephones.Count > 0)
                {
                    oldTelephone[0].NoTel = telephones[0].NoTel;
                    oldTelephone[0].Contact = telephones[0].Contact;
                    oldTelephone[0].Description = telephones[0].Description;

                    oldTelephone.RemoveAt(0);
                    telephones.RemoveAt(0);
                }

                else if (oldTelephone.Count == 0 && telephones.Count > 0)
                {
                    AjouterTelephones(telephones, client);
                    telephones.Clear();
                    oldTelephone.Clear();
                }
            }

            if (oldTelephone.Count != 0)
            {
                _bd.Telephone.RemoveRange(oldTelephone);
            }


            //for (int i = 0; i < oldTelephone.Length; i++)
            //{
            //    oldTelephone[i].NoTel = newTelephones[i].NoTel;
            //    oldTelephone[i].Contact = newTelephones[i].Contact;
            //    oldTelephone[i].Description = newTelephones[i].Description;
            //}

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
