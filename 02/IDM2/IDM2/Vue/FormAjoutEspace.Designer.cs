﻿namespace IDM2
{
    partial class FormAjoutEspace
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
            this.emplacementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIDM = new IDM2.DataSetIDM();
            this.emplacementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new IDM2.DataSetIDMTableAdapters.ClientTableAdapter();
            this.emplacementTableAdapter = new IDM2.DataSetIDMTableAdapters.EmplacementTableAdapter();
            this.groupBoxAjoutEspace = new System.Windows.Forms.GroupBox();
            this.txtMontantTvq = new System.Windows.Forms.TextBox();
            this.txtMontantTps = new System.Windows.Forms.TextBox();
            this.lblMontantAvTaxe = new System.Windows.Forms.Label();
            this.txtMontantAvTaxe = new System.Windows.Forms.TextBox();
            this.lblTvq = new System.Windows.Forms.Label();
            this.lblTps = new System.Windows.Forms.Label();
            this.txtTvq = new System.Windows.Forms.TextBox();
            this.txtTps = new System.Windows.Forms.TextBox();
            this.radioButtonStationnement = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.chkBoxCreerTypeEspace = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkBoxDisponible = new System.Windows.Forms.CheckBox();
            this.lblBatiment = new System.Windows.Forms.Label();
            this.cmbBatiment = new System.Windows.Forms.ComboBox();
            this.lblNoLocal = new System.Windows.Forms.Label();
            this.txtNoLocal = new System.Windows.Forms.TextBox();
            this.lblGrandeur = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtLongueur = new System.Windows.Forms.TextBox();
            this.txtLargeur = new System.Windows.Forms.TextBox();
            this.groupBoxInfoEspace = new System.Windows.Forms.GroupBox();
            this.listBoxLocal = new System.Windows.Forms.ListBox();
            this.lblTypeEspace = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.cmbTypeEspace = new System.Windows.Forms.ComboBox();
            this.typeEspaceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVille = new IDM2.BaseDonnee.DataSetVille();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.typeEspaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.SiteTableAdapter();
            this.typeEspaceTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.TypeEspaceTableAdapter();
            this.groupBoxAjoutLocal = new System.Windows.Forms.GroupBox();
            this.gbCreationTypeEspace = new System.Windows.Forms.GroupBox();
            this.chkBoxCreerLocal = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBoxAjoutEspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeEspaceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEspaceBindingSource)).BeginInit();
            this.groupBoxAjoutLocal.SuspendLayout();
            this.gbCreationTypeEspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // emplacementBindingSource1
            // 
            this.emplacementBindingSource1.DataMember = "Emplacement";
            this.emplacementBindingSource1.DataSource = this.dataSetIDM;
            // 
            // dataSetIDM
            // 
            this.dataSetIDM.DataSetName = "DataSetIDM";
            this.dataSetIDM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emplacementBindingSource
            // 
            this.emplacementBindingSource.DataMember = "Emplacement";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSetIDM;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // emplacementTableAdapter
            // 
            this.emplacementTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxAjoutEspace
            // 
            this.groupBoxAjoutEspace.Controls.Add(this.chkBoxCreerLocal);
            this.groupBoxAjoutEspace.Controls.Add(this.gbCreationTypeEspace);
            this.groupBoxAjoutEspace.Controls.Add(this.groupBoxAjoutLocal);
            this.groupBoxAjoutEspace.Controls.Add(this.chkBoxCreerTypeEspace);
            this.groupBoxAjoutEspace.Controls.Add(this.lblBatiment);
            this.groupBoxAjoutEspace.Controls.Add(this.cmbBatiment);
            this.groupBoxAjoutEspace.Controls.Add(this.groupBoxInfoEspace);
            this.groupBoxAjoutEspace.Controls.Add(this.listBoxLocal);
            this.groupBoxAjoutEspace.Controls.Add(this.lblTypeEspace);
            this.groupBoxAjoutEspace.Controls.Add(this.lblSite);
            this.groupBoxAjoutEspace.Controls.Add(this.cmbTypeEspace);
            this.groupBoxAjoutEspace.Controls.Add(this.cmbSite);
            this.groupBoxAjoutEspace.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAjoutEspace.Name = "groupBoxAjoutEspace";
            this.groupBoxAjoutEspace.Size = new System.Drawing.Size(979, 490);
            this.groupBoxAjoutEspace.TabIndex = 0;
            this.groupBoxAjoutEspace.TabStop = false;
            // 
            // txtMontantTvq
            // 
            this.txtMontantTvq.Enabled = false;
            this.txtMontantTvq.Location = new System.Drawing.Point(92, 164);
            this.txtMontantTvq.Name = "txtMontantTvq";
            this.txtMontantTvq.Size = new System.Drawing.Size(72, 20);
            this.txtMontantTvq.TabIndex = 81;
            // 
            // txtMontantTps
            // 
            this.txtMontantTps.Enabled = false;
            this.txtMontantTps.Location = new System.Drawing.Point(92, 139);
            this.txtMontantTps.Name = "txtMontantTps";
            this.txtMontantTps.Size = new System.Drawing.Size(72, 20);
            this.txtMontantTps.TabIndex = 80;
            // 
            // lblMontantAvTaxe
            // 
            this.lblMontantAvTaxe.AutoSize = true;
            this.lblMontantAvTaxe.Location = new System.Drawing.Point(170, 116);
            this.lblMontantAvTaxe.Name = "lblMontantAvTaxe";
            this.lblMontantAvTaxe.Size = new System.Drawing.Size(99, 13);
            this.lblMontantAvTaxe.TabIndex = 79;
            this.lblMontantAvTaxe.Text = "Montant avant taxe";
            // 
            // txtMontantAvTaxe
            // 
            this.txtMontantAvTaxe.Enabled = false;
            this.txtMontantAvTaxe.Location = new System.Drawing.Point(6, 113);
            this.txtMontantAvTaxe.Name = "txtMontantAvTaxe";
            this.txtMontantAvTaxe.Size = new System.Drawing.Size(158, 20);
            this.txtMontantAvTaxe.TabIndex = 78;
            // 
            // lblTvq
            // 
            this.lblTvq.AutoSize = true;
            this.lblTvq.Location = new System.Drawing.Point(58, 167);
            this.lblTvq.Name = "lblTvq";
            this.lblTvq.Size = new System.Drawing.Size(29, 13);
            this.lblTvq.TabIndex = 77;
            this.lblTvq.Text = "TVQ";
            // 
            // lblTps
            // 
            this.lblTps.AutoSize = true;
            this.lblTps.Location = new System.Drawing.Point(58, 142);
            this.lblTps.Name = "lblTps";
            this.lblTps.Size = new System.Drawing.Size(28, 13);
            this.lblTps.TabIndex = 76;
            this.lblTps.Text = "TPS";
            // 
            // txtTvq
            // 
            this.txtTvq.Enabled = false;
            this.txtTvq.Location = new System.Drawing.Point(6, 164);
            this.txtTvq.Name = "txtTvq";
            this.txtTvq.Size = new System.Drawing.Size(46, 20);
            this.txtTvq.TabIndex = 75;
            // 
            // txtTps
            // 
            this.txtTps.Enabled = false;
            this.txtTps.Location = new System.Drawing.Point(6, 139);
            this.txtTps.Name = "txtTps";
            this.txtTps.Size = new System.Drawing.Size(46, 20);
            this.txtTps.TabIndex = 74;
            // 
            // radioButtonStationnement
            // 
            this.radioButtonStationnement.AccessibleDescription = "Stationnement";
            this.radioButtonStationnement.AutoSize = true;
            this.radioButtonStationnement.Enabled = false;
            this.radioButtonStationnement.Location = new System.Drawing.Point(63, 28);
            this.radioButtonStationnement.Name = "radioButtonStationnement";
            this.radioButtonStationnement.Size = new System.Drawing.Size(93, 17);
            this.radioButtonStationnement.TabIndex = 73;
            this.radioButtonStationnement.Text = "Stationnement";
            this.radioButtonStationnement.UseVisualStyleBackColor = true;
            this.radioButtonStationnement.CheckedChanged += new System.EventHandler(this.radioButtonStationnement_CheckedChanged);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AccessibleDescription = "Local";
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Checked = true;
            this.radioButtonLocal.Enabled = false;
            this.radioButtonLocal.Location = new System.Drawing.Point(6, 28);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLocal.TabIndex = 72;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonLocal_CheckedChanged);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(97, 90);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(24, 13);
            this.lblPrix.TabIndex = 71;
            this.lblPrix.Text = "Prix";
            // 
            // txtPrix
            // 
            this.txtPrix.Enabled = false;
            this.txtPrix.Location = new System.Drawing.Point(6, 87);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(85, 20);
            this.txtPrix.TabIndex = 70;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            // 
            // chkBoxCreerTypeEspace
            // 
            this.chkBoxCreerTypeEspace.AutoSize = true;
            this.chkBoxCreerTypeEspace.Location = new System.Drawing.Point(15, 100);
            this.chkBoxCreerTypeEspace.Name = "chkBoxCreerTypeEspace";
            this.chkBoxCreerTypeEspace.Size = new System.Drawing.Size(180, 17);
            this.chkBoxCreerTypeEspace.TabIndex = 69;
            this.chkBoxCreerTypeEspace.Text = "Créer un nouveau type d\'espace";
            this.chkBoxCreerTypeEspace.UseVisualStyleBackColor = true;
            this.chkBoxCreerTypeEspace.CheckedChanged += new System.EventHandler(this.chkBoxCreerTypeEspace_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(183, 215);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 68;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(6, 190);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 65);
            this.txtDescription.TabIndex = 67;
            // 
            // chkBoxDisponible
            // 
            this.chkBoxDisponible.AutoSize = true;
            this.chkBoxDisponible.BackColor = System.Drawing.Color.LightGreen;
            this.chkBoxDisponible.Checked = true;
            this.chkBoxDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxDisponible.Location = new System.Drawing.Point(6, 76);
            this.chkBoxDisponible.Name = "chkBoxDisponible";
            this.chkBoxDisponible.Size = new System.Drawing.Size(75, 17);
            this.chkBoxDisponible.TabIndex = 66;
            this.chkBoxDisponible.Text = "Disponible";
            this.chkBoxDisponible.UseVisualStyleBackColor = false;
            this.chkBoxDisponible.CheckedChanged += new System.EventHandler(this.chkBoxDisponible_CheckedChanged);
            // 
            // lblBatiment
            // 
            this.lblBatiment.AutoSize = true;
            this.lblBatiment.Location = new System.Drawing.Point(194, 49);
            this.lblBatiment.Name = "lblBatiment";
            this.lblBatiment.Size = new System.Drawing.Size(48, 13);
            this.lblBatiment.TabIndex = 65;
            this.lblBatiment.Text = "Bâtiment";
            // 
            // cmbBatiment
            // 
            this.cmbBatiment.Enabled = false;
            this.cmbBatiment.FormattingEnabled = true;
            this.cmbBatiment.Location = new System.Drawing.Point(15, 46);
            this.cmbBatiment.Name = "cmbBatiment";
            this.cmbBatiment.Size = new System.Drawing.Size(171, 21);
            this.cmbBatiment.TabIndex = 64;
            // 
            // lblNoLocal
            // 
            this.lblNoLocal.AutoSize = true;
            this.lblNoLocal.Location = new System.Drawing.Point(66, 51);
            this.lblNoLocal.Name = "lblNoLocal";
            this.lblNoLocal.Size = new System.Drawing.Size(84, 13);
            this.lblNoLocal.TabIndex = 63;
            this.lblNoLocal.Text = "Numéro du local";
            // 
            // txtNoLocal
            // 
            this.txtNoLocal.Location = new System.Drawing.Point(6, 51);
            this.txtNoLocal.Name = "txtNoLocal";
            this.txtNoLocal.Size = new System.Drawing.Size(54, 20);
            this.txtNoLocal.TabIndex = 62;
            // 
            // lblGrandeur
            // 
            this.lblGrandeur.AutoSize = true;
            this.lblGrandeur.Location = new System.Drawing.Point(96, 64);
            this.lblGrandeur.Name = "lblGrandeur";
            this.lblGrandeur.Size = new System.Drawing.Size(91, 13);
            this.lblGrandeur.TabIndex = 61;
            this.lblGrandeur.Text = "Grandeur du local";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(38, 64);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 13);
            this.lblX.TabIndex = 60;
            this.lblX.Text = "par";
            // 
            // txtLongueur
            // 
            this.txtLongueur.Enabled = false;
            this.txtLongueur.Location = new System.Drawing.Point(61, 61);
            this.txtLongueur.Name = "txtLongueur";
            this.txtLongueur.Size = new System.Drawing.Size(29, 20);
            this.txtLongueur.TabIndex = 59;
            this.txtLongueur.TextChanged += new System.EventHandler(this.txtLonguer_TextChanged);
            // 
            // txtLargeur
            // 
            this.txtLargeur.Enabled = false;
            this.txtLargeur.Location = new System.Drawing.Point(6, 61);
            this.txtLargeur.Name = "txtLargeur";
            this.txtLargeur.Size = new System.Drawing.Size(29, 20);
            this.txtLargeur.TabIndex = 58;
            this.txtLargeur.TextChanged += new System.EventHandler(this.txtLargeur_TextChanged);
            // 
            // groupBoxInfoEspace
            // 
            this.groupBoxInfoEspace.Location = new System.Drawing.Point(616, 12);
            this.groupBoxInfoEspace.Name = "groupBoxInfoEspace";
            this.groupBoxInfoEspace.Size = new System.Drawing.Size(300, 275);
            this.groupBoxInfoEspace.TabIndex = 57;
            this.groupBoxInfoEspace.TabStop = false;
            this.groupBoxInfoEspace.Text = "Info du local!";
            // 
            // listBoxLocal
            // 
            this.listBoxLocal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxLocal.FormattingEnabled = true;
            this.listBoxLocal.Location = new System.Drawing.Point(506, 12);
            this.listBoxLocal.Name = "listBoxLocal";
            this.listBoxLocal.Size = new System.Drawing.Size(104, 472);
            this.listBoxLocal.TabIndex = 56;
            this.listBoxLocal.SelectedIndexChanged += new System.EventHandler(this.listBoxLocal_SelectedIndexChanged);
            // 
            // lblTypeEspace
            // 
            this.lblTypeEspace.AutoSize = true;
            this.lblTypeEspace.Location = new System.Drawing.Point(192, 76);
            this.lblTypeEspace.Name = "lblTypeEspace";
            this.lblTypeEspace.Size = new System.Drawing.Size(77, 13);
            this.lblTypeEspace.TabIndex = 55;
            this.lblTypeEspace.Text = "Type d\'espace";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(192, 22);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 54;
            this.lblSite.Text = "Site";
            // 
            // cmbTypeEspace
            // 
            this.cmbTypeEspace.DataSource = this.typeEspaceBindingSource1;
            this.cmbTypeEspace.DisplayMember = "Description";
            this.cmbTypeEspace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeEspace.FormattingEnabled = true;
            this.cmbTypeEspace.Location = new System.Drawing.Point(15, 73);
            this.cmbTypeEspace.Name = "cmbTypeEspace";
            this.cmbTypeEspace.Size = new System.Drawing.Size(171, 21);
            this.cmbTypeEspace.TabIndex = 53;
            this.cmbTypeEspace.ValueMember = "TypeEspaceId";
            this.cmbTypeEspace.SelectedIndexChanged += new System.EventHandler(this.cmbTypeEspace_SelectedIndexChanged);
            // 
            // typeEspaceBindingSource1
            // 
            this.typeEspaceBindingSource1.DataMember = "TypeEspace";
            this.typeEspaceBindingSource1.DataSource = this.dataSetVille;
            // 
            // dataSetVille
            // 
            this.dataSetVille.DataSetName = "DataSetVille";
            this.dataSetVille.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSite
            // 
            this.cmbSite.DataSource = this.siteBindingSource;
            this.cmbSite.DisplayMember = "Alias";
            this.cmbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(15, 19);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(171, 21);
            this.cmbSite.TabIndex = 52;
            this.cmbSite.ValueMember = "SiteId";
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.dataSetVille;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(6, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 23);
            this.btnOk.TabIndex = 51;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(97, 119);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(85, 23);
            this.btnAnnuler.TabIndex = 50;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(188, 119);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(85, 23);
            this.btnAppliquer.TabIndex = 49;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // typeEspaceBindingSource
            // 
            this.typeEspaceBindingSource.DataMember = "TypeEspace";
            this.typeEspaceBindingSource.DataSource = this.dataSetVille;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // typeEspaceTableAdapter
            // 
            this.typeEspaceTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxAjoutLocal
            // 
            this.groupBoxAjoutLocal.Controls.Add(this.txtNoLocal);
            this.groupBoxAjoutLocal.Controls.Add(this.lblNoLocal);
            this.groupBoxAjoutLocal.Controls.Add(this.chkBoxDisponible);
            this.groupBoxAjoutLocal.Controls.Add(this.btnOk);
            this.groupBoxAjoutLocal.Controls.Add(this.btnAppliquer);
            this.groupBoxAjoutLocal.Controls.Add(this.btnAnnuler);
            this.groupBoxAjoutLocal.Location = new System.Drawing.Point(314, 167);
            this.groupBoxAjoutLocal.Name = "groupBoxAjoutLocal";
            this.groupBoxAjoutLocal.Size = new System.Drawing.Size(296, 156);
            this.groupBoxAjoutLocal.TabIndex = 82;
            this.groupBoxAjoutLocal.TabStop = false;
            this.groupBoxAjoutLocal.Text = "Création d\'un local";
            this.groupBoxAjoutLocal.Visible = false;
            // 
            // gbCreationTypeEspace
            // 
            this.gbCreationTypeEspace.Controls.Add(this.button1);
            this.gbCreationTypeEspace.Controls.Add(this.button2);
            this.gbCreationTypeEspace.Controls.Add(this.button3);
            this.gbCreationTypeEspace.Controls.Add(this.txtLargeur);
            this.gbCreationTypeEspace.Controls.Add(this.txtLongueur);
            this.gbCreationTypeEspace.Controls.Add(this.lblX);
            this.gbCreationTypeEspace.Controls.Add(this.txtMontantTvq);
            this.gbCreationTypeEspace.Controls.Add(this.lblGrandeur);
            this.gbCreationTypeEspace.Controls.Add(this.txtMontantTps);
            this.gbCreationTypeEspace.Controls.Add(this.txtDescription);
            this.gbCreationTypeEspace.Controls.Add(this.lblMontantAvTaxe);
            this.gbCreationTypeEspace.Controls.Add(this.lblDescription);
            this.gbCreationTypeEspace.Controls.Add(this.txtMontantAvTaxe);
            this.gbCreationTypeEspace.Controls.Add(this.txtPrix);
            this.gbCreationTypeEspace.Controls.Add(this.lblTvq);
            this.gbCreationTypeEspace.Controls.Add(this.lblPrix);
            this.gbCreationTypeEspace.Controls.Add(this.lblTps);
            this.gbCreationTypeEspace.Controls.Add(this.radioButtonLocal);
            this.gbCreationTypeEspace.Controls.Add(this.txtTvq);
            this.gbCreationTypeEspace.Controls.Add(this.radioButtonStationnement);
            this.gbCreationTypeEspace.Controls.Add(this.txtTps);
            this.gbCreationTypeEspace.Location = new System.Drawing.Point(15, 157);
            this.gbCreationTypeEspace.Name = "gbCreationTypeEspace";
            this.gbCreationTypeEspace.Size = new System.Drawing.Size(296, 308);
            this.gbCreationTypeEspace.TabIndex = 84;
            this.gbCreationTypeEspace.TabStop = false;
            this.gbCreationTypeEspace.Text = "Création d\'un type d\'espace";
            this.gbCreationTypeEspace.Visible = false;
            // 
            // chkBoxCreerLocal
            // 
            this.chkBoxCreerLocal.AutoSize = true;
            this.chkBoxCreerLocal.Location = new System.Drawing.Point(15, 123);
            this.chkBoxCreerLocal.Name = "chkBoxCreerLocal";
            this.chkBoxCreerLocal.Size = new System.Drawing.Size(136, 17);
            this.chkBoxCreerLocal.TabIndex = 85;
            this.chkBoxCreerLocal.Text = "Créer un nouveau local";
            this.chkBoxCreerLocal.UseVisualStyleBackColor = true;
            this.chkBoxCreerLocal.CheckedChanged += new System.EventHandler(this.chkBoxCreerLocal_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 84;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 82;
            this.button2.Text = "Appliquer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 83;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormAjoutEspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 508);
            this.Controls.Add(this.groupBoxAjoutEspace);
            this.Name = "FormAjoutEspace";
            this.Load += new System.EventHandler(this.AjoutPorte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplacementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupBoxAjoutEspace.ResumeLayout(false);
            this.groupBoxAjoutEspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeEspaceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEspaceBindingSource)).EndInit();
            this.groupBoxAjoutLocal.ResumeLayout(false);
            this.groupBoxAjoutLocal.PerformLayout();
            this.gbCreationTypeEspace.ResumeLayout(false);
            this.gbCreationTypeEspace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource emplacementBindingSource;
        private DataSetIDM dataSetIDM;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSetIDMTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource emplacementBindingSource1;
        private DataSetIDMTableAdapters.EmplacementTableAdapter emplacementTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxAjoutEspace;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.ListBox listBoxLocal;
        private System.Windows.Forms.Label lblTypeEspace;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.ComboBox cmbTypeEspace;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.GroupBox groupBoxInfoEspace;
        private System.Windows.Forms.CheckBox chkBoxDisponible;
        private System.Windows.Forms.Label lblBatiment;
        private System.Windows.Forms.ComboBox cmbBatiment;
        private System.Windows.Forms.Label lblNoLocal;
        private System.Windows.Forms.TextBox txtNoLocal;
        private System.Windows.Forms.Label lblGrandeur;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtLongueur;
        private System.Windows.Forms.TextBox txtLargeur;
        private BaseDonnee.DataSetVille dataSetVille;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.CheckBox chkBoxCreerTypeEspace;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.BindingSource typeEspaceBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.TypeEspaceTableAdapter typeEspaceTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonStationnement;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.TextBox txtMontantTvq;
        private System.Windows.Forms.TextBox txtMontantTps;
        private System.Windows.Forms.Label lblMontantAvTaxe;
        private System.Windows.Forms.TextBox txtMontantAvTaxe;
        private System.Windows.Forms.Label lblTvq;
        private System.Windows.Forms.Label lblTps;
        private System.Windows.Forms.TextBox txtTvq;
        private System.Windows.Forms.TextBox txtTps;
        private System.Windows.Forms.BindingSource typeEspaceBindingSource1;
        private System.Windows.Forms.GroupBox groupBoxAjoutLocal;
        private System.Windows.Forms.GroupBox gbCreationTypeEspace;
        private System.Windows.Forms.CheckBox chkBoxCreerLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}