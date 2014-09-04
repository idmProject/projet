namespace IDM2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCustAddCust = new System.Windows.Forms.Button();
            this.gBoxFindCust = new System.Windows.Forms.GroupBox();
            this.btnAfficherEspaces = new System.Windows.Forms.Button();
            this.btnAfficherTousClients = new System.Windows.Forms.Button();
            this.lblFindCustDoor = new System.Windows.Forms.Label();
            this.cmbFindCustDoorList = new System.Windows.Forms.ComboBox();
            this.porteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIDM = new IDM2.DataSetIDM();
            this.gBoxFindCustSpecificSearch = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtFindCustSpecificSearch = new System.Windows.Forms.TextBox();
            this.rBtnCustSpecificSearchDoor = new System.Windows.Forms.RadioButton();
            this.rBtnCustSpecificSearchPhone = new System.Windows.Forms.RadioButton();
            this.rBtnCustSpecificSearchLastName = new System.Windows.Forms.RadioButton();
            this.tabControlIDM = new System.Windows.Forms.TabControl();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.groupBoxDossierClient = new System.Windows.Forms.GroupBox();
            this.btnGestionEspace = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnCreerContrat = new System.Windows.Forms.Button();
            this.btnFermerDossier = new System.Windows.Forms.Button();
            this.btnEffectuerPaiement = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnVoirSoldeClient = new System.Windows.Forms.Button();
            this.listBoxResultat = new System.Windows.Forms.ListBox();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.btnModifierTax = new System.Windows.Forms.Button();
            this.btnNewPayementMethod = new System.Windows.Forms.Button();
            this.btnCreerSite = new System.Windows.Forms.Button();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVille = new IDM2.BaseDonnee.DataSetVille();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.porteTableAdapter = new IDM2.DataSetIDMTableAdapters.PorteTableAdapter();
            this.villeTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxFindCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIDM)).BeginInit();
            this.gBoxFindCustSpecificSearch.SuspendLayout();
            this.tabControlIDM.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            this.groupBoxDossierClient.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustAddCust
            // 
            this.btnCustAddCust.Location = new System.Drawing.Point(307, 557);
            this.btnCustAddCust.Name = "btnCustAddCust";
            this.btnCustAddCust.Size = new System.Drawing.Size(141, 26);
            this.btnCustAddCust.TabIndex = 0;
            this.btnCustAddCust.Text = "Ajouter un client";
            this.btnCustAddCust.UseVisualStyleBackColor = true;
            this.btnCustAddCust.Click += new System.EventHandler(this.buttonAjoutClient_Click);
            // 
            // gBoxFindCust
            // 
            this.gBoxFindCust.Controls.Add(this.btnAfficherEspaces);
            this.gBoxFindCust.Controls.Add(this.btnAfficherTousClients);
            this.gBoxFindCust.Controls.Add(this.lblFindCustDoor);
            this.gBoxFindCust.Controls.Add(this.cmbFindCustDoorList);
            this.gBoxFindCust.Controls.Add(this.gBoxFindCustSpecificSearch);
            this.gBoxFindCust.Location = new System.Drawing.Point(6, 6);
            this.gBoxFindCust.Name = "gBoxFindCust";
            this.gBoxFindCust.Size = new System.Drawing.Size(200, 589);
            this.gBoxFindCust.TabIndex = 1;
            this.gBoxFindCust.TabStop = false;
            this.gBoxFindCust.Text = "Recherche";
            // 
            // btnAfficherEspaces
            // 
            this.btnAfficherEspaces.Location = new System.Drawing.Point(17, 286);
            this.btnAfficherEspaces.Name = "btnAfficherEspaces";
            this.btnAfficherEspaces.Size = new System.Drawing.Size(169, 54);
            this.btnAfficherEspaces.TabIndex = 8;
            this.btnAfficherEspaces.Text = "Afficher tous les espaces";
            this.btnAfficherEspaces.UseVisualStyleBackColor = true;
            this.btnAfficherEspaces.Click += new System.EventHandler(this.btnAfficherEspaces_Click);
            // 
            // btnAfficherTousClients
            // 
            this.btnAfficherTousClients.Location = new System.Drawing.Point(17, 346);
            this.btnAfficherTousClients.Name = "btnAfficherTousClients";
            this.btnAfficherTousClients.Size = new System.Drawing.Size(169, 54);
            this.btnAfficherTousClients.TabIndex = 7;
            this.btnAfficherTousClients.Text = "Afficher tous les clients";
            this.btnAfficherTousClients.UseVisualStyleBackColor = true;
            this.btnAfficherTousClients.Click += new System.EventHandler(this.btnAfficherTousClients_Click);
            // 
            // lblFindCustDoor
            // 
            this.lblFindCustDoor.AutoSize = true;
            this.lblFindCustDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindCustDoor.Location = new System.Drawing.Point(14, 49);
            this.lblFindCustDoor.Name = "lblFindCustDoor";
            this.lblFindCustDoor.Size = new System.Drawing.Size(174, 13);
            this.lblFindCustDoor.TabIndex = 6;
            this.lblFindCustDoor.Text = "Listes des locaux et stationnements";
            // 
            // cmbFindCustDoorList
            // 
            this.cmbFindCustDoorList.DataSource = this.porteBindingSource;
            this.cmbFindCustDoorList.DisplayMember = "NumeroPorte";
            this.cmbFindCustDoorList.FormattingEnabled = true;
            this.cmbFindCustDoorList.Location = new System.Drawing.Point(17, 65);
            this.cmbFindCustDoorList.Name = "cmbFindCustDoorList";
            this.cmbFindCustDoorList.Size = new System.Drawing.Size(169, 21);
            this.cmbFindCustDoorList.TabIndex = 5;
            this.cmbFindCustDoorList.ValueMember = "NumeroPorte";
            // 
            // porteBindingSource
            // 
            this.porteBindingSource.DataMember = "Porte";
            this.porteBindingSource.DataSource = this.dataSetIDM;
            // 
            // dataSetIDM
            // 
            this.dataSetIDM.DataSetName = "DataSetIDM";
            this.dataSetIDM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gBoxFindCustSpecificSearch
            // 
            this.gBoxFindCustSpecificSearch.Controls.Add(this.btnRechercher);
            this.gBoxFindCustSpecificSearch.Controls.Add(this.txtFindCustSpecificSearch);
            this.gBoxFindCustSpecificSearch.Controls.Add(this.rBtnCustSpecificSearchDoor);
            this.gBoxFindCustSpecificSearch.Controls.Add(this.rBtnCustSpecificSearchPhone);
            this.gBoxFindCustSpecificSearch.Controls.Add(this.rBtnCustSpecificSearchLastName);
            this.gBoxFindCustSpecificSearch.Location = new System.Drawing.Point(6, 406);
            this.gBoxFindCustSpecificSearch.Name = "gBoxFindCustSpecificSearch";
            this.gBoxFindCustSpecificSearch.Size = new System.Drawing.Size(188, 183);
            this.gBoxFindCustSpecificSearch.TabIndex = 4;
            this.gBoxFindCustSpecificSearch.TabStop = false;
            this.gBoxFindCustSpecificSearch.Text = "Recherche specifique";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(11, 154);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(158, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtFindCustSpecificSearch
            // 
            this.txtFindCustSpecificSearch.Location = new System.Drawing.Point(11, 35);
            this.txtFindCustSpecificSearch.Name = "txtFindCustSpecificSearch";
            this.txtFindCustSpecificSearch.Size = new System.Drawing.Size(158, 20);
            this.txtFindCustSpecificSearch.TabIndex = 4;
            // 
            // rBtnCustSpecificSearchDoor
            // 
            this.rBtnCustSpecificSearchDoor.AutoSize = true;
            this.rBtnCustSpecificSearchDoor.Checked = true;
            this.rBtnCustSpecificSearchDoor.Location = new System.Drawing.Point(11, 61);
            this.rBtnCustSpecificSearchDoor.Name = "rBtnCustSpecificSearchDoor";
            this.rBtnCustSpecificSearchDoor.Size = new System.Drawing.Size(174, 17);
            this.rBtnCustSpecificSearchDoor.TabIndex = 0;
            this.rBtnCustSpecificSearchDoor.TabStop = true;
            this.rBtnCustSpecificSearchDoor.Text = "Recherche par numéro de local";
            this.rBtnCustSpecificSearchDoor.UseVisualStyleBackColor = true;
            // 
            // rBtnCustSpecificSearchPhone
            // 
            this.rBtnCustSpecificSearchPhone.AutoSize = true;
            this.rBtnCustSpecificSearchPhone.Location = new System.Drawing.Point(11, 107);
            this.rBtnCustSpecificSearchPhone.Name = "rBtnCustSpecificSearchPhone";
            this.rBtnCustSpecificSearchPhone.Size = new System.Drawing.Size(150, 17);
            this.rBtnCustSpecificSearchPhone.TabIndex = 1;
            this.rBtnCustSpecificSearchPhone.Text = "Recherche par Telephone";
            this.rBtnCustSpecificSearchPhone.UseVisualStyleBackColor = true;
            // 
            // rBtnCustSpecificSearchLastName
            // 
            this.rBtnCustSpecificSearchLastName.AutoSize = true;
            this.rBtnCustSpecificSearchLastName.Location = new System.Drawing.Point(11, 84);
            this.rBtnCustSpecificSearchLastName.Name = "rBtnCustSpecificSearchLastName";
            this.rBtnCustSpecificSearchLastName.Size = new System.Drawing.Size(121, 17);
            this.rBtnCustSpecificSearchLastName.TabIndex = 2;
            this.rBtnCustSpecificSearchLastName.Text = "Recherche par Nom";
            this.rBtnCustSpecificSearchLastName.UseVisualStyleBackColor = true;
            // 
            // tabControlIDM
            // 
            this.tabControlIDM.Controls.Add(this.tabPageClient);
            this.tabControlIDM.Controls.Add(this.tabPageAdmin);
            this.tabControlIDM.Location = new System.Drawing.Point(12, 12);
            this.tabControlIDM.Name = "tabControlIDM";
            this.tabControlIDM.SelectedIndex = 0;
            this.tabControlIDM.Size = new System.Drawing.Size(900, 627);
            this.tabControlIDM.TabIndex = 2;
            this.tabControlIDM.SelectedIndexChanged += new System.EventHandler(this.tabControlIDM_SelectedIndexChanged);
            // 
            // tabPageClient
            // 
            this.tabPageClient.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPageClient.Controls.Add(this.dataGridView1);
            this.tabPageClient.Controls.Add(this.groupBoxDossierClient);
            this.tabPageClient.Controls.Add(this.listBoxResultat);
            this.tabPageClient.Controls.Add(this.gBoxFindCust);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(892, 601);
            this.tabPageClient.TabIndex = 0;
            this.tabPageClient.Text = "Clients";
            // 
            // groupBoxDossierClient
            // 
            this.groupBoxDossierClient.Controls.Add(this.btnVoirSoldeClient);
            this.groupBoxDossierClient.Controls.Add(this.btnGestionEspace);
            this.groupBoxDossierClient.Controls.Add(this.btnSupprimerClient);
            this.groupBoxDossierClient.Controls.Add(this.btnCreerContrat);
            this.groupBoxDossierClient.Controls.Add(this.btnFermerDossier);
            this.groupBoxDossierClient.Controls.Add(this.btnEffectuerPaiement);
            this.groupBoxDossierClient.Controls.Add(this.btnCustAddCust);
            this.groupBoxDossierClient.Controls.Add(this.btnModifierClient);
            this.groupBoxDossierClient.Location = new System.Drawing.Point(418, 6);
            this.groupBoxDossierClient.Name = "groupBoxDossierClient";
            this.groupBoxDossierClient.Size = new System.Drawing.Size(454, 589);
            this.groupBoxDossierClient.TabIndex = 4;
            this.groupBoxDossierClient.TabStop = false;
            // 
            // btnGestionEspace
            // 
            this.btnGestionEspace.Location = new System.Drawing.Point(307, 528);
            this.btnGestionEspace.Name = "btnGestionEspace";
            this.btnGestionEspace.Size = new System.Drawing.Size(138, 23);
            this.btnGestionEspace.TabIndex = 57;
            this.btnGestionEspace.Text = "Gestion espace";
            this.btnGestionEspace.UseVisualStyleBackColor = true;
            this.btnGestionEspace.Click += new System.EventHandler(this.btnGestionEspace_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(307, 197);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(141, 26);
            this.btnSupprimerClient.TabIndex = 56;
            this.btnSupprimerClient.Text = "Supprimer le client";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Visible = false;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnCreerContrat
            // 
            this.btnCreerContrat.Enabled = false;
            this.btnCreerContrat.Location = new System.Drawing.Point(307, 20);
            this.btnCreerContrat.Name = "btnCreerContrat";
            this.btnCreerContrat.Size = new System.Drawing.Size(141, 23);
            this.btnCreerContrat.TabIndex = 55;
            this.btnCreerContrat.Text = "Ajouter un contrat";
            this.btnCreerContrat.UseVisualStyleBackColor = true;
            this.btnCreerContrat.Visible = false;
            this.btnCreerContrat.Click += new System.EventHandler(this.btnCreerContrat_Click);
            // 
            // btnFermerDossier
            // 
            this.btnFermerDossier.Enabled = false;
            this.btnFermerDossier.Location = new System.Drawing.Point(307, 168);
            this.btnFermerDossier.Name = "btnFermerDossier";
            this.btnFermerDossier.Size = new System.Drawing.Size(141, 23);
            this.btnFermerDossier.TabIndex = 54;
            this.btnFermerDossier.Text = "Fermer le dossier";
            this.btnFermerDossier.UseVisualStyleBackColor = true;
            this.btnFermerDossier.Visible = false;
            this.btnFermerDossier.Click += new System.EventHandler(this.btnFermerDossier_Click);
            // 
            // btnEffectuerPaiement
            // 
            this.btnEffectuerPaiement.Enabled = false;
            this.btnEffectuerPaiement.Location = new System.Drawing.Point(307, 102);
            this.btnEffectuerPaiement.Name = "btnEffectuerPaiement";
            this.btnEffectuerPaiement.Size = new System.Drawing.Size(141, 23);
            this.btnEffectuerPaiement.TabIndex = 53;
            this.btnEffectuerPaiement.Text = "Effectuer un paiement";
            this.btnEffectuerPaiement.UseVisualStyleBackColor = true;
            this.btnEffectuerPaiement.Visible = false;
            this.btnEffectuerPaiement.Click += new System.EventHandler(this.btnEffectuerPaiement_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Enabled = false;
            this.btnModifierClient.Location = new System.Drawing.Point(307, 49);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(141, 47);
            this.btnModifierClient.TabIndex = 38;
            this.btnModifierClient.Text = "Modifier les informations du client";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            this.btnModifierClient.Visible = false;
            this.btnModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // btnVoirSoldeClient
            // 
            this.btnVoirSoldeClient.Enabled = false;
            this.btnVoirSoldeClient.Location = new System.Drawing.Point(310, 131);
            this.btnVoirSoldeClient.Name = "btnVoirSoldeClient";
            this.btnVoirSoldeClient.Size = new System.Drawing.Size(135, 25);
            this.btnVoirSoldeClient.TabIndex = 40;
            this.btnVoirSoldeClient.Text = "Voir le Solde";
            this.btnVoirSoldeClient.UseVisualStyleBackColor = true;
            this.btnVoirSoldeClient.Visible = false;
            this.btnVoirSoldeClient.Click += new System.EventHandler(this.btnVoirSoldeClient_Click);
            // 
            // listBoxResultat
            // 
            this.listBoxResultat.BackColor = System.Drawing.Color.GhostWhite;
            this.listBoxResultat.FormattingEnabled = true;
            this.listBoxResultat.Location = new System.Drawing.Point(212, 6);
            this.listBoxResultat.MultiColumn = true;
            this.listBoxResultat.Name = "listBoxResultat";
            this.listBoxResultat.Size = new System.Drawing.Size(200, 43);
            this.listBoxResultat.TabIndex = 3;
            this.listBoxResultat.SelectedIndexChanged += new System.EventHandler(this.listBoxResultat_SelectedIndexChanged);
            this.listBoxResultat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxResultat_KeyUp);
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.btnModifierTax);
            this.tabPageAdmin.Controls.Add(this.btnNewPayementMethod);
            this.tabPageAdmin.Controls.Add(this.btnCreerSite);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Size = new System.Drawing.Size(892, 601);
            this.tabPageAdmin.TabIndex = 2;
            this.tabPageAdmin.Text = "Section Administrateur";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // btnModifierTax
            // 
            this.btnModifierTax.Location = new System.Drawing.Point(16, 117);
            this.btnModifierTax.Name = "btnModifierTax";
            this.btnModifierTax.Size = new System.Drawing.Size(156, 47);
            this.btnModifierTax.TabIndex = 4;
            this.btnModifierTax.Text = "Modifier les paramètres de taxes";
            this.btnModifierTax.UseVisualStyleBackColor = true;
            this.btnModifierTax.Click += new System.EventHandler(this.btnModifierTax_Click);
            // 
            // btnNewPayementMethod
            // 
            this.btnNewPayementMethod.Location = new System.Drawing.Point(16, 65);
            this.btnNewPayementMethod.Name = "btnNewPayementMethod";
            this.btnNewPayementMethod.Size = new System.Drawing.Size(156, 47);
            this.btnNewPayementMethod.TabIndex = 1;
            this.btnNewPayementMethod.Text = "Creer une nouvelle methode de paiement";
            this.btnNewPayementMethod.UseVisualStyleBackColor = true;
            this.btnNewPayementMethod.Click += new System.EventHandler(this.btnNewPayementMethod_Click);
            // 
            // btnCreerSite
            // 
            this.btnCreerSite.Location = new System.Drawing.Point(16, 12);
            this.btnCreerSite.Name = "btnCreerSite";
            this.btnCreerSite.Size = new System.Drawing.Size(156, 47);
            this.btnCreerSite.TabIndex = 0;
            this.btnCreerSite.Text = "Créer un nouveau site";
            this.btnCreerSite.UseVisualStyleBackColor = true;
            this.btnCreerSite.Click += new System.EventHandler(this.btnCreerSite_Click);
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "Ville";
            this.villeBindingSource.DataSource = this.dataSetVille;
            // 
            // dataSetVille
            // 
            this.dataSetVille.DataSetName = "DataSetVille";
            this.dataSetVille.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IDM2.Properties.Resources.idmlogopetit;
            this.pictureBox1.Location = new System.Drawing.Point(918, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 165);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // porteTableAdapter
            // 
            this.porteTableAdapter.ClearBeforeFill = true;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 399);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlIDM);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Gestion IDM";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.gBoxFindCust.ResumeLayout(false);
            this.gBoxFindCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIDM)).EndInit();
            this.gBoxFindCustSpecificSearch.ResumeLayout(false);
            this.gBoxFindCustSpecificSearch.PerformLayout();
            this.tabControlIDM.ResumeLayout(false);
            this.tabPageClient.ResumeLayout(false);
            this.groupBoxDossierClient.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustAddCust;
        private System.Windows.Forms.GroupBox gBoxFindCust;
        private System.Windows.Forms.Label lblFindCustDoor;
        private System.Windows.Forms.ComboBox cmbFindCustDoorList;
        private System.Windows.Forms.GroupBox gBoxFindCustSpecificSearch;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtFindCustSpecificSearch;
        private System.Windows.Forms.RadioButton rBtnCustSpecificSearchDoor;
        private System.Windows.Forms.RadioButton rBtnCustSpecificSearchPhone;
        private System.Windows.Forms.RadioButton rBtnCustSpecificSearchLastName;
        private System.Windows.Forms.TabControl tabControlIDM;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnVoirSoldeClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.Button btnNewPayementMethod;
        private System.Windows.Forms.Button btnCreerSite;
        private DataSetIDM dataSetIDM;
        private System.Windows.Forms.BindingSource porteBindingSource;
        private DataSetIDMTableAdapters.PorteTableAdapter porteTableAdapter;
        private System.Windows.Forms.ListBox listBoxResultat;
        private System.Windows.Forms.Button btnEffectuerPaiement;
        private System.Windows.Forms.Button btnModifierTax;
        private System.Windows.Forms.GroupBox groupBoxDossierClient;
        private System.Windows.Forms.Button btnFermerDossier;
        private System.Windows.Forms.Button btnCreerContrat;
        private System.Windows.Forms.Button btnAfficherTousClients;
        private System.Windows.Forms.Button btnSupprimerClient;
        private BaseDonnee.DataSetVille dataSetVille;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter villeTableAdapter;
        private System.Windows.Forms.Button btnAfficherEspaces;
        private System.Windows.Forms.Button btnGestionEspace;
        private System.Windows.Forms.DataGridView dataGridView1;





    }
}

