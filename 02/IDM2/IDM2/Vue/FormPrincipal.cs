using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Entity;
using IDM2.Controleur;
using IDM2.Vue;
using IDM2.BaseDonnee;


namespace IDM2
{
    public partial class FormPrincipal : Form
    {
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


        private CoClient _controllerClient;
        private CoCodeElectronique _controllerCode;
        private CoTelephone _controllerTelephone;
        private CoVille _controllerVille;
        private CoSite _controllerSite;

        private FormTaxes _formTaxe;
        private bool _afficherTousClients;
        private GroupBox _dossierClient;
        private Client _clientSelectionner;

        public FormPrincipal()
        {
            DonneeMemoire.Initialiser();
            _formTaxe = new FormTaxes();

            InitializeComponent();

            _controllerCode = new CoCodeElectronique();
            _controllerClient = new CoClient();
            _controllerTelephone = new CoTelephone();
            _controllerVille = new CoVille();
            _controllerSite = new CoSite();

            _afficherTousClients = false;

            pnlSolde.BackColor = Color.Gray;
        }


        private List<Client> _resultatRecherche = new List<Client>();

        private void tabControlIDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            gBoxSearchDoorResult.Visible = false;
            //gBoxCustResult.Visible = false;
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetVille.Ville'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.villeTableAdapter.Fill(this.dataSetVille.Ville);
            // TODO: cette ligne de code charge les données dans la table 'dataSetIDM.Porte'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.porteTableAdapter.Fill(this.dataSetIDM.Porte);

        }

