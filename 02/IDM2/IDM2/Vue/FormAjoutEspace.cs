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
using IDM2.BaseDonnee;
using IDM2.Controleur;
using IDM2.Vue;

namespace IDM2
{
    public partial class FormAjoutEspace : Form
    {
        private bool _creerTypeEspace;
        private CoTypeEspace _controllerTypeEspace;
        private CoEspace _controllerEspace;
        private CoTaxe _controllerTaxe;
        private CoPaiement _controllerPaiement;
        private CoStationnement _controllerStationnement;
        private CoLocal _controllerLocal;
        private CoVue _controllerVue;
        private TypeEspace _typeEspaceSelectionner;
        private List<Espace> _listEspaceAfficher;

        private int _dernierEspaceIdAjouter;
        private int _dernierTypeEspaceIdAjouter;

        public FormAjoutEspace()
        {
            InitializeComponent();
            _creerTypeEspace = false;
            _controllerEspace = new CoEspace();
            _controllerTypeEspace = new CoTypeEspace();
            _controllerTaxe = new CoTaxe();
            _controllerPaiement = new CoPaiement();
            _controllerStationnement = new CoStationnement();
            _controllerLocal = new CoLocal();
            _controllerVue = new CoVue();

            _dernierEspaceIdAjouter = 0;
            _dernierTypeEspaceIdAjouter = 0;
            _typeEspaceSelectionner = null;
            _listEspaceAfficher = new List<Espace>();

            if (_controllerTypeEspace.ObtenirNombreTypeEspace() == 0)
                chkBoxCreerLocal.Visible = false;
        }


        private void AjoutPorte_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetVille.TypeEspace'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeEspaceTableAdapter.Fill(this.dataSetVille.TypeEspace);
            // TODO: cette ligne de code charge les données dans la table 'dataSetVille.Site'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.siteTableAdapter.Fill(this.dataSetVille.Site);
            // TODO: cette ligne de code charge les données dans la table 'dataSetIDM.Emplacement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.emplacementTableAdapter.Fill(this.dataSetIDM.Emplacement);
            // TODO: cette ligne de code charge les données dans la table 'dataSetIDM.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.clientTableAdapter.Fill(this.dataSetIDM.Client);

            if (cmbTypeEspace.Items.Count == 0)
            {
                txtNoLocal.Visible = false;
                chkBoxDisponible.Visible = false;
                lblNoLocal.Visible = false;
            }
            else
            {
                TypeEspace typeEspace = _controllerTypeEspace.ObtenirTypeEspace((int)cmbTypeEspace.SelectedValue);
                txtDescription.Text = typeEspace.Description;

            }

            txtTps.Text = (_controllerTaxe.ObtenirTpsPlusRecente().Taux * 100).ToString() + " %";
            txtTvq.Text = (_controllerTaxe.ObtenirTvqPlusRecente().Taux * 100).ToString() + " %";

            cmbTypeEspace_SelectedIndexChanged(sender, e);
        }



        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            if (chkBoxCreerTypeEspace.Checked)
            {
                _dernierTypeEspaceIdAjouter = _controllerTypeEspace.AjouterTypeEspace(ObtenirInfoTypeEspace()).TypeEspaceId;

                if (cmbTypeEspace.Items.Count != 0)
                {
                    cmbTypeEspace.SelectedItem = cmbTypeEspace.Items[cmbTypeEspace.Items.Count - 1];
                    txtNoLocal.Visible = true;
                    chkBoxDisponible.Visible = true;
                    lblNoLocal.Visible = true;
                }
            }
            Espace espace = new Espace();

            if (_controllerTypeEspace.ObtenirNombreTypeEspace() != 0)
                espace = _controllerEspace.AjouterEspace(ObtenirInfoEspace());

            _dernierEspaceIdAjouter = espace.EspaceId;

            DossierEspace ds = new DossierEspace();


            groupBoxInfoEspace.Controls.Clear();
            if (radioButtonLocal.Checked)
                groupBoxInfoEspace.Controls.Add(ds.ObtenirDossier(_controllerLocal.AjouterLocal(ObtenirInfoLocal())));
            else if (radioButtonStationnement.Checked)
                groupBoxInfoEspace.Controls.Add(ds.ObtenirDossier(_controllerStationnement.AjouterStationnement(ObtenirInfoStationnement())));

