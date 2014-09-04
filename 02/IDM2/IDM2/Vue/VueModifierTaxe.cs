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
    public class VueModifierTaxe: VueSectionAdminAbstrait
    {
        private System.Windows.Forms.ComboBox cmbTypeTaxe;
        private System.Windows.Forms.TextBox txtAncienTaux;
        private System.Windows.Forms.TextBox txtNouvTaux;
        private System.Windows.Forms.Label lblDateModification;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTauxActuel;
        private System.Windows.Forms.Label label4;

        public VueModifierTaxe(): base()
        {
            InitializeComponent();
        }


        private void cmbTypeTaxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeTaxe.SelectedItem.ToString() == "TPS")
                txtAncienTaux.Text = _tpsActuel.Taux.ToString();
            else if (cmbTypeTaxe.SelectedItem.ToString() == "TVQ")
                txtAncienTaux.Text = _tvqActuel.Taux.ToString();

            txtNouvTaux.Clear();
        }

        protected override void btnAppliquer_Click(object sender, EventArgs e)
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
            {
                _tpsActuel = Controller.Taxe.AjouterTaxe(taxe);
                txtAncienTaux.Text = _tpsActuel.Taux.ToString();
            }
            else if (taxe.Type == "TVQ")
            {
                _tvqActuel = Controller.Taxe.AjouterTaxe(taxe);
                txtAncienTaux.Text = _tvqActuel.Taux.ToString();
            }

            _gbVue.Controls[BTN_APPLIQUER_NAME].Enabled = false;
            _modification = false;
        }

        protected void txtNouvTaux_TextChanged(object sender, EventArgs e)
        {
            btnAppliquer.Enabled = true;
            _modification = true;
        }

        protected override void InitializeComponent()
        {
            base.InitializeComponent();
            

            this.cmbTypeTaxe = new System.Windows.Forms.ComboBox();
            this.txtAncienTaux = new System.Windows.Forms.TextBox();
            this.txtNouvTaux = new System.Windows.Forms.TextBox();
            this.lblDateModification = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTauxActuel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            // 
            // cmbTypeTaxe
            // 
            this.cmbTypeTaxe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeTaxe.FormattingEnabled = true;
            this.cmbTypeTaxe.Items.AddRange(new object[] {
            "TPS",
            "TVQ"});
            this.cmbTypeTaxe.Location = new System.Drawing.Point(82, 80);
            this.cmbTypeTaxe.Name = "cmbTypeTaxe";
            this.cmbTypeTaxe.Size = new System.Drawing.Size(53, 21);
            this.cmbTypeTaxe.TabIndex = 1;
            this.cmbTypeTaxe.SelectedIndexChanged += new System.EventHandler(this.cmbTypeTaxe_SelectedIndexChanged);
            this.cmbTypeTaxe.SelectedIndex = 0;
            // 
            // txtAncienTaux
            // 
            this.txtAncienTaux.Enabled = false;
            this.txtAncienTaux.Location = new System.Drawing.Point(82, 107);
            this.txtAncienTaux.Name = "txtAncienTaux";
            this.txtAncienTaux.Size = new System.Drawing.Size(53, 20);
            this.txtAncienTaux.TabIndex = 2;
            // 
            // txtNouvTaux
            // 
            this.txtNouvTaux.Location = new System.Drawing.Point(82, 133);
            this.txtNouvTaux.Name = "txtNouvTaux";
            this.txtNouvTaux.Size = new System.Drawing.Size(53, 20);
            this.txtNouvTaux.TabIndex = 3;
            this.txtNouvTaux.TextChanged += new System.EventHandler(this.txtNouvTaux_TextChanged);
            // 
            // lblDateModification
            // 
            this.lblDateModification.AutoSize = true;
            this.lblDateModification.Location = new System.Drawing.Point(79, 54);
            this.lblDateModification.Name = "lblDateModification";
            this.lblDateModification.Size = new System.Drawing.Size(30, 13);
            this.lblDateModification.TabIndex = 4;
            this.lblDateModification.Text = "Date";
            this.lblDateModification.Text = DateTime.Now.Day + " " + Tools.GetMonth(DateTime.Now.Month) + " " + DateTime.Now.Year;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(141, 83);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type de taxe";
            // 
            // lblTauxActuel
            // 
            this.lblTauxActuel.AutoSize = true;
            this.lblTauxActuel.Location = new System.Drawing.Point(141, 110);
            this.lblTauxActuel.Name = "lblTauxActuel";
            this.lblTauxActuel.Size = new System.Drawing.Size(63, 13);
            this.lblTauxActuel.TabIndex = 6;
            this.lblTauxActuel.Text = "Taux actuel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nouveau Taux";

            _gbVue.Controls.Add(cmbTypeTaxe);
            _gbVue.Controls.Add(txtAncienTaux);
            _gbVue.Controls.Add(txtNouvTaux);
            _gbVue.Controls.Add(lblTauxActuel);
            _gbVue.Controls.Add(lblDateModification);
            _gbVue.Controls.Add(lblType);
            _gbVue.Controls.Add(label4);

        }


    }
    
}
