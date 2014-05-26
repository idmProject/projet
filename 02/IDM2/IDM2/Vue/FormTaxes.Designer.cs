namespace IDM2.Vue
{
    partial class FormTaxes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTypeTaxe = new System.Windows.Forms.ComboBox();
            this.txtAncienTaux = new System.Windows.Forms.TextBox();
            this.txtNouvTaux = new System.Windows.Forms.TextBox();
            this.lblDateModification = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTauxActuel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(197, 226);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(75, 23);
            this.btnAppliquer.TabIndex = 8;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(116, 226);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(35, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormTaxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTauxActuel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDateModification);
            this.Controls.Add(this.txtNouvTaux);
            this.Controls.Add(this.txtAncienTaux);
            this.Controls.Add(this.cmbTypeTaxe);
            this.Name = "FormTaxes";
            this.Text = "FormTaxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTypeTaxe;
        private System.Windows.Forms.TextBox txtAncienTaux;
        private System.Windows.Forms.TextBox txtNouvTaux;
        private System.Windows.Forms.Label lblDateModification;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTauxActuel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOk;

    }
}