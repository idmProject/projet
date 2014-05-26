namespace IDM2.Vue
{
    partial class FormPaiement
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
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.txtMontantPaye = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.cmbMethodePaiement = new System.Windows.Forms.ComboBox();
            this.lblMethodePaiement = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTps = new System.Windows.Forms.TextBox();
            this.txtTvq = new System.Windows.Forms.TextBox();
            this.lblTps = new System.Windows.Forms.Label();
            this.lblTvq = new System.Windows.Forms.Label();
            this.txtMontantAvTaxe = new System.Windows.Forms.TextBox();
            this.lblMontantAvTaxe = new System.Windows.Forms.Label();
            this.txtMontantTps = new System.Windows.Forms.TextBox();
            this.txtMontantTvq = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(15, 256);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(193, 80);
            this.txtCommentaire.TabIndex = 0;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(214, 259);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(68, 13);
            this.lblCommentaire.TabIndex = 1;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // txtMontantPaye
            // 
            this.txtMontantPaye.Location = new System.Drawing.Point(15, 124);
            this.txtMontantPaye.Name = "txtMontantPaye";
            this.txtMontantPaye.Size = new System.Drawing.Size(159, 20);
            this.txtMontantPaye.TabIndex = 2;
            this.txtMontantPaye.TextChanged += new System.EventHandler(this.txtMontantPaye_TextChanged);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(180, 127);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(72, 13);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant payé";
            // 
            // cmbMethodePaiement
            // 
            this.cmbMethodePaiement.FormattingEnabled = true;
            this.cmbMethodePaiement.Location = new System.Drawing.Point(15, 83);
            this.cmbMethodePaiement.Name = "cmbMethodePaiement";
            this.cmbMethodePaiement.Size = new System.Drawing.Size(158, 21);
            this.cmbMethodePaiement.TabIndex = 4;
            // 
            // lblMethodePaiement
            // 
            this.lblMethodePaiement.AutoSize = true;
            this.lblMethodePaiement.Location = new System.Drawing.Point(179, 86);
            this.lblMethodePaiement.Name = "lblMethodePaiement";
            this.lblMethodePaiement.Size = new System.Drawing.Size(110, 13);
            this.lblMethodePaiement.TabIndex = 5;
            this.lblMethodePaiement.Text = "Méthode de paiement";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(12, 13);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(51, 18);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "Client";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(12, 40);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(49, 18);
            this.lblLocal.TabIndex = 7;
            this.lblLocal.Text = "Local";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(174, 351);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTps
            // 
            this.txtTps.Enabled = false;
            this.txtTps.Location = new System.Drawing.Point(15, 179);
            this.txtTps.Name = "txtTps";
            this.txtTps.Size = new System.Drawing.Size(46, 20);
            this.txtTps.TabIndex = 9;
            // 
            // txtTvq
            // 
            this.txtTvq.Enabled = false;
            this.txtTvq.Location = new System.Drawing.Point(15, 204);
            this.txtTvq.Name = "txtTvq";
            this.txtTvq.Size = new System.Drawing.Size(46, 20);
            this.txtTvq.TabIndex = 10;
            // 
            // lblTps
            // 
            this.lblTps.AutoSize = true;
            this.lblTps.Location = new System.Drawing.Point(67, 182);
            this.lblTps.Name = "lblTps";
            this.lblTps.Size = new System.Drawing.Size(28, 13);
            this.lblTps.TabIndex = 11;
            this.lblTps.Text = "TPS";
            // 
            // lblTvq
            // 
            this.lblTvq.AutoSize = true;
            this.lblTvq.Location = new System.Drawing.Point(67, 207);
            this.lblTvq.Name = "lblTvq";
            this.lblTvq.Size = new System.Drawing.Size(29, 13);
            this.lblTvq.TabIndex = 12;
            this.lblTvq.Text = "TVQ";
            // 
            // txtMontantAvTaxe
            // 
            this.txtMontantAvTaxe.Enabled = false;
            this.txtMontantAvTaxe.Location = new System.Drawing.Point(15, 153);
            this.txtMontantAvTaxe.Name = "txtMontantAvTaxe";
            this.txtMontantAvTaxe.Size = new System.Drawing.Size(158, 20);
            this.txtMontantAvTaxe.TabIndex = 13;
            // 
            // lblMontantAvTaxe
            // 
            this.lblMontantAvTaxe.AutoSize = true;
            this.lblMontantAvTaxe.Location = new System.Drawing.Point(179, 156);
            this.lblMontantAvTaxe.Name = "lblMontantAvTaxe";
            this.lblMontantAvTaxe.Size = new System.Drawing.Size(99, 13);
            this.lblMontantAvTaxe.TabIndex = 14;
            this.lblMontantAvTaxe.Text = "Montant avant taxe";
            // 
            // txtMontantTps
            // 
            this.txtMontantTps.Enabled = false;
            this.txtMontantTps.Location = new System.Drawing.Point(101, 179);
            this.txtMontantTps.Name = "txtMontantTps";
            this.txtMontantTps.Size = new System.Drawing.Size(72, 20);
            this.txtMontantTps.TabIndex = 15;
            // 
            // txtMontantTvq
            // 
            this.txtMontantTvq.Enabled = false;
            this.txtMontantTvq.Location = new System.Drawing.Point(101, 204);
            this.txtMontantTvq.Name = "txtMontantTvq";
            this.txtMontantTvq.Size = new System.Drawing.Size(72, 20);
            this.txtMontantTvq.TabIndex = 16;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(255, 351);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(336, 351);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(75, 23);
            this.btnAppliquer.TabIndex = 18;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // FormPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 386);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtMontantTvq);
            this.Controls.Add(this.txtMontantTps);
            this.Controls.Add(this.lblMontantAvTaxe);
            this.Controls.Add(this.txtMontantAvTaxe);
            this.Controls.Add(this.lblTvq);
            this.Controls.Add(this.lblTps);
            this.Controls.Add(this.txtTvq);
            this.Controls.Add(this.txtTps);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblMethodePaiement);
            this.Controls.Add(this.cmbMethodePaiement);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtMontantPaye);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.txtCommentaire);
            this.Name = "FormPaiement";
            this.Text = "FormPaiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.TextBox txtMontantPaye;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.ComboBox cmbMethodePaiement;
        private System.Windows.Forms.Label lblMethodePaiement;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtTps;
        private System.Windows.Forms.TextBox txtTvq;
        private System.Windows.Forms.Label lblTps;
        private System.Windows.Forms.Label lblTvq;
        private System.Windows.Forms.TextBox txtMontantAvTaxe;
        private System.Windows.Forms.Label lblMontantAvTaxe;
        private System.Windows.Forms.TextBox txtMontantTps;
        private System.Windows.Forms.TextBox txtMontantTvq;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAppliquer;
    }
}