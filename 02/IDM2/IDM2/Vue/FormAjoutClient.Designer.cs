namespace IDM2
{
    partial class AjoutClient
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxAjoutClient = new System.Windows.Forms.GroupBox();
            this.chkBoxCodePorte = new System.Windows.Forms.CheckBox();
            this.chkBoxCodeBarriere = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dateTimePickerEntree = new System.Windows.Forms.DateTimePicker();
            this.lblNewCustVille = new System.Windows.Forms.Label();
            this.cmbVille = new System.Windows.Forms.ComboBox();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVille = new IDM2.BaseDonnee.DataSetVille();
            this.villeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbTelephone = new System.Windows.Forms.GroupBox();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnPlusTel = new System.Windows.Forms.Button();
            this.txtAdresse = new System.Windows.Forms.RichTextBox();
            this.lblNewCustPayementMethod = new System.Windows.Forms.Label();
            this.cmdMethodePaiement = new System.Windows.Forms.ComboBox();
            this.methodePaiementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIDM = new IDM2.DataSetIDM();
            this.txtCodePorte = new System.Windows.Forms.TextBox();
            this.lblNewCustComments = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.RichTextBox();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.chkBoxActif = new System.Windows.Forms.CheckBox();
            this.lblNewCustEffectDate = new System.Windows.Forms.Label();
            this.lblNewCustAddress = new System.Windows.Forms.Label();
            this.lblNewCustLastName = new System.Windows.Forms.Label();
            this.lblNewCustFirstName = new System.Windows.Forms.Label();
            this.txtCodeBarriere = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.porteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodePaiementTableAdapter = new IDM2.DataSetIDMTableAdapters.MethodePaiementTableAdapter();
            this.porteTableAdapter = new IDM2.DataSetIDMTableAdapters.PorteTableAdapter();
            this.villeTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter();
            this.groupBoxAjoutClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource1)).BeginInit();
            this.gbTelephone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.methodePaiementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAjoutClient
            // 
            this.groupBoxAjoutClient.Controls.Add(this.chkBoxCodePorte);
            this.groupBoxAjoutClient.Controls.Add(this.chkBoxCodeBarriere);
            this.groupBoxAjoutClient.Controls.Add(this.btnOk);
            this.groupBoxAjoutClient.Controls.Add(this.btnAnnuler);
            this.groupBoxAjoutClient.Controls.Add(this.dateTimePickerEntree);
            this.groupBoxAjoutClient.Controls.Add(this.lblNewCustVille);
            this.groupBoxAjoutClient.Controls.Add(this.cmbVille);
            this.groupBoxAjoutClient.Controls.Add(this.gbTelephone);
            this.groupBoxAjoutClient.Controls.Add(this.txtAdresse);
            this.groupBoxAjoutClient.Controls.Add(this.lblNewCustPayementMethod);
            this.groupBoxAjoutClient.Controls.Add(this.cmdMethodePaiement);
            this.groupBoxAjoutClient.Controls.Add(this.txtCodePorte);
            this.groupBoxAjoutClient.Controls.Add(this.lblNewCustComments);
            this.groupBoxAjoutClient.Controls.Add(this.txtCommentaire);
            this.groupBoxAjoutClient.Controls.Add(this.btnAppliquer);
            this.groupBoxAjoutClient.Controls.Add(this.chkBoxActif);
            this.groupBoxAjoutClient.Controls.Add(this.lblNewCustEffectDate);
            this.groupBoxAjoutClient.Controls.Add(this.lblNewCustAddress);
            this.groupBoxAjoutClient.Controls.Add(this.lblNewCustLastName);
            this.groupBoxAjoutClient.Controls.Add(this.lblNewCustFirstName);
            this.groupBoxAjoutClient.Controls.Add(this.txtCodeBarriere);
            this.groupBoxAjoutClient.Controls.Add(this.txtNom);
            this.groupBoxAjoutClient.Controls.Add(this.txtPrenom);
            this.groupBoxAjoutClient.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAjoutClient.Name = "groupBoxAjoutClient";
            this.groupBoxAjoutClient.Size = new System.Drawing.Size(979, 490);
            this.groupBoxAjoutClient.TabIndex = 4;
            this.groupBoxAjoutClient.TabStop = false;
            // 
            // chkBoxCodePorte
            // 
            this.chkBoxCodePorte.AutoSize = true;
            this.chkBoxCodePorte.Location = new System.Drawing.Point(266, 263);
            this.chkBoxCodePorte.Name = "chkBoxCodePorte";
            this.chkBoxCodePorte.Size = new System.Drawing.Size(94, 17);
            this.chkBoxCodePorte.TabIndex = 7;
            this.chkBoxCodePorte.Text = "Code de Porte";
            this.chkBoxCodePorte.UseVisualStyleBackColor = true;
            this.chkBoxCodePorte.CheckedChanged += new System.EventHandler(this.chkBoxCodePorte_CheckedChanged);
            // 
            // chkBoxCodeBarriere
            // 
            this.chkBoxCodeBarriere.AutoSize = true;
            this.chkBoxCodeBarriere.Location = new System.Drawing.Point(266, 237);
            this.chkBoxCodeBarriere.Name = "chkBoxCodeBarriere";
            this.chkBoxCodeBarriere.Size = new System.Drawing.Size(105, 17);
            this.chkBoxCodeBarriere.TabIndex = 5;
            this.chkBoxCodeBarriere.Text = "Code de Barriere";
            this.chkBoxCodeBarriere.UseVisualStyleBackColor = true;
            this.chkBoxCodeBarriere.CheckedChanged += new System.EventHandler(this.chkBoxCodeBarriere_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(701, 457);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 23);
            this.btnOk.TabIndex = 48;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(792, 457);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(85, 23);
            this.btnAnnuler.TabIndex = 49;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dateTimePickerEntree
            // 
            this.dateTimePickerEntree.Location = new System.Drawing.Point(47, 303);
            this.dateTimePickerEntree.Name = "dateTimePickerEntree";
            this.dateTimePickerEntree.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEntree.TabIndex = 9;
            // 
            // lblNewCustVille
            // 
            this.lblNewCustVille.AutoSize = true;
            this.lblNewCustVille.Location = new System.Drawing.Point(263, 151);
            this.lblNewCustVille.Name = "lblNewCustVille";
            this.lblNewCustVille.Size = new System.Drawing.Size(26, 13);
            this.lblNewCustVille.TabIndex = 45;
            this.lblNewCustVille.Text = "Ville";
            // 
            // cmbVille
            // 
            this.cmbVille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.villeBindingSource, "Ville", true));
            this.cmbVille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.villeBindingSource, "VilleId", true));
            this.cmbVille.DataSource = this.villeBindingSource1;
            this.cmbVille.DisplayMember = "Ville";
            this.cmbVille.FormattingEnabled = true;
            this.cmbVille.Location = new System.Drawing.Point(82, 148);
            this.cmbVille.Name = "cmbVille";
            this.cmbVille.Size = new System.Drawing.Size(165, 21);
            this.cmbVille.TabIndex = 3;
            this.cmbVille.ValueMember = "VilleId";
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "Ville";
            this.villeBindingSource.DataSource = this.dataSetVilleBindingSource;
            // 
            // dataSetVilleBindingSource
            // 
            this.dataSetVilleBindingSource.DataSource = this.dataSetVille;
            this.dataSetVilleBindingSource.Position = 0;
            // 
            // dataSetVille
            // 
            this.dataSetVille.DataSetName = "DataSetVille";
            this.dataSetVille.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villeBindingSource1
            // 
            this.villeBindingSource1.DataMember = "Ville";
            this.villeBindingSource1.DataSource = this.dataSetVilleBindingSource;
            // 
            // gbTelephone
            // 
            this.gbTelephone.Controls.Add(this.btnMoins);
            this.gbTelephone.Controls.Add(this.btnPlusTel);
            this.gbTelephone.Location = new System.Drawing.Point(408, 35);
            this.gbTelephone.Name = "gbTelephone";
            this.gbTelephone.Size = new System.Drawing.Size(565, 78);
            this.gbTelephone.TabIndex = 43;
            this.gbTelephone.TabStop = false;
            // 
            // btnMoins
            // 
            this.btnMoins.Location = new System.Drawing.Point(451, 18);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(108, 23);
            this.btnMoins.TabIndex = 43;
            this.btnMoins.Text = "Moins...";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnPlusTel
            // 
            this.btnPlusTel.Location = new System.Drawing.Point(451, 44);
            this.btnPlusTel.Name = "btnPlusTel";
            this.btnPlusTel.Size = new System.Drawing.Size(108, 23);
            this.btnPlusTel.TabIndex = 42;
            this.btnPlusTel.Text = "Plus...";
            this.btnPlusTel.UseVisualStyleBackColor = true;
            this.btnPlusTel.Click += new System.EventHandler(this.btnPlusTel_Click);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(82, 89);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(165, 53);
            this.txtAdresse.TabIndex = 2;
            this.txtAdresse.Text = "";
            // 
            // lblNewCustPayementMethod
            // 
            this.lblNewCustPayementMethod.AutoSize = true;
            this.lblNewCustPayementMethod.Location = new System.Drawing.Point(263, 193);
            this.lblNewCustPayementMethod.Name = "lblNewCustPayementMethod";
            this.lblNewCustPayementMethod.Size = new System.Drawing.Size(110, 13);
            this.lblNewCustPayementMethod.TabIndex = 31;
            this.lblNewCustPayementMethod.Text = "Methode de paiement";
            // 
            // cmdMethodePaiement
            // 
            this.cmdMethodePaiement.DataSource = this.methodePaiementBindingSource;
            this.cmdMethodePaiement.DisplayMember = "MethodePaiement";
            this.cmdMethodePaiement.FormattingEnabled = true;
            this.cmdMethodePaiement.Location = new System.Drawing.Point(82, 190);
            this.cmdMethodePaiement.Name = "cmdMethodePaiement";
            this.cmdMethodePaiement.Size = new System.Drawing.Size(165, 21);
            this.cmdMethodePaiement.TabIndex = 4;
            this.cmdMethodePaiement.ValueMember = "MethodePaiement";
            // 
            // methodePaiementBindingSource
            // 
            this.methodePaiementBindingSource.DataMember = "MethodePaiement";
            this.methodePaiementBindingSource.DataSource = this.dataSetIDM;
            // 
            // dataSetIDM
            // 
            this.dataSetIDM.DataSetName = "DataSetIDM";
            this.dataSetIDM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodePorte
            // 
            this.txtCodePorte.AccessibleName = "CodePorte";
            this.txtCodePorte.Enabled = false;
            this.txtCodePorte.Location = new System.Drawing.Point(160, 261);
            this.txtCodePorte.Name = "txtCodePorte";
            this.txtCodePorte.Size = new System.Drawing.Size(87, 20);
            this.txtCodePorte.TabIndex = 8;
            // 
            // lblNewCustComments
            // 
            this.lblNewCustComments.AutoSize = true;
            this.lblNewCustComments.Location = new System.Drawing.Point(266, 348);
            this.lblNewCustComments.Name = "lblNewCustComments";
            this.lblNewCustComments.Size = new System.Drawing.Size(73, 13);
            this.lblNewCustComments.TabIndex = 25;
            this.lblNewCustComments.Text = "Commentaires";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.AccessibleName = "Commentaire";
            this.txtCommentaire.Location = new System.Drawing.Point(20, 348);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(227, 107);
            this.txtCommentaire.TabIndex = 10;
            this.txtCommentaire.Text = "";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(883, 457);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(85, 23);
            this.btnAppliquer.TabIndex = 50;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // chkBoxActif
            // 
            this.chkBoxActif.AccessibleName = "Actif";
            this.chkBoxActif.AutoSize = true;
            this.chkBoxActif.BackColor = System.Drawing.Color.PaleGreen;
            this.chkBoxActif.Location = new System.Drawing.Point(172, 461);
            this.chkBoxActif.Name = "chkBoxActif";
            this.chkBoxActif.Size = new System.Drawing.Size(75, 17);
            this.chkBoxActif.TabIndex = 11;
            this.chkBoxActif.Text = "Client actif";
            this.chkBoxActif.UseVisualStyleBackColor = false;
            this.chkBoxActif.CheckedChanged += new System.EventHandler(this.chkBoxActif_CheckedChanged);
            // 
            // lblNewCustEffectDate
            // 
            this.lblNewCustEffectDate.AutoSize = true;
            this.lblNewCustEffectDate.Location = new System.Drawing.Point(266, 309);
            this.lblNewCustEffectDate.Name = "lblNewCustEffectDate";
            this.lblNewCustEffectDate.Size = new System.Drawing.Size(71, 13);
            this.lblNewCustEffectDate.TabIndex = 15;
            this.lblNewCustEffectDate.Text = "Date d\'entree";
            // 
            // lblNewCustAddress
            // 
            this.lblNewCustAddress.AutoSize = true;
            this.lblNewCustAddress.Location = new System.Drawing.Point(263, 89);
            this.lblNewCustAddress.Name = "lblNewCustAddress";
            this.lblNewCustAddress.Size = new System.Drawing.Size(45, 13);
            this.lblNewCustAddress.TabIndex = 10;
            this.lblNewCustAddress.Text = "Adresse";
            // 
            // lblNewCustLastName
            // 
            this.lblNewCustLastName.AutoSize = true;
            this.lblNewCustLastName.Location = new System.Drawing.Point(263, 63);
            this.lblNewCustLastName.Name = "lblNewCustLastName";
            this.lblNewCustLastName.Size = new System.Drawing.Size(29, 13);
            this.lblNewCustLastName.TabIndex = 9;
            this.lblNewCustLastName.Text = "Nom";
            // 
            // lblNewCustFirstName
            // 
            this.lblNewCustFirstName.AutoSize = true;
            this.lblNewCustFirstName.Location = new System.Drawing.Point(263, 37);
            this.lblNewCustFirstName.Name = "lblNewCustFirstName";
            this.lblNewCustFirstName.Size = new System.Drawing.Size(43, 13);
            this.lblNewCustFirstName.TabIndex = 8;
            this.lblNewCustFirstName.Text = "Prenom";
            // 
            // txtCodeBarriere
            // 
            this.txtCodeBarriere.AccessibleName = "CodeBarriere";
            this.txtCodeBarriere.Enabled = false;
            this.txtCodeBarriere.Location = new System.Drawing.Point(160, 235);
            this.txtCodeBarriere.Name = "txtCodeBarriere";
            this.txtCodeBarriere.Size = new System.Drawing.Size(87, 20);
            this.txtCodeBarriere.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.AccessibleName = "Nom";
            this.txtNom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNom.Location = new System.Drawing.Point(82, 60);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(165, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.AccessibleName = "Prenom";
            this.txtPrenom.Location = new System.Drawing.Point(82, 35);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(165, 20);
            this.txtPrenom.TabIndex = 0;
            // 
            // porteBindingSource
            // 
            this.porteBindingSource.DataMember = "Porte";
            this.porteBindingSource.DataSource = this.dataSetIDM;
            // 
            // methodePaiementTableAdapter
            // 
            this.methodePaiementTableAdapter.ClearBeforeFill = true;
            // 
            // porteTableAdapter
            // 
            this.porteTableAdapter.ClearBeforeFill = true;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 508);
            this.Controls.Add(this.groupBoxAjoutClient);
            this.Name = "AjoutClient";
            this.Text = "Ajouter le client";
            this.Load += new System.EventHandler(this.AjoutClient_Load);
            this.groupBoxAjoutClient.ResumeLayout(false);
            this.groupBoxAjoutClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource1)).EndInit();
            this.gbTelephone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.methodePaiementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAjoutClient;
        private System.Windows.Forms.Label lblNewCustComments;
        private System.Windows.Forms.RichTextBox txtCommentaire;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.CheckBox chkBoxActif;
        private System.Windows.Forms.Label lblNewCustEffectDate;
        private System.Windows.Forms.Label lblNewCustAddress;
        private System.Windows.Forms.Label lblNewCustLastName;
        private System.Windows.Forms.Label lblNewCustFirstName;
        private System.Windows.Forms.TextBox txtCodeBarriere;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCodePorte;
        private System.Windows.Forms.Label lblNewCustPayementMethod;
        private System.Windows.Forms.ComboBox cmdMethodePaiement;
        private DataSetIDM dataSetIDM;
        private System.Windows.Forms.BindingSource methodePaiementBindingSource;
        private DataSetIDMTableAdapters.MethodePaiementTableAdapter methodePaiementTableAdapter;
        private System.Windows.Forms.BindingSource porteBindingSource;
        private DataSetIDMTableAdapters.PorteTableAdapter porteTableAdapter;
        private System.Windows.Forms.GroupBox gbTelephone;
        private System.Windows.Forms.Button btnPlusTel;
        private System.Windows.Forms.RichTextBox txtAdresse;
        private System.Windows.Forms.Label lblNewCustVille;
        private System.Windows.Forms.ComboBox cmbVille;
        private BaseDonnee.DataSetVille dataSetVille;
        private System.Windows.Forms.BindingSource dataSetVilleBindingSource;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter villeTableAdapter;
        private System.Windows.Forms.BindingSource villeBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntree;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.CheckBox chkBoxCodePorte;
        private System.Windows.Forms.CheckBox chkBoxCodeBarriere;
    }
}