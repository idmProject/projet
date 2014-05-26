using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.Controleur;
using IDM2.BaseDonnee;

namespace IDM2.Vue
{
    public partial class FormPaiement : Form
    {
        private Client _client;
        private CoPaiement _controllerPaiement;
        private CoTaxe _controllerTaxe;
        private bool _modification;

        public FormPaiement(Client client)
        {
            InitializeComponent();
            _client = client;
            lblClient.Text = client.Prenom + " " + client.Nom;
            _controllerPaiement = new CoPaiement();
            
            _controllerTaxe = new CoTaxe();
            txtTps.Text = (_controllerPaiement.TPS * 100).ToString() + " %";
            txtTvq.Text = (_controllerPaiement.TVQ * 100).ToString() + " %";

            _modification = false;
            btnAppliquer.Enabled = false;
        }

        private void txtMontantPaye_TextChanged(object sender, EventArgs e)
        {
            _modification = true;
            btnAppliquer.Enabled = true;

            if (txtMontantPaye.Text.Contains('.'))
            {
                int index = txtMontantPaye.Text.IndexOf('.');

                string p = "";

                for (int i = 0; i < txtMontantPaye.Text.Length; i++)
                {
                    if (i != index)
                        p += txtMontantPaye.Text[i];
                    else
                        p += ',';
                }

                txtMontantPaye.Text = p;
            }

            try
            {
                decimal montant = Convert.ToDecimal(txtMontantPaye.Text);
                txtMontantAvTaxe.Text = _controllerPaiement.ObtenirMontantAvantTaxe(montant).ToString("0.00") + " $";
                txtMontantTps.Text = _controllerPaiement.ObtenirMontantTps(montant).ToString("0.00") + " $";
                txtMontantTvq.Text = _controllerPaiement.ObtenirMontantTvq(montant).ToString("0.00") + " $";
            }
            catch { }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            if (_modification)
            {
                Paiement paiement = new Paiement();
                paiement.ClientId = _client.ClientId;
                try
                {
                    paiement.MontantPaye = Convert.ToDecimal(txtMontantPaye.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // à modifier!!!
                DateTime date = new DateTime(1995, 09, 15);
                paiement.DatePaiement = date;
                //  paiement.Taxe.Add(_controllerTaxe.ObtenirTpsPlusRecente());
                // paiement.Taxe.Add(_controllerTaxe.ObtenirTvqPlusRecente());

                _controllerPaiement.AjouterPaiement(paiement);
            }

            btnAppliquer.Enabled = false;
            _modification = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_modification)
            {
                DialogResult dg = MessageBox.Show("Voulez vous enregistrer les informations du paiement de  " +
                     _client.Prenom + " " + _client.Nom, "Avertissement", MessageBoxButtons.YesNoCancel);

                if (dg == DialogResult.Cancel)
                    return;
                else if (dg == DialogResult.Yes)
                {
                    Paiement paiement = new Paiement();
                    paiement.ClientId = _client.ClientId;
                    try
                    {
                        paiement.MontantPaye = Convert.ToDecimal(txtMontantPaye.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    // à modifier!!!
                    DateTime date = new DateTime(1995, 09, 15);
                    paiement.DatePaiement = date;
                    //  paiement.Taxe.Add(_controllerTaxe.ObtenirTpsPlusRecente());
                    // paiement.Taxe.Add(_controllerTaxe.ObtenirTvqPlusRecente());

                    _controllerPaiement.AjouterPaiement(paiement);

                    this.Close();
                }

                else if (dg == DialogResult.No)
                    this.Close();
            }
            else
                this.Close();
        }
    }
}
