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
using System.Windows.Input;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Cache;

namespace IDM2
{
    /// <summary>
    /// AUTEUR: J-R
    /// DESCRIPTION: Vue de la Form principal du projet
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// AUTEUR: J-R
        /// DESCRIPTION: Représente l'information d'un client ainsi que le nom de cette information
        /// </summary>
        private class InfoClient
        {
            public string Info { get; set; }
            public string NomInfo { get; set; }

            /// <summary>
            /// Constructeur InfoClient
            /// </summary>
            /// <param name="nomInfo">Nom de l'information</param>
            /// <param name="info">Donnée de l'information</param>
            public InfoClient(string nomInfo, string info)
            {
                Info = info;
                NomInfo = nomInfo;
            }
        }

        // CHAMPS
        private bool _afficherTousClients;
        private GroupBox _dossierClient;
        private GroupBox _gbSectionAdmin;
        private Client _clientSelectionner;
        private List<Client> _lstRechercheClient = new List<Client>();
        private List<Espace> _lstRechercheEspace = new List<Espace>();
        private Test _test;

        /// <summary>
        /// Constructeur de Form
        /// </summary>
        public FormPrincipal()
        {
            DonneeMemoire.Initialiser();

            InitializeComponent();

            _afficherTousClients = false;

            FormTest ft = new FormTest();
            _test = new Test();
            this.Text = this.Text + _test.Date.ToString();
            ft.Show();
        }

