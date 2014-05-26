using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Vue
{
    public partial class FormTaxes : Form
    {
        private CoTaxe _controllerTaxe;
        private Taxe _tpsActuel;
        private Taxe _tvqActuel;
        private bool _modification;

        public FormTaxes()
        {
            InitializeComponent();

            _controllerTaxe = new CoTaxe();
            //_tpsActuel = _controllerTaxe.ObtenirTpsPlusRecente();
            //_tvqActuel = _controllerTaxe.ObtenirTvqPlusRecente();
            _tpsActuel = DonneeMemoire.Tps;
            _tvqActuel = DonneeMemoire.Tvq;
            _modification = false;

            btnAppliquer.Enabled = false;
            lblDateModification.Text = DateTime.Now.Day + " " + Tools.GetMonth(DateTime.Now.Month) + " " + DateTime.Now.Year;

            cmbTypeTaxe.SelectedIndex = 0;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void cmbTypeTaxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeTaxe.SelectedItem.ToString() == "TPS")
                txtAncienTaux.Text = _tpsActuel.Taux.ToString();
            else if (cmbTypeTaxe.SelectedItem.ToString() == "TVQ")
                txtAncienTaux.Text = _tvqActuel.Taux.ToString();
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            Taxe taxe = new Taxe();
            taxe.DateModification = DateTime.Now.Date;

            try
            {
                taxe.Taux = Convert.ToDouble(txtNouvTaux.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            taxe.Type = cmbTypeTaxe.SelectedItem.ToString();

            if (taxe.Type == "TPS")
                _tpsActuel = _controllerTaxe.AjouterTaxe(taxe);
            else if (taxe.Type == "TVQ")
                _tvqActuel = _controllerTaxe.AjouterTaxe(taxe);

            btnAppliquer.Enabled = false;
            _modification = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_modification)
            {
                DialogResult dg = MessageBox.Show("Voulez vous enregistrer les informations de la  " +
                                     cmbTypeTaxe.SelectedItem.ToString(), "Avertissement", MessageBoxButtons.YesNoCancel);

                if (dg == DialogResult.Cancel)
                    return;
                else if (dg == DialogResult.Yes)
                {
                    Taxe taxe = new Taxe();
                    taxe.DateModification = DateTime.Now.Date;

                    try
                    {
                        taxe.Taux = Convert.ToDouble(txtNouvTaux.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    taxe.Type = cmbTypeTaxe.SelectedItem.ToString();

                    if (taxe.Type == "TPS")
                        _tpsActuel = _controllerTaxe.AjouterTaxe(taxe);
                    else if (taxe.Type == "TVQ")
                        _tvqActuel = _controllerTaxe.AjouterTaxe(taxe);

                    this.Close();
                }

                else if (dg == DialogResult.No)
                    this.Close();

            }
            else
                this.Close();
        }

        private void txtNouvTaux_TextChanged(object sender, EventArgs e)
        {
            btnAppliquer.Enabled = true;
            _modification = true;
        }
    }
}