            //cmbTypeEspace.Update();
            this.typeEspaceTableAdapter.Fill(this.dataSetVille.TypeEspace);
        }

        private Local ObtenirInfoLocal()
        {
            Local local = new Local();
            local.NoLocal = txtNoLocal.Text;
            local.EspaceId = _dernierEspaceIdAjouter;

            return local;
        }

        private TypeEspace ObtenirInfoTypeEspace()
        {
            if (_typeEspaceSelectionner == null)
            {
                TypeEspace typeEspace = new TypeEspace();

                typeEspace.Description = txtDescription.Text;
                try
                {
                    typeEspace.Prix = Convert.ToDecimal(txtPrix.Text);
                    if (txtLargeur.Text != "" && txtLongueur.Text != "")
                    {
                        typeEspace.Largeur = Convert.ToInt32(txtLargeur.Text);
                        typeEspace.Longueur = Convert.ToInt32(txtLongueur.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                typeEspace.SiteId = (int)cmbSite.SelectedValue;

                return typeEspace;
            }
            else
                return _typeEspaceSelectionner;
        }

        private Espace ObtenirInfoEspace()
        {
            Espace espace = new Espace();

            espace.Disponible = true;

            if (!chkBoxCreerTypeEspace.Checked)
                espace.TypeEspaceId = (int)cmbTypeEspace.SelectedValue;
            else
                espace.TypeEspaceId = _dernierTypeEspaceIdAjouter;


            return espace;
        }

        private Stationnement ObtenirInfoStationnement()
        {
            Stationnement stationnement = new Stationnement();

            stationnement.EspaceId = _dernierEspaceIdAjouter;
            stationnement.NoStationnement = txtNoLocal.Text;

            return stationnement;
        }

        private void ChangerDescription()
        {
            string type = "";
            if (radioButtonStationnement.Checked)
                type = radioButtonStationnement.AccessibleDescription;
            else if (radioButtonLocal.Checked)
                type = radioButtonLocal.AccessibleDescription;

            if (radioButtonLocal.Checked)
                txtDescription.Text = type + "  \"" + txtLargeur.Text + "\"  " + " X " + "  \"" + txtLongueur.Text + "\" \r\n" + txtPrix.Text + "$";
            else if (radioButtonStationnement.Checked)
                txtDescription.Text = type + " \r\n" + txtPrix.Text + "$";


        }

        private void txtLargeur_TextChanged(object sender, EventArgs e)
        {
            ChangerDescription();
        }

        private void txtLonguer_TextChanged(object sender, EventArgs e)
        {
            ChangerDescription();
        }

        private void txtTypeEspace_TextChanged(object sender, EventArgs e)
        {
            ChangerDescription();
        }

        private void radioButtonLocal_CheckedChanged(object sender, EventArgs e)
        {
            ChangerDescription();
            txtLongueur.Enabled = true;
            txtLargeur.Enabled = true;
            lblNoLocal.Text = "Numéro du local";
        }

        private void radioButtonStationnement_CheckedChanged(object sender, EventArgs e)
        {
            ChangerDescription();
            txtLongueur.Enabled = false;
            txtLargeur.Enabled = false;
            lblNoLocal.Text = "Numéro du stationnement";
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            ChangerDescription();
            decimal montant = 0;
            try
            {
                montant = Convert.ToDecimal(txtPrix.Text);

                txtMontantAvTaxe.Text = _controllerPaiement.ObtenirMontantAvantTaxe(montant).ToString("0.00") + " $";
                txtMontantTps.Text = _controllerPaiement.ObtenirMontantTps(montant).ToString("0.00") + " $";
                txtMontantTvq.Text = _controllerPaiement.ObtenirMontantTvq(montant).ToString("0.00") + " $";
            }
            catch { }
        }

        private void cmbTypeEspace_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                _typeEspaceSelectionner = _controllerTypeEspace.ObtenirTypeEspace((int)cmbTypeEspace.SelectedValue);

                txtDescription.Text = _typeEspaceSelectionner.Description;
                txtPrix.Text = _typeEspaceSelectionner.Prix.ToString();

                if (_typeEspaceSelectionner.Description.Contains(radioButtonLocal.AccessibleDescription))
                    radioButtonLocal.Checked = true;
                else if (_typeEspaceSelectionner.Description.Contains(radioButtonStationnement.AccessibleDescription))
                    radioButtonStationnement.Checked = true;

            }
            catch { }

            AfficherListEspace();
        }

        private void AfficherListEspace()
        {
            listBoxLocal.Items.Clear();

            if (_controllerTypeEspace.ObtenirNombreTypeEspace() != 0 && cmbTypeEspace.Items.Count != 0)
            {
                _listEspaceAfficher.Clear();
                _listEspaceAfficher.AddRange(_controllerEspace.ObtenirEspaces(_typeEspaceSelectionner.TypeEspaceId));

                for (int i = 0; i < _listEspaceAfficher.Count; i++)
                    if (_listEspaceAfficher[i].Stationnement != null)
                        listBoxLocal.Items.Add(_controllerStationnement.ObtenirStationnement(_listEspaceAfficher[i].EspaceId).NoStationnement.ToString());
                    else if (_listEspaceAfficher[i].Local != null)
                        listBoxLocal.Items.Add(_controllerLocal.ObtenirLocal(_listEspaceAfficher[i].EspaceId).NoLocal.ToString());
            }
        }

        private void listBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DossierEspace ds = new DossierEspace();
            Espace espace = _listEspaceAfficher[listBoxLocal.SelectedIndex];

            if (espace.Stationnement != null)
            {
                Stationnement stationnement = _controllerStationnement.ObtenirStationnement(espace.EspaceId);
                groupBoxInfoEspace.Controls.Clear();
                groupBoxInfoEspace.Controls.Add(ds.ObtenirDossier(stationnement));
            }
            else if (espace.Local != null)
            {
                Local local = _controllerLocal.ObtenirLocal(espace.EspaceId);

                groupBoxInfoEspace.Controls.Clear();
                groupBoxInfoEspace.Controls.Add(ds.ObtenirDossier(local));
            }
        }

        private void btnCreerLocal_Click(object sender, EventArgs e)
        {
            groupBoxAjoutLocal.Visible = true;
        }

        private void chkBoxCreerLocal_CheckedChanged(object sender, EventArgs e)
        {

            if (chkBoxCreerLocal.Checked)
            {
                chkBoxCreerTypeEspace.Checked = false;
                groupBoxAjoutLocal.Location = gbCreationTypeEspace.Location;
                groupBoxAjoutLocal.Visible = true;
                if (cmbTypeEspace.Items.Count != 0)
                    cmbTypeEspace.SelectedIndex = 0;
            }
            else if (cmbTypeEspace.SelectedItem == null)
            {
                MessageBox.Show("Veuillez selectionner un type d'espace");
                chkBoxCreerLocal.Checked = false;
                return;
            }
            else
                groupBoxAjoutLocal.Visible = false;
        }



        private void chkBoxCreerTypeEspace_CheckedChanged(object sender, EventArgs e)
        {

            int i = cmbTypeEspace.Items.Count;
            if (chkBoxCreerTypeEspace.Checked)
            {
                chkBoxCreerLocal.Checked = false;
                gbCreationTypeEspace.Visible = true;
                _creerTypeEspace = true;
                radioButtonLocal.Enabled = true;
                radioButtonStationnement.Enabled = true;
                txtLargeur.Enabled = true;
                txtLongueur.Enabled = true;
                txtPrix.Enabled = true;
                txtDescription.Enabled = true;
                radioButtonLocal.Checked = true;
                cmbTypeEspace.Visible = false;
                cmbTypeEspace.SelectedItem = null;
                _typeEspaceSelectionner = null;
                lblTypeEspace.Visible = false;

                txtLargeur.Clear();
                txtLongueur.Clear();
                txtPrix.Clear();
                txtMontantAvTaxe.Clear();
                txtMontantTps.Clear();
                txtMontantTvq.Clear();
                txtDescription.Clear();
            }
            else
            {
                gbCreationTypeEspace.Visible = false;
                _creerTypeEspace = false;
                radioButtonLocal.Enabled = false;
                radioButtonStationnement.Enabled = false;
                txtLargeur.Enabled = false;
                txtLongueur.Enabled = false;
                txtPrix.Enabled = false;
                txtDescription.Enabled = false;
                cmbTypeEspace.Visible = true;
                lblTypeEspace.Visible = true;
            }
        }

        private void chkBoxDisponible_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxDisponible.Checked)
                chkBoxDisponible.BackColor = Color.LightGreen;
            else
                chkBoxDisponible.BackColor = Color.Salmon;

        }
    }
}
