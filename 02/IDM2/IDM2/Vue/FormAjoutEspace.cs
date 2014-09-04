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
        private TypeEspace _typeEspaceSelectionner;
        private List<Espace> _listEspaceAfficher;

        private int _dernierEspaceIdAjouter;
        private int _dernierTypeEspaceIdAjouter;

        public FormAjoutEspace()
        {
            InitializeComponent();

            _dernierEspaceIdAjouter = 0;
            _dernierTypeEspaceIdAjouter = 0;
            _typeEspaceSelectionner = null;
            _listEspaceAfficher = new List<Espace>();

            if (Controller.TypeEspace.ObtenirNombreTypeEspace() == 0)
                chkBoxCreerLocal.Visible = false;
        }

        private void TypeEspace_ValueChanged(object sender, EventArgs e)
        {
            btnTypeAppliquer.Enabled = true;
            ChangerDescription();
        }

        private void AjoutPorte_Load(object sender, EventArgs e)
        {
            this.siteTableAdapter.Fill(this.dataSetVille.Site);

            if (cmbSite.SelectedValue != null)
                FillDataBySite();

            if (cmbTypeEspace.Items.Count == 0)
            {
                txtNoLocal.Visible = false;
                chkBoxDisponible.Visible = false;
                lblNoLocal.Visible = false;
            }
            else
            {
                TypeEspace typeEspace = Controller.TypeEspace.ObtenirTypeEspace((int)cmbTypeEspace.SelectedValue);
                txtDescription.Text = typeEspace.Description;

            }

            txtTps.Text = (Controller.Taxe.ObtenirTpsPlusRecente().Taux * 100).ToString() + " %";
            txtTvq.Text = (Controller.Taxe.ObtenirTvqPlusRecente().Taux * 100).ToString() + " %";

            cmbTypeEspace_SelectedIndexChanged(sender, e);
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
                typeEspace.EstLocal = radioButtonLocal.Checked;

                return typeEspace;
            }
            else
                return _typeEspaceSelectionner;
        }

        private Espace ObtenirInfoEspace()
        {
            Espace espace = new Espace();

            espace.Disponible = chkBoxDisponible.Checked;

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

                txtMontantAvTaxe.Text = Controller.Paiement.ObtenirMontantAvantTaxe(montant).ToString("0.00") + " $";
                txtMontantTps.Text = Controller.Paiement.ObtenirMontantTps(montant).ToString("0.00") + " $";
                txtMontantTvq.Text = Controller.Paiement.ObtenirMontantTvq(montant).ToString("0.00") + " $";
            }
            catch { }
        }

        private void cmbTypeEspace_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherListEspace();
        }

        private void AfficherListEspace()
        {

            try
            {
                _typeEspaceSelectionner = Controller.TypeEspace.ObtenirTypeEspace((int)cmbTypeEspace.SelectedValue);

                txtDescription.Text = _typeEspaceSelectionner.Description;
                txtPrix.Text = _typeEspaceSelectionner.Prix.ToString();

                if (_typeEspaceSelectionner.Description.Contains(radioButtonLocal.AccessibleDescription))
                    radioButtonLocal.Checked = true;
                else if (_typeEspaceSelectionner.Description.Contains(radioButtonStationnement.AccessibleDescription))
                    radioButtonStationnement.Checked = true;

            }
            catch { }

            listBoxLocal.Items.Clear();

            if (Controller.TypeEspace.ObtenirNombreTypeEspace() != 0 && cmbTypeEspace.Items.Count != 0 && _typeEspaceSelectionner != null)
            {
                _listEspaceAfficher.Clear();
                _listEspaceAfficher.AddRange(Controller.Espace.ObtenirEspacesParType(_typeEspaceSelectionner.TypeEspaceId));

                for (int i = 0; i < _listEspaceAfficher.Count; i++)
                    if (_listEspaceAfficher[i].Stationnement != null)
                        listBoxLocal.Items.Add(Controller.Stationnement.ObtenirStationnement(_listEspaceAfficher[i].EspaceId).NoStationnement.ToString());
                    else if (_listEspaceAfficher[i].Local != null)
                        listBoxLocal.Items.Add(Controller.Local.ObtenirLocal(_listEspaceAfficher[i].EspaceId).NoLocal.ToString());
            }
        }

        private void listBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DossierEspace ds = new DossierEspace();
            Espace espace = _listEspaceAfficher[listBoxLocal.SelectedIndex];

            if (espace.Stationnement != null)
            {
                Stationnement stationnement = Controller.Stationnement.ObtenirStationnement(espace.EspaceId);
                groupBoxInfoEspace.Controls.Clear();
                groupBoxInfoEspace.Controls.Add(ds.ObtenirDossier(stationnement));
            }
            else if (espace.Local != null)
            {
                Local local = Controller.Local.ObtenirLocal(espace.EspaceId);

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
            if (cmbTypeEspace.SelectedItem == null && chkBoxCreerLocal.Checked)
            {
                MessageBox.Show("Veuillez selectionner un type d'espace");
                chkBoxCreerLocal.Checked = false;
                return;
            }

            if (chkBoxCreerLocal.Checked)
            {
            //    Vue.VueModifierTaxe v = new VueModifierTaxe();
            //    GroupBox g = v.ObtenirVue();
            //    g.Location = gbCreationTypeEspace.Location;
            //    groupBoxAjoutEspace.Controls.Add(g);

                chkBoxCreerTypeEspace.Checked = false;
                groupBoxAjoutLocal.Location = gbCreationTypeEspace.Location;
                groupBoxAjoutLocal.Visible = true;
                if (cmbTypeEspace.Items.Count != 0)
                    cmbTypeEspace.SelectedIndex = 0;
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

        private void cmbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataBySite();
            AfficherListEspace();
        }

        private void FillDataBySite()
        {
            if (cmbSite.SelectedValue != null)
                this.typeEspaceTableAdapter.FillBySiteId(this.dataSetVille.TypeEspace, (int)cmbSite.SelectedValue);
        }

        private void btnLocalAppliquer_Click(object sender, EventArgs e)
        {
            _dernierEspaceIdAjouter = Controller.Espace.AjouterEspace(ObtenirInfoEspace()).EspaceId;

            if (Controller.Espace.EstLocal(_dernierEspaceIdAjouter))
                Controller.Local.AjouterLocal(ObtenirInfoLocal());
            else
                Controller.Stationnement.AjouterStationnement(ObtenirInfoStationnement());

            btnLocalAppliquer.Enabled = false;
            AfficherListEspace();
        }

        private void btnTypeAppliquer_Click(object sender, EventArgs e)
        {
            Controller.TypeEspace.AjouterTypeEspace(ObtenirInfoTypeEspace());
            FillDataBySite();

            btnTypeAppliquer.Enabled = false;
            chkBoxCreerLocal.Visible = true;
        }

        private void btnTypeOk_Click(object sender, EventArgs e)
        {
            btnTypeAppliquer.PerformClick();
            btnTypeAnnuler.PerformClick();
        }

        private void btnTypeAnnuler_Click(object sender, EventArgs e)
        {
            gbCreationTypeEspace.Visible = false;
            chkBoxCreerTypeEspace.Checked = false;
        }

        private void btnLocalOk_Click(object sender, EventArgs e)
        {
            btnLocalAppliquer.PerformClick();
            btnLocalAnnuler.PerformClick();
        }

        private void btnLocalAnnuler_Click(object sender, EventArgs e)
        {
            groupBoxAjoutLocal.Visible = false;
            chkBoxCreerLocal.Checked = false;
        }

        private void txtNoLocal_TextChanged(object sender, EventArgs e)
        {
            btnLocalAppliquer.Enabled = true;
        }
    }
}