        #region FormEvent

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetVille.Ville'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.villeTableAdapter.Fill(this.dataSetVille.Ville);
            // TODO: cette ligne de code charge les données dans la table 'dataSetIDM.Porte'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.porteTableAdapter.Fill(this.dataSetIDM.Porte);
            FormTest ft = new FormTest();
            ft.Show();
        }

        private void tabControlIDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFermerDossier.PerformClick();

            //gBoxCustResult.Visible = false;
        }

        private void formAjoutClient_FormClosed(object sender, EventArgs e)
        {
            btnAfficherTousClients_Click(sender, e);
            btnFermerDossier.PerformClick();
        }

        #endregion




        #region OngletClients
        //********************************** OngletClients **********************************
        #region ButtonsEvents
        /// <summary>
        /// Affiche le prenom et nom de tous les clients dans une liste
        /// </summary>
        private void btnAfficherTousClients_Click(object sender, EventArgs e)
        {
            btnFermerDossier.PerformClick();
            _afficherTousClients = true;
            _lstRechercheClient.Clear();
            listBoxResultat.Items.Clear();

            _lstRechercheClient.AddRange(Controller.Client.ObtenirTousLesClients());

            for (int i = 0; i < _lstRechercheClient.Count; i++)
                listBoxResultat.Items.Add(_lstRechercheClient[i].Prenom + " " + _lstRechercheClient[i].Nom);
        }

        /// <summary>
        /// Affiche le no, le type et le site de tous les espaces dans une liste
        /// </summary>
        private void btnAfficherEspaces_Click(object sender, EventArgs e)
        {
            _lstRechercheEspace.Clear();
            BaseDonnee.DataSetVilleTableAdapters.DisponibiliteEspace_ClientTableAdapter t = new BaseDonnee.DataSetVilleTableAdapters.DisponibiliteEspace_ClientTableAdapter();
            DataSetVille ds = new DataSetVille();

            dataGridView1.DataSource = t.GetDataByStationnement();
            //_lstRechercheEspace.AddRange(Controller.Espace.ObtenirTousEspaces());
            //listBoxResultat.Items.Clear();

            //for (int i = 0; i < _lstRechercheEspace.Count; i++)
            //{
            //    string typeLocal;
            //    string site;
            //    string disponible;
            //    string nomClient;

            //    if (Controller.TypeEspace.EstTypeLocal(_lstRechercheEspace[i].TypeEspaceId))
            //        typeLocal = "local";
            //    else
            //        typeLocal = "stationnement";

            //    site = Controller.Site.ObtenirSite(Controller.TypeEspace.ObtenirTypeEspace(_lstRechercheEspace[i].TypeEspaceId).SiteId).Alias;

            //    if (_lstRechercheEspace[i].Disponible)
            //    {

            //        disponible = "disponible";
            //        nomClient = "-";
            //    }
            //    else
            //    {
            //        disponible = "non disponible";

            //        Contrat contratLocation = Controller.Contrat.ContratActifParEspace(_lstRechercheEspace[i]);
            //        Client client = Controller.Client.RechercherClientParContrat(contratLocation.ContratId);

            //        nomClient = client.Prenom + " " + client.Nom;
            //    }

            //    listBoxResultat.Items.Add(site + " " + disponible + " " + nomClient + " " + typeLocal);

            //}
        }

        /// <summary>
        /// Supprime le client sélectionné dans la liste de résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            btnFermerDossier.PerformClick();
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
                        Controller.Client.SupprimerClient(_clientSelectionner);
                        _clientSelectionner = null;
                        if (_afficherTousClients)
                            btnAfficherTousClients_Click(sender, e);
                    }
                    else
                        return;
                }
                else return;
            }

            if (_afficherTousClients)
                btnAfficherTousClients.PerformClick();
        }

        /// <summary>
        /// Affiche la Form permettant de créer un nouveau contrat
        /// </summary>
        private void btnCreerContrat_Click(object sender, EventArgs e)
        {
            FormContrat f = new FormContrat(_clientSelectionner);
            f.Show();
        }

        /// <summary>
        /// Affiche la form permettant d'effectuer un paiement
        /// </summary>
        private void btnEffectuerPaiement_Click(object sender, EventArgs e)
        {
            FormPaiement fp = new FormPaiement(_clientSelectionner);
            fp.Show();
        }

        /// <summary>
        /// Affiche la form permettant d'ajouter un nouveau client
        /// </summary>
        private void buttonAjoutClient_Click(object sender, EventArgs e)
        {
            btnFermerDossier.PerformClick();

            AjoutClient formAjoutClient = new AjoutClient(false);
            formAjoutClient.AccessibleName = "INSERT";
            formAjoutClient.Show();
            formAjoutClient.FormClosed += new FormClosedEventHandler(formAjoutClient_FormClosed);

            //Control[] c = formAjoutClient.Controls[0].Controls.Find("btnAddNewCustomer", false);
            //c[0].Text = "Ajouter le client";
            //c[0].AccessibleName = "INSERT";

            if (_afficherTousClients)
                btnAfficherTousClients_Click(sender, e);
        }

        /// <summary>
        /// Affiche la forme permettant de modifier un client
        /// </summary>
        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            AjoutClient formModifClient = new AjoutClient(true);

            formModifClient.Show();
            formModifClient.AfficherDonneeClient(_clientSelectionner);
            formModifClient.ClientOrigine = _clientSelectionner;
            formModifClient.FormClosed += new FormClosedEventHandler(formAjoutClient_FormClosed);
        }

        /// <summary>
        /// Ferme de dossier du client
        /// </summary>
        private void btnFermerDossier_Click(object sender, EventArgs e)
        {
            FermerDossierClient();
        }

        /// <summary>
        /// Effectue une recherche de client selon les critères spécifiés par l'utilisateur
        /// </summary>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            _afficherTousClients = false;
            _lstRechercheClient.Clear();
            listBoxResultat.Items.Clear();

            if (rBtnCustSpecificSearchDoor.Checked)
            {

            }

            else if (rBtnCustSpecificSearchLastName.Checked)
            {
                _lstRechercheClient.AddRange(Controller.Client.RechercherClientNom(txtFindCustSpecificSearch.Text));
            }


            else if (rBtnCustSpecificSearchPhone.Checked)
            {
                _lstRechercheClient.AddRange(Controller.Client.RechercherClientTelephone(txtFindCustSpecificSearch.Text));
            }

            for (int i = 0; i < _lstRechercheClient.Count; i++)
                listBoxResultat.Items.Add(_lstRechercheClient[i].Prenom + " " + _lstRechercheClient[i].Nom);

            //gBoxCustResult.Visible = false;
        }
        #endregion

        #region ListBoxEvent

        private void listBoxResultat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (listBoxResultat.SelectedItem != null)
                    btnSupprimerClient.PerformClick();
        }

        private void listBoxResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFermerDossier.PerformClick();

            if (_dossierClient != null)
                FermerDossierClient();


            if (listBoxResultat.SelectedItems.Count == 1)
            {
                _clientSelectionner = _lstRechercheClient[listBoxResultat.SelectedIndex];
                OuvrirDossierClient(_clientSelectionner);


            }
        }

        #endregion

        /// <summary>
        /// Permet d'afficher les informations du client dans des labels
        /// </summary>
        /// <param name="client">client à affiché</param>
        private void OuvrirDossierClient(Client client)
        {
            btnModifierClient.Visible = true;
            btnModifierClient.Enabled = true;
            
            btnEffectuerPaiement.Visible = true;
            btnEffectuerPaiement.Enabled = true;

            btnVoirSoldeClient.Visible = true;
            btnVoirSoldeClient.Enabled = true;

            btnFermerDossier.Visible = true;
            btnFermerDossier.Enabled = true;

            btnCreerContrat.Visible = true;
            btnCreerContrat.Enabled = true;

            btnSupprimerClient.Visible = true;
            btnSupprimerClient.Enabled = true;

           // pnlSolde.Visible = true;

            this.PerformLayout();

            DossierClient ds = new DossierClient(client);
            _dossierClient = ds.ObtenirVueDossierClient();

            _dossierClient.Parent = groupBoxDossierClient;
            _dossierClient.Location = new Point(0, 0);
        }

        /// <summary>
        /// Retire les labels affichant les informations du client
        /// </summary>
        private void FermerDossierClient()
        {
            groupBoxDossierClient.Controls.Remove(_dossierClient);
            btnModifierClient.Visible = false;
            btnModifierClient.Enabled = false;

            btnEffectuerPaiement.Visible = false;
            btnEffectuerPaiement.Enabled = false;

            btnVoirSoldeClient.Visible = false;
            btnVoirSoldeClient.Enabled = false;

            btnFermerDossier.Visible = false;
            btnFermerDossier.Enabled = false;

            btnCreerContrat.Visible = false;
            btnCreerContrat.Enabled = false;

            btnSupprimerClient.Visible = false;
            btnSupprimerClient.Enabled = false;
        }

        //-------------------------------------------------------------------------------------
        #endregion





        #region OngletLocauxEtStationnements
        //********************************** OngletLocauxEtStationnements **********************************
        #region ButtonsEvents

        private void btnCreerSite_Click(object sender, EventArgs e)
        {
            if (_gbSectionAdmin != null)
                _gbSectionAdmin.Dispose();

            VueAjoutSite v = new VueAjoutSite();
            _gbSectionAdmin = v.ObtenirVue();
            _gbSectionAdmin.Location = new Point(202, 12);
            tabPageAdmin.Controls.Add(_gbSectionAdmin);
            //v.FillData();
        }

        private void buttonAjouterPorte_Click(object sender, EventArgs e)
        {
            FormAjoutEspace formAjoutPorte = new FormAjoutEspace();
            formAjoutPorte.Show();
        }

        #endregion

        //-------------------------------------------------------------------------------------
        #endregion





        #region OngletSectionAdministrateur
        //********************************** OngletSectionAdministrateur **********************************

        #region ButtonsEvents

        private void btnModifierTax_Click(object sender, EventArgs e)
        {
            if (_gbSectionAdmin != null)
                _gbSectionAdmin.Dispose();

            VueModifierTaxe v = new VueModifierTaxe();
            _gbSectionAdmin = v.ObtenirVue();
            _gbSectionAdmin.Location = new Point(202, 12);
            tabPageAdmin.Controls.Add(_gbSectionAdmin);
        }

        private void btnNewPayementMethod_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private void btnVoirSoldeClient_Click(object sender, EventArgs e)
        {
            FormSolde fs = new FormSolde(_clientSelectionner);
            fs.Show();
        }

        private void btnGestionEspace_Click(object sender, EventArgs e)
        {
            FormAjoutEspace f = new FormAjoutEspace();
            f.Show();
        }



        //-------------------------------------------------------------------------------------

        #endregion





    }
}
