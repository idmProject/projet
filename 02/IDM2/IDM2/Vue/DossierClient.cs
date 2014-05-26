using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.Controleur;
using IDM2.BaseDonnee;
using IDM2.Vue;
using System.Windows.Forms;
using System.Drawing;

namespace IDM2.Vue
{
    public class DossierClient
    {
        private Client _client;
        private CoClient _controllerClient;
        private CoTelephone _controllerTelephone;
        private CoCodeElectronique _controllerCode;
        private CoVille _controllerVille;
        private List<Label> _labels;

        private class InfoClient
        {
            public string Info { get; set; }
            public string NomInfo { get; set; }

            public InfoClient(string nomInfo, string info)
            {
                Info = info;
                NomInfo = nomInfo;
            }
        }

        public DossierClient(Client client)
        {
            _client = client;
            _controllerClient = new CoClient();
            _controllerTelephone = new CoTelephone();
            _controllerCode = new CoCodeElectronique();
            _controllerVille = new CoVille();
            _labels = new List<Label>();
        }

        public  GroupBox ObtenirVueDossierClient()
        {
            GroupBox gb = new GroupBox();

            gb.Size = new Size(300, 589);
            gb.Name = "DossierClient";
            
            //btnModifierClient.Enabled = true;
            //btnEffectuerPaiement.Enabled = true;
            //btnVoirSoldeClient.Enabled = true;
            //btnFermerDossier.Enabled = true;
            //pnlSolde.BackColor = Color.Green;


            List<InfoClient> infoClient = new List<InfoClient>();
            Telephone[] telsClient = _controllerTelephone.ObtenirTelephones(_client);



            if (_client.Prenom != null)
                infoClient.Add(new InfoClient("Nom", _client.Prenom + " " + _client.Nom));
            else
                infoClient.Add(new InfoClient("Nom", _client.Nom));

            if (_client.DateEntree != null)
                infoClient.Add(new InfoClient("DateInscription", "Date d'inscription: " + _client.DateEntree.Value.Day + " " + Tools.GetMonth(_client.DateEntree.Value.Month) + " " + _client.DateEntree.Value.Year));

            if (_client.Adresse != null && _client.VilleId != null)
                infoClient.Add(new InfoClient("Adresse", _client.Adresse + " " + _controllerVille.ObtenirVille((int)_client.VilleId).Ville1));

            for (int i = 0; i < telsClient.Length; i++)
                infoClient.Add(new InfoClient("Telephone" + telsClient[i].Description, Tools.FormatTelephone(telsClient[i].NoTel) + "  ( " + telsClient[i].Description + ": " + telsClient[i].Contact + " )"));

            if (_client.Commentaire != null)
                infoClient.Add(new InfoClient("Commentaire", "Commentaire: " + _client.Commentaire));

            // Ajouter methode de paiement

            int x = 17;
            int y = 2;

            for (int i = 0; i < infoClient.Count; i++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(x, y += 30);
                label.Parent = gb;
                label.Name = "lbl" + infoClient[i].NomInfo;
                label.Text = infoClient[i].Info;
                label.Size = new System.Drawing.Size(infoClient[i].Info.Length * 6, 13);
                gb.Controls.Add(label);
                _labels.Add(label);
            }

            return gb;
        
        }
    }
}
