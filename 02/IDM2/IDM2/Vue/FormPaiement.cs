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
        private Test _test;
        private Client _client;
        private bool _modification;

        public FormPaiement(Client client)
        {
            InitializeComponent();
            _test = new Test();
            _client = client;
            lblClient.Text = client.Prenom + " " + client.Nom;
            lblMontantDue.Text += " " + Tools.FormatArgent(Controller.Loyer.MontantTotalDue(client));
            txtTps.Text = (Controller.Paiement.TPS * 100).ToString() + " %";
            txtTvq.Text = (Controller.Paiement.TVQ * 100).ToString() + " %";
            dateTimePickerDatePaiement.Value = _test.Date;

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
                txtMontantAvTaxe.Text = Controller.Paiement.ObtenirMontantAvantTaxe(montant).ToString("0.00") + " $";
                txtMontantTps.Text = Controller.Paiement.ObtenirMontantTps(montant).ToString("0.00") + " $";
                txtMontantTvq.Text = Controller.Paiement.ObtenirMontantTvq(montant).ToString("0.00") + " $";
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

                paiement.DatePaiement = dateTimePickerDatePaiement.Value;
                paiement.Commentaire = txtCommentaire.Text;

                Controller.Paiement.EffectuerPaiement(paiement);
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

                    Controller.Paiement.EffectuerPaiement(paiement);

                    this.Close();
                }

                else if (dg == DialogResult.No)
                    this.Close();
            }
            else
                this.Close();
        }

        private void chkModifierDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModifierDate.Checked)
                dateTimePickerDatePaiement.Enabled = true;
            else
                dateTimePickerDatePaiement.Enabled = false;
        }
    }
}
