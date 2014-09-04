using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2
{
    public class CoClient : Co
    {
        private CoTelephone _controllerTelephone;

        public CoClient()
            : base()
        {
            _controllerTelephone = new CoTelephone();
        }

        public Client AjouterClient(Client client)
        {
            client.Ville = _bd.Ville.Find(client.VilleId);



            _bd.Client.Add(client);
            _bd.SaveChanges();

            return _bd.Client.Find(client.ClientId);
        }

        public Client ModifierClient(Client client, Client newClient)
        {
            client = _bd.Client.Find(client.ClientId);
            client.Actif = newClient.Actif;
            client.Adresse = newClient.Adresse;
            client.Nom = newClient.Nom;
            client.Prenom = newClient.Prenom;
            client.Ville = _bd.Ville.Find(newClient.VilleId);
            client.Commentaire = newClient.Commentaire;
            client.DateEntree = newClient.DateEntree;

            _bd.SaveChanges();

            return client;
        }


        public Client[] RechercherClientNom(string nom)
        {
            return _bd.Client.Where(c => c.Nom == nom || c.Prenom == nom).ToArray();
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

        public Client RechercherClientParContrat(int contratId)
        {
            Contrat contrat = _bd.Contrat.Find(contratId);
            return _bd.Client.Find(contrat.ClientId);
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

        public bool EstAssocierContrat(Client client)
        {
            return (_bd.Contrat.Count(c => c.ClientId == client.ClientId) >= 1);
        }


    }
}