        private void listBoxResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dossierClient != null)
                FermerDossierClient();

            
            if (listBoxResultat.SelectedItems.Count == 1)
            {
                _clientSelectionner = _resultatRecherche[listBoxResultat.SelectedIndex];
                OuvrirDossierClient(_clientSelectionner);
            }
        }

        private void OuvrirDossierClient(Client client)
        {
            btnModifierClient.Enabled = true;
            btnEffectuerPaiement.Enabled = true;
            btnVoirSoldeClient.Enabled = true;
            btnFermerDossier.Enabled = true;
            btnCreerContrat.Enabled = true;


            DossierClient ds = new DossierClient(client);
            _dossierClient = ds.ObtenirVueDossierClient();

            _dossierClient.Parent = groupBoxDossierClient;
            _dossierClient.Location = new Point(0, 0);

            //List<InfoClient> infoClient = new List<InfoClient>();
            //Telephone[] telsClient = _controllerTelephone.ObtenirTelephones(client);
            //pnlSolde.BackColor = Color.Green;


            //if (client.Prenom != null)
            //    infoClient.Add(new InfoClient("Nom", client.Prenom + " " + client.Nom));
            //else
            //    infoClient.Add(new InfoClient("Nom", client.Nom));

            //if (client.DateEntree != null)
            //    infoClient.Add(new InfoClient("DateInscription", "Date d'inscription: " + client.DateEntree.Value.Day + " " + Tools.GetMonth(client.DateEntree.Value.Month) + " " + client.DateEntree.Value.Year));

            //if (client.Adresse != null && client.VilleId != null)
            //    infoClient.Add(new InfoClient("Adresse", client.Adresse + " " + _controllerVille.ObtenirVille((int)client.VilleId).Ville1));

            //for (int i = 0; i < telsClient.Length; i++)
            //    infoClient.Add(new InfoClient("Telephone" + telsClient[i].Description, telsClient[i].NoTel + "  ( " + telsClient[i].Description + ": " + telsClient[i].Contact + " )"));

            //if (client.Commentaire != null)
            //    infoClient.Add(new InfoClient("Commentaire", "Commentaire: " + client.Commentaire));

            //// Ajouter methode de paiement

            //int x = 17;
            //int y = 2;

            //for (int i = 0; i < infoClient.Count; i++)
            //{
            //    Label label = new Label();
            //    label.Location = new System.Drawing.Point(x, y += 30);
            //    label.Parent = groupBoxDossierClient;
            //    label.Name = "lbl" + infoClient[i].NomInfo;
            //    label.Text = infoClient[i].Info;
            //    label.Size = new System.Drawing.Size(infoClient[i].Info.Length * 6, 13);
            //    groupBoxDossierClient.Controls.Add(label);
            //    _labels.Add(label);
            //}
        }

        private void FermerDossierClient()
        {
            groupBoxDossierClient.Controls.Remove(_dossierClient);

            //_labels.Clear();

            btnModifierClient.Enabled = false;
            btnVoirSoldeClient.Enabled = false;
            btnEffectuerPaiement.Enabled = false;
            btnFermerDossier.Enabled = false;
            btnCreerContrat.Enabled = false;

            pnlSolde.BackColor = Color.Gray;
        }



        #region ButtonEvent


        private void btnCreerContrat_Click(object sender, EventArgs e)
        {
            FormContrat f = new FormContrat(_clientSelectionner);
            f.Show();
        }

        private void buttonNewPlace_Click(object sender, EventArgs e)
        {
            gBoxNewPlace.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gBoxNewPayementMethod.Visible = true;
        }

        private void buttonCloseNewPlace_Click(object sender, EventArgs e)
        {
            gBoxNewPlace.Visible = false;
        }

        private void buttonCloseNewPaiement_Click(object sender, EventArgs e)
        {
            gBoxNewPayementMethod.Visible = false;
        }

        private void btnNewPayementMethod_Click(object sender, EventArgs e)
        {
            gBoxNewPayementMethod.Visible = true;
        }

        private void btnSaveNewPayementMethod_Click(object sender, EventArgs e)
        {
        }

        private void formAjoutClient_FormClosed(object sender, EventArgs e)
        {
            btnAfficherTousClients_Click(sender, e);
        }

        private void buttonAjoutClient_Click(object sender, EventArgs e)
        {
            AjoutClient formAjoutClient = new AjoutClient();
            formAjoutClient.AccessibleName = "INSERT";
            formAjoutClient.Show();
            formAjoutClient.FormClosed += new FormClosedEventHandler(formAjoutClient_FormClosed);

            //Control[] c = formAjoutClient.Controls[0].Controls.Find("btnAddNewCustomer", false);
            //c[0].Text = "Ajouter le client";
            //c[0].AccessibleName = "INSERT";

            if (_afficherTousClients)
                btnAfficherTousClients_Click(sender, e);
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            AjoutClient formModifClient = new AjoutClient();

            formModifClient.Text = "Modifier le client"; // Ajouter le nom du client
            Control[] c = formModifClient.Controls[0].Controls.Find("btnAddNewCustomer", false);

            c[0].Text = "Sauvegarder";
            formModifClient.AccessibleName = "UPDATE";


            formModifClient.Show();
            formModifClient.AjouterDonneeClient(_clientSelectionner);
            formModifClient.ClientOrigine = _clientSelectionner;
        }

        private void buttonAjouterPorte_Click(object sender, EventArgs e)
        {
            FormAjoutEspace formAjoutPorte = new FormAjoutEspace();
            formAjoutPorte.Show();
        }

        private void buttonRecherchePorte_Click(object sender, EventArgs e)
        {
            gBoxSearchDoorResult.Visible = true;
        }

        private void btnCustClose_Click(object sender, EventArgs e)
        {
            //gBoxCustResult.Visible = false;
        }

        private void btnEffectuerPaiement_Click(object sender, EventArgs e)
        {
            FormPaiement fp = new FormPaiement(_clientSelectionner);
            fp.Show();
        }

        private void btnModifierTax_Click(object sender, EventArgs e)
        {
            FormTaxes f = new FormTaxes();
            f.Show();
            //_formTaxe.Show();
        }

        private void btnFermerDossier_Click(object sender, EventArgs e)
        {
            FermerDossierClient();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            _afficherTousClients = false;
            _resultatRecherche.Clear();
            listBoxResultat.Items.Clear();

            if (rBtnCustSpecificSearchDoor.Checked)
            {

            }

            else if (rBtnCustSpecificSearchLastName.Checked)
            {
                _resultatRecherche.AddRange(_controllerClient.RechercherClientNom(txtFindCustSpecificSearch.Text));
            }


            else if (rBtnCustSpecificSearchPhone.Checked)
            {
                _resultatRecherche.AddRange(_controllerClient.RechercherClientTelephone(txtFindCustSpecificSearch.Text));
            }

            for (int i = 0; i < _resultatRecherche.Count; i++)
                listBoxResultat.Items.Add(_resultatRecherche[i].Prenom + " " + _resultatRecherche[i].Nom);

            //gBoxCustResult.Visible = false;
        }

        #endregion

        private void btnAfficherTousClients_Click(object sender, EventArgs e)
        {
            _afficherTousClients = true;
            _resultatRecherche.Clear();
            listBoxResultat.Items.Clear();

            _resultatRecherche.AddRange(_controllerClient.ObtenirTousLesClients());

            for (int i = 0; i < _resultatRecherche.Count; i++)
                listBoxResultat.Items.Add(_resultatRecherche[i].Prenom + " " + _resultatRecherche[i].Nom);
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (listBoxResultat.SelectedItems.Count == 1)
            {
                DialogResult dg = MessageBox.Show("Êtes-vous sûre de vouloir supprimer définitivement le client " +
                         _clientSelectionner.Prenom + " " + _clientSelectionner.Prenom, "Avertissement", MessageBoxButtons.YesNo);

                if (dg == DialogResult.No)
                    return;
                else if (dg == DialogResult.Yes)
                {
                    DialogResult dg2 = MessageBox.Show("Vous êtes vraiment sure??" +
                         _clientSelectionner.Prenom + " " + _clientSelectionner.Prenom, "Avertissement", MessageBoxButtons.YesNo);

                    if (dg2 == DialogResult.No)
                        return;
                    else if (dg2 == DialogResult.Yes)
                    {
                        _controllerClient.SupprimerClient(_clientSelectionner);
                        _clientSelectionner = null;
                        if (_afficherTousClients)
                            btnAfficherTousClients_Click(sender, e);
                    }
                    else
                        return;
                }
                else return;
            }
        }

        private Site ObtenirInfoSite()
        {
            Site site = new Site();

            site.Adresse = txtNouveauSiteAdresse.Text;
            site.Alias = txtNouveauSiteNom.Text;
            if (_controllerVille.ValiderVille(cmbNouveauSiteVille.Text))
                site.VilleId = (int)cmbNouveauSiteVille.SelectedValue;
            else
                MessageBox.Show("Ville invalide");

            return site;

        }

        private void btnAppliquerNouveauSite_Click(object sender, EventArgs e)
        {
            _controllerSite.AjouterSite(ObtenirInfoSite());
        }






    }
}
