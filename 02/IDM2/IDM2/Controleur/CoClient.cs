using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2
{
    public class CoClient
    {
        private IDM_DATAEntities _bd;
        private CoTelephone _controllerTelephone;

        public CoClient()
        {
            _bd = Contexte.Bd;
            _controllerTelephone = new CoTelephone();
        }

        public Client AjouterClient(Client client)
        {
            client.Ville = _bd.Ville.Find(client.VilleId);
           


            _bd.Client.Add(client);
            _bd.SaveChanges();

            return _bd.Client.Find(client.ClientId);
        }

        public void ModifierClient(Client client, Client newClient)
        {

            client.Actif = newClient.Actif;
            client.Adresse = newClient.Adresse;
            //client.CodeElect = newMClient.CodeElectronique;
            //client.DateEntree = (DateTime)newMClient.DateEntree;
            client.Nom = newClient.Nom;
            client.Prenom = newClient.Prenom;
            //client.VilleId = (int)newMClient.VilleId;

            _bd.SaveChanges();
        }


        public Client[] RechercherClientNom(string nom)
        {
            return  _bd.Client.Where(c => c.Nom == nom || c.Prenom == nom).ToArray();
        }


        public Client RechercherClientId(int id)
        {
            return _bd.Client.Find(id);
        }

        public Client[] RechercherClientTelephone(string noTel)
        {
            Telephone[] tels = _controllerTelephone.ObtenirTelephones(noTel);
            List<Client> clients = new List<Client>();
            for (int i = 0; i < tels.Length; i++)
                clients.Add(_bd.Client.Find(tels[i].ClientId));

            return clients.ToArray();
        }

        public Client[] ObtenirTousLesClients()
        {
            return _bd.Client.ToArray();
        }

        public void SupprimerClient(Client client)
        {
            _bd.Client.Remove(_bd.Client.Find(client.ClientId));
            _bd.SaveChanges();
        }

        public void SupprimerClient(Client[] client)
        {
            _bd.Client.RemoveRange(client);
            _bd.SaveChanges();
        }
       
    }
}
