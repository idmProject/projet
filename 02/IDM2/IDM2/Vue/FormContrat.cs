using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.Vue;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Vue
{
    public partial class FormContrat : Form
    {
        private Client _client;

        private DossierClient _dossierClient;
        private bool _siteSelectionner = false;
        private bool _typeEspaceSelectionner = false;
        private int _espaceIdSelectionner = 0;

        

        public FormContrat(Client client)
        {
            InitializeComponent();

            _client = client;
            _dossierClient = new DossierClient(_client);

            // Section Dossier Client
            GroupBox gb = _dossierClient.ObtenirVueDossierClient();
            gb.Location = new Point(0, 0);
            gb.Parent = this;
            gb.Visible = true;


            // Section Contrat
            txtDateCreation.Text = DateTime.Now.Day + " " + Tools.GetMonth(DateTime.Now.Month) + " " + DateTime.Now.Year;


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBoxDateSortie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxDateSortie.Checked)
                dateTimePickerDateSortie.Enabled = true;
            else
                dateTimePickerDateSortie.Enabled = false;
        }

        private void FormContrat_Load(object sender, EventArgs e)
        {
            this.siteTableAdapter.Fill(this.dataSetVille.Site);
            if (cmbSite.Items.Count != 0)
            {
                cmbSite.SelectedIndex = 0;
                _siteSelectionner = true;
                FillDataBySite();
                FillDataByTypeEspace();
            }
        }

        private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSite.SelectedItem != null)
            {
                FillDataBySite();
                _siteSelectionner = true;
            }
            else
                _siteSelectionner = false;
        }

        private void FillDataBySite()
        {
            if (cmbSite.SelectedValue != null && _siteSelectionner)
                this.typeEspaceTableAdapter.FillBySiteId(this.dataSetVille.TypeEspace, (int)cmbSite.SelectedValue);
        }

        private void FillDataByTypeEspace()
        {
            if (cmbTypeLocation.Items.Count == 0)
                return;

            if (cmbTypeLocation.SelectedItem == null)
                cmbTypeLocation.SelectedItem = cmbTypeLocation.Items[0];

            TypeEspace typeEspaceSelectionner = Controller.TypeEspace.ObtenirTypeEspace((int)cmbTypeLocation.SelectedValue);

            if (typeEspaceSelectionner.EstLocal)
            {
                cmbNoStationnement.Enabled = false;
                this.stationnementTableAdapter.FillByTypeEspaceId(this.dataSetVille.Stationnement, 0);
                cmbNoLocal.Enabled = true;
                if (cmbTypeLocation.SelectedItem != null)
                    this.localTableAdapter.FillByTypeEspaceId(this.dataSetVille.Local, (int)cmbTypeLocation.SelectedValue);
                AfficherDossierLocal();
            }
            else
            {
                cmbNoLocal.Enabled = false;
                this.localTableAdapter.FillByTypeEspaceId(this.dataSetVille.Local, 0);
                cmbNoStationnement.Enabled = true;
                if (cmbTypeLocation.SelectedItem != null)
                    this.stationnementTableAdapter.FillByTypeEspaceId(this.dataSetVille.Stationnement, (int)cmbTypeLocation.SelectedValue);
                AfficherDossierStationnement();
            }


        }

        private void cmbTypeLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeLocation.SelectedItem != null)
            {
                FillDataByTypeEspace();
                _typeEspaceSelectionner = true;
            }
            else _typeEspaceSelectionner = false;
        }



        private void AfficherDossierStationnement()
        {
            if (cmbTypeLocation.SelectedItem == null && !_typeEspaceSelectionner)
                return;

            if (Controller.TypeEspace.ObtenirTypeEspace((int)cmbTypeLocation.SelectedValue).EstLocal)
                return;

            if (this.Controls["Dossier"] != null)
                this.Controls.Remove(this.Controls["Dossier"]);

            if (cmbNoStationnement.SelectedItem != null)
            {
                Stationnement stationnement = Controller.Stationnement.ObtenirStationnement((int)cmbNoStationnement.SelectedValue);
                _espaceIdSelectionner = stationnement.EspaceId;

                txtPrixSuggerer.Text = Tools.FormatArgent((decimal)Controller.TypeEspace.ObtenirTypeEspace(stationnement.Espace.TypeEspaceId).Prix);

                DossierEspace ds = new DossierEspace();
                GroupBox gb = ds.ObtenirDossier(stationnement);

                gb.Location = new Point(gbCreationContrat.Location.X, gbCreationContrat.Location.Y + gbCreationContrat.Size.Height);
                gb.Name = "Dossier";
                this.Controls.Add(gb);
            }
        }


        private void AfficherDossierLocal()
        {
            if (cmbTypeLocation.SelectedItem == null && !_typeEspaceSelectionner)
                return;

            if (!Controller.TypeEspace.ObtenirTypeEspace((int)cmbTypeLocation.SelectedValue).EstLocal)
                return;

            if (this.Controls["Dossier"] != null)
                this.Controls.Remove(this.Controls["Dossier"]);

            if (cmbNoLocal.SelectedItem != null)
            {
                Local local = Controller.Local.ObtenirLocal((int)cmbNoLocal.SelectedValue);
                _espaceIdSelectionner = local.EspaceId;

                txtPrixSuggerer.Text = Tools.FormatArgent((decimal)Controller.TypeEspace.ObtenirTypeEspace(local.Espace.TypeEspaceId).Prix);

                DossierEspace ds = new DossierEspace();
                GroupBox gb = ds.ObtenirDossier(local);

                gb.Location = new Point(gbCreationContrat.Location.X, gbCreationContrat.Location.Y + gbCreationContrat.Size.Height);
                gb.Name = "Dossier";
                this.Controls.Add(gb);
            }
        }

        private void cmbNoStationnement_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDossierStationnement();
        }

        private void cmbNoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherDossierLocal();
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            Controller.Contrat.AjouterContrat(ObtenirInfoContrat());
        }

        private Contrat ObtenirInfoContrat()
        {
            Contrat contrat = new Contrat();

            contrat.ClientId = _client.ClientId;
            contrat.DateEntree = dateTimePickerDateEntree.Value;
            
            if (dateTimePickerDateSortie.Enabled)
                contrat.DateSortie = dateTimePickerDateSortie.Value;
            else 
                contrat.DateSortie = null;

            contrat.EspaceId = _espaceIdSelectionner;

            try
            {
                contrat.Prix = Convert.ToDecimal(txtPrix.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return contrat;
        }

        public void AfficherMessageLoyerFacultatif(int contratId)
        {

        }
    }
}
