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
            this.btnCreerContrat = new System.Windows.Forms.Button();
            this.btnFermerDossier = new System.Windows.Forms.Button();
            this.btnEffectuerPaiement = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.pnlSolde = new System.Windows.Forms.Panel();
            this.btnVoirSoldeClient = new System.Windows.Forms.Button();
            this.listBoxResultat = new System.Windows.Forms.ListBox();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.gBoxSearchDoorResult = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblParkingDoor = new System.Windows.Forms.Label();
            this.lblDoorSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLisencePlate = new System.Windows.Forms.Label();
            this.lblDoorCust = new System.Windows.Forms.Label();
            this.lblDoorNumber = new System.Windows.Forms.Label();
            this.lblDoorPlace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCloseDoorResult = new System.Windows.Forms.Button();
            this.btnAddNewDoor = new System.Windows.Forms.Button();
            this.gBoxFindDoor = new System.Windows.Forms.GroupBox();
            this.cmbFindDoorParkingList = new System.Windows.Forms.ComboBox();
            this.lblFindDoorParkingList = new System.Windows.Forms.Label();
            this.lblFindDoorDoorList = new System.Windows.Forms.Label();
            this.cmbFindDoorDoorList = new System.Windows.Forms.ComboBox();
            this.gBoxFindDoorSpecificSearch = new System.Windows.Forms.GroupBox();
            this.btnFindDoorAction = new System.Windows.Forms.Button();
            this.txtFindDoorSpecificSearch = new System.Windows.Forms.TextBox();
            this.rBtnDoorDoor = new System.Windows.Forms.RadioButton();
            this.rBtnDoorPrice = new System.Windows.Forms.RadioButton();
            this.rBtnDoorSize = new System.Windows.Forms.RadioButton();
            this.rBtnDoorPlace = new System.Windows.Forms.RadioButton();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.btnModifierTax = new System.Windows.Forms.Button();
            this.gBoxNewPayementMethod = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btnCloseNewPaiement = new System.Windows.Forms.Button();
            this.btnSaveNewPayementMethod = new System.Windows.Forms.Button();
            this.lblPayementMethod = new System.Windows.Forms.Label();
            this.txtNewPayementMethod = new System.Windows.Forms.TextBox();
            this.gBoxNewPlace = new System.Windows.Forms.GroupBox();
            this.lblNewPostalCode = new System.Windows.Forms.Label();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.lblNewDoorNumber = new System.Windows.Forms.Label();
            this.lblNewPlaceName = new System.Windows.Forms.Label();
            this.txtNouveauSiteCodePostal = new System.Windows.Forms.TextBox();
            this.txtNouveauSiteAdresse = new System.Windows.Forms.TextBox();
            this.txtNouveauSiteNom = new System.Windows.Forms.TextBox();
            this.btnNewPayementMethod = new System.Windows.Forms.Button();
            this.buttonNewPlace = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.porteTableAdapter = new IDM2.DataSetIDMTableAdapters.PorteTableAdapter();
            this.btnAfficherTousClients = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnAppliquerNouveauSite = new System.Windows.Forms.Button();
            this.btnAnnulerNouveauSite = new System.Windows.Forms.Button();
            this.btnOkNouveauSite = new System.Windows.Forms.Button();
            this.cmbNouveauSiteVille = new System.Windows.Forms.ComboBox();
            this.dataSetVille = new IDM2.BaseDonnee.DataSetVille();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villeTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter();
            this.gBoxFindCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIDM)).BeginInit();
            this.gBoxFindCustSpecificSearch.SuspendLayout();
            this.tabControlIDM.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            this.groupBoxDossierClient.SuspendLayout();
            this.pnlSolde.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            this.gBoxSearchDoorResult.SuspendLayout();
            this.gBoxFindDoor.SuspendLayout();
            this.gBoxFindDoorSpecificSearch.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.gBoxNewPayementMethod.SuspendLayout();
            this.gBoxNewPlace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustAddCust
            // 
            this.btnCustAddCust.Location = new System.Drawing.Point(307, 525);
            this.btnCustAddCust.Name = "btnCustAddCust";
            this.btnCustAddCust.Size = new System.Drawing.Size(141, 26);
            this.btnCustAddCust.TabIndex = 0;
            this.btnCustAddCust.Text = "Ajouter un client";
            this.btnCustAddCust.UseVisualStyleBackColor = true;
            this.btnCustAddCust.Click += new System.EventHandler(this.buttonAjoutClient_Click);
            // 
            // gBoxFindCust
            // 
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
            this.tabControlIDM.Controls.Add(this.tabPageLocal);
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
            this.groupBoxDossierClient.Controls.Add(this.btnSupprimerClient);
            this.groupBoxDossierClient.Controls.Add(this.btnCreerContrat);
            this.groupBoxDossierClient.Controls.Add(this.btnFermerDossier);
            this.groupBoxDossierClient.Controls.Add(this.btnEffectuerPaiement);
            this.groupBoxDossierClient.Controls.Add(this.btnCustAddCust);
            this.groupBoxDossierClient.Controls.Add(this.btnModifierClient);
            this.groupBoxDossierClient.Controls.Add(this.pnlSolde);
            this.groupBoxDossierClient.Location = new System.Drawing.Point(418, 6);
            this.groupBoxDossierClient.Name = "groupBoxDossierClient";
            this.groupBoxDossierClient.Size = new System.Drawing.Size(454, 589);
            this.groupBoxDossierClient.TabIndex = 4;
            this.groupBoxDossierClient.TabStop = false;
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
            this.btnModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // pnlSolde
            // 
            this.pnlSolde.BackColor = System.Drawing.Color.Green;
            this.pnlSolde.Controls.Add(this.btnVoirSoldeClient);
            this.pnlSolde.Location = new System.Drawing.Point(307, 131);
            this.pnlSolde.Name = "pnlSolde";
            this.pnlSolde.Size = new System.Drawing.Size(141, 31);
            this.pnlSolde.TabIndex = 41;
            // 
            // btnVoirSoldeClient
            // 
            this.btnVoirSoldeClient.Enabled = false;
            this.btnVoirSoldeClient.Location = new System.Drawing.Point(3, 3);
            this.btnVoirSoldeClient.Name = "btnVoirSoldeClient";
            this.btnVoirSoldeClient.Size = new System.Drawing.Size(135, 25);
            this.btnVoirSoldeClient.TabIndex = 40;
            this.btnVoirSoldeClient.Text = "Voir le Solde";
            this.btnVoirSoldeClient.UseVisualStyleBackColor = true;
            // 
            // listBoxResultat
            // 
            this.listBoxResultat.BackColor = System.Drawing.Color.GhostWhite;
            this.listBoxResultat.FormattingEnabled = true;
            this.listBoxResultat.Location = new System.Drawing.Point(212, 6);
            this.listBoxResultat.Name = "listBoxResultat";
            this.listBoxResultat.Size = new System.Drawing.Size(200, 589);
            this.listBoxResultat.TabIndex = 3;
            this.listBoxResultat.SelectedIndexChanged += new System.EventHandler(this.listBoxResultat_SelectedIndexChanged);
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPageLocal.Controls.Add(this.gBoxSearchDoorResult);
            this.tabPageLocal.Controls.Add(this.btnAddNewDoor);
            this.tabPageLocal.Controls.Add(this.gBoxFindDoor);
            this.tabPageLocal.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocal.Size = new System.Drawing.Size(892, 601);
            this.tabPageLocal.TabIndex = 1;
            this.tabPageLocal.Text = "Locaux et Stationnements";
            // 
            // gBoxSearchDoorResult
            // 
            this.gBoxSearchDoorResult.Controls.Add(this.button1);
            this.gBoxSearchDoorResult.Controls.Add(this.lblParkingDoor);
            this.gBoxSearchDoorResult.Controls.Add(this.lblDoorSize);
            this.gBoxSearchDoorResult.Controls.Add(this.label6);
            this.gBoxSearchDoorResult.Controls.Add(this.lblLisencePlate);
            this.gBoxSearchDoorResult.Controls.Add(this.lblDoorCust);
            this.gBoxSearchDoorResult.Controls.Add(this.lblDoorNumber);
            this.gBoxSearchDoorResult.Controls.Add(this.lblDoorPlace);
            this.gBoxSearchDoorResult.Controls.Add(this.label1);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox6);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox8);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox7);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox5);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox4);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox3);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox2);
            this.gBoxSearchDoorResult.Controls.Add(this.textBox1);
            this.gBoxSearchDoorResult.Controls.Add(this.btnCloseDoorResult);
            this.gBoxSearchDoorResult.Location = new System.Drawing.Point(212, 6);
            this.gBoxSearchDoorResult.Name = "gBoxSearchDoorResult";
            this.gBoxSearchDoorResult.Size = new System.Drawing.Size(488, 589);
            this.gBoxSearchDoorResult.TabIndex = 4;
            this.gBoxSearchDoorResult.TabStop = false;
            this.gBoxSearchDoorResult.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblParkingDoor
            // 
            this.lblParkingDoor.AutoSize = true;
            this.lblParkingDoor.Location = new System.Drawing.Point(168, 49);
            this.lblParkingDoor.Name = "lblParkingDoor";
            this.lblParkingDoor.Size = new System.Drawing.Size(105, 13);
            this.lblParkingDoor.TabIndex = 57;
            this.lblParkingDoor.Text = "Porte/Stationnement";
            // 
            // lblDoorSize
            // 
            this.lblDoorSize.AutoSize = true;
            this.lblDoorSize.Location = new System.Drawing.Point(168, 78);
            this.lblDoorSize.Name = "lblDoorSize";
            this.lblDoorSize.Size = new System.Drawing.Size(56, 13);
            this.lblDoorSize.TabIndex = 56;
            this.lblDoorSize.Text = "Dimension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Montant";
            // 
            // lblLisencePlate
            // 
            this.lblLisencePlate.AutoSize = true;
            this.lblLisencePlate.Location = new System.Drawing.Point(168, 130);
            this.lblLisencePlate.Name = "lblLisencePlate";
            this.lblLisencePlate.Size = new System.Drawing.Size(120, 13);
            this.lblLisencePlate.TabIndex = 54;
            this.lblLisencePlate.Text = "Plaque d\'immatriculation";
            // 
            // lblDoorCust
            // 
            this.lblDoorCust.AutoSize = true;
            this.lblDoorCust.Location = new System.Drawing.Point(168, 156);
            this.lblDoorCust.Name = "lblDoorCust";
            this.lblDoorCust.Size = new System.Drawing.Size(120, 13);
            this.lblDoorCust.TabIndex = 53;
            this.lblDoorCust.Text = "Nom du client occupant";
            // 
            // lblDoorNumber
            // 
            this.lblDoorNumber.AutoSize = true;
            this.lblDoorNumber.Location = new System.Drawing.Point(168, 182);
            this.lblDoorNumber.Name = "lblDoorNumber";
            this.lblDoorNumber.Size = new System.Drawing.Size(87, 13);
            this.lblDoorNumber.TabIndex = 52;
            this.lblDoorNumber.Text = "Numero de Porte";
            // 
            // lblDoorPlace
            // 
            this.lblDoorPlace.AutoSize = true;
            this.lblDoorPlace.Location = new System.Drawing.Point(168, 22);
            this.lblDoorPlace.Name = "lblDoorPlace";
            this.lblDoorPlace.Size = new System.Drawing.Size(71, 13);
            this.lblDoorPlace.TabIndex = 51;
            this.lblDoorPlace.Text = "Emplacement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "PAR";
            // 
            // textBox6
            // 
            this.textBox6.AccessibleName = "Prenom";
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(112, 75);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 49;
            // 
            // textBox8
            // 
            this.textBox8.AccessibleName = "Prenom";
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(21, 49);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 20);
            this.textBox8.TabIndex = 48;
            // 
            // textBox7
            // 
            this.textBox7.AccessibleName = "Prenom";
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(21, 75);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 47;
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "Prenom";
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(21, 101);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 45;
            // 
            // textBox4
            // 
            this.textBox4.AccessibleName = "Prenom";
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(21, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 44;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "Prenom";
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(21, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "Prenom";
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(21, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "Prenom";
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 41;
            // 
            // btnCloseDoorResult
            // 
            this.btnCloseDoorResult.BackColor = System.Drawing.Color.Salmon;
            this.btnCloseDoorResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDoorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDoorResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseDoorResult.Location = new System.Drawing.Point(452, 10);
            this.btnCloseDoorResult.Name = "btnCloseDoorResult";
            this.btnCloseDoorResult.Size = new System.Drawing.Size(31, 23);
            this.btnCloseDoorResult.TabIndex = 40;
            this.btnCloseDoorResult.Text = "X";
            this.btnCloseDoorResult.UseVisualStyleBackColor = false;
            // 
            // btnAddNewDoor
            // 
            this.btnAddNewDoor.Location = new System.Drawing.Point(706, 525);
            this.btnAddNewDoor.Name = "btnAddNewDoor";
            this.btnAddNewDoor.Size = new System.Drawing.Size(103, 70);
            this.btnAddNewDoor.TabIndex = 3;
            this.btnAddNewDoor.Text = "Ajouter une porte ou un stationnement";
            this.btnAddNewDoor.UseVisualStyleBackColor = true;
            this.btnAddNewDoor.Click += new System.EventHandler(this.buttonAjouterPorte_Click);
            // 
            // gBoxFindDoor
            // 
            this.gBoxFindDoor.Controls.Add(this.cmbFindDoorParkingList);
            this.gBoxFindDoor.Controls.Add(this.lblFindDoorParkingList);
            this.gBoxFindDoor.Controls.Add(this.lblFindDoorDoorList);
            this.gBoxFindDoor.Controls.Add(this.cmbFindDoorDoorList);
            this.gBoxFindDoor.Controls.Add(this.gBoxFindDoorSpecificSearch);
            this.gBoxFindDoor.Location = new System.Drawing.Point(6, 6);
            this.gBoxFindDoor.Name = "gBoxFindDoor";
            this.gBoxFindDoor.Size = new System.Drawing.Size(200, 589);
            this.gBoxFindDoor.TabIndex = 2;
            this.gBoxFindDoor.TabStop = false;
            this.gBoxFindDoor.Text = "Recherche";
            // 
            // cmbFindDoorParkingList
            // 
            this.cmbFindDoorParkingList.FormattingEnabled = true;
            this.cmbFindDoorParkingList.Location = new System.Drawing.Point(17, 172);
            this.cmbFindDoorParkingList.Name = "cmbFindDoorParkingList";
            this.cmbFindDoorParkingList.Size = new System.Drawing.Size(158, 21);
            this.cmbFindDoorParkingList.TabIndex = 9;
            // 
            // lblFindDoorParkingList
            // 
            this.lblFindDoorParkingList.AutoSize = true;
            this.lblFindDoorParkingList.Location = new System.Drawing.Point(14, 156);
            this.lblFindDoorParkingList.Name = "lblFindDoorParkingList";
            this.lblFindDoorParkingList.Size = new System.Drawing.Size(128, 13);
            this.lblFindDoorParkingList.TabIndex = 8;
            this.lblFindDoorParkingList.Text = "Listes des stationnements";
            // 
            // lblFindDoorDoorList
            // 
            this.lblFindDoorDoorList.AutoSize = true;
            this.lblFindDoorDoorList.Location = new System.Drawing.Point(14, 49);
            this.lblFindDoorDoorList.Name = "lblFindDoorDoorList";
            this.lblFindDoorDoorList.Size = new System.Drawing.Size(86, 13);
            this.lblFindDoorDoorList.TabIndex = 6;
            this.lblFindDoorDoorList.Text = "Listes des portes";
            // 
            // cmbFindDoorDoorList
            // 
            this.cmbFindDoorDoorList.FormattingEnabled = true;
            this.cmbFindDoorDoorList.Location = new System.Drawing.Point(17, 65);
            this.cmbFindDoorDoorList.Name = "cmbFindDoorDoorList";
            this.cmbFindDoorDoorList.Size = new System.Drawing.Size(158, 21);
            this.cmbFindDoorDoorList.TabIndex = 5;
            // 
            // gBoxFindDoorSpecificSearch
            // 
            this.gBoxFindDoorSpecificSearch.Controls.Add(this.btnFindDoorAction);
            this.gBoxFindDoorSpecificSearch.Controls.Add(this.txtFindDoorSpecificSearch);
            this.gBoxFindDoorSpecificSearch.Controls.Add(this.rBtnDoorDoor);
            this.gBoxFindDoorSpecificSearch.Controls.Add(this.rBtnDoorPrice);
            this.gBoxFindDoorSpecificSearch.Controls.Add(this.rBtnDoorSize);
            this.gBoxFindDoorSpecificSearch.Controls.Add(this.rBtnDoorPlace);
            this.gBoxFindDoorSpecificSearch.Location = new System.Drawing.Point(6, 406);
            this.gBoxFindDoorSpecificSearch.Name = "gBoxFindDoorSpecificSearch";
            this.gBoxFindDoorSpecificSearch.Size = new System.Drawing.Size(188, 183);
            this.gBoxFindDoorSpecificSearch.TabIndex = 4;
            this.gBoxFindDoorSpecificSearch.TabStop = false;
            this.gBoxFindDoorSpecificSearch.Text = "Recherche specifique";
            // 
            // btnFindDoorAction
            // 
            this.btnFindDoorAction.Location = new System.Drawing.Point(11, 154);
            this.btnFindDoorAction.Name = "btnFindDoorAction";
            this.btnFindDoorAction.Size = new System.Drawing.Size(158, 23);
            this.btnFindDoorAction.TabIndex = 5;
            this.btnFindDoorAction.Text = "Rechercher";
            this.btnFindDoorAction.UseVisualStyleBackColor = true;
            this.btnFindDoorAction.Click += new System.EventHandler(this.buttonRecherchePorte_Click);
            // 
            // txtFindDoorSpecificSearch
            // 
            this.txtFindDoorSpecificSearch.Location = new System.Drawing.Point(11, 35);
            this.txtFindDoorSpecificSearch.Name = "txtFindDoorSpecificSearch";
            this.txtFindDoorSpecificSearch.Size = new System.Drawing.Size(158, 20);
            this.txtFindDoorSpecificSearch.TabIndex = 4;
            // 
            // rBtnDoorDoor
            // 
            this.rBtnDoorDoor.AutoSize = true;
            this.rBtnDoorDoor.Checked = true;
            this.rBtnDoorDoor.Location = new System.Drawing.Point(11, 61);
            this.rBtnDoorDoor.Name = "rBtnDoorDoor";
            this.rBtnDoorDoor.Size = new System.Drawing.Size(124, 17);
            this.rBtnDoorDoor.TabIndex = 0;
            this.rBtnDoorDoor.TabStop = true;
            this.rBtnDoorDoor.Text = "Recherche par Porte";
            this.rBtnDoorDoor.UseVisualStyleBackColor = true;
            // 
            // rBtnDoorPrice
            // 
            this.rBtnDoorPrice.AutoSize = true;
            this.rBtnDoorPrice.Location = new System.Drawing.Point(11, 130);
            this.rBtnDoorPrice.Name = "rBtnDoorPrice";
            this.rBtnDoorPrice.Size = new System.Drawing.Size(116, 17);
            this.rBtnDoorPrice.TabIndex = 1;
            this.rBtnDoorPrice.Text = "Recherche par Prix";
            this.rBtnDoorPrice.UseVisualStyleBackColor = true;
            // 
            // rBtnDoorSize
            // 
            this.rBtnDoorSize.AutoSize = true;
            this.rBtnDoorSize.Location = new System.Drawing.Point(11, 107);
            this.rBtnDoorSize.Name = "rBtnDoorSize";
            this.rBtnDoorSize.Size = new System.Drawing.Size(143, 17);
            this.rBtnDoorSize.TabIndex = 2;
            this.rBtnDoorSize.Text = "Recherche par Grandeur";
            this.rBtnDoorSize.UseVisualStyleBackColor = true;
            // 
            // rBtnDoorPlace
            // 
            this.rBtnDoorPlace.AutoSize = true;
            this.rBtnDoorPlace.Location = new System.Drawing.Point(11, 84);
            this.rBtnDoorPlace.Name = "rBtnDoorPlace";
            this.rBtnDoorPlace.Size = new System.Drawing.Size(163, 17);
            this.rBtnDoorPlace.TabIndex = 3;
            this.rBtnDoorPlace.Text = "Recherche par Emplacement";
            this.rBtnDoorPlace.UseVisualStyleBackColor = true;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.btnModifierTax);
            this.tabPageAdmin.Controls.Add(this.gBoxNewPayementMethod);
            this.tabPageAdmin.Controls.Add(this.gBoxNewPlace);
            this.tabPageAdmin.Controls.Add(this.btnNewPayementMethod);
            this.tabPageAdmin.Controls.Add(this.buttonNewPlace);
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
            // gBoxNewPayementMethod
            // 
            this.gBoxNewPayementMethod.Controls.Add(this.textBox9);
            this.gBoxNewPayementMethod.Controls.Add(this.btnCloseNewPaiement);
            this.gBoxNewPayementMethod.Controls.Add(this.btnSaveNewPayementMethod);
            this.gBoxNewPayementMethod.Controls.Add(this.lblPayementMethod);
            this.gBoxNewPayementMethod.Controls.Add(this.txtNewPayementMethod);
            this.gBoxNewPayementMethod.Location = new System.Drawing.Point(202, 274);
            this.gBoxNewPayementMethod.Name = "gBoxNewPayementMethod";
            this.gBoxNewPayementMethod.Size = new System.Drawing.Size(258, 246);
            this.gBoxNewPayementMethod.TabIndex = 3;
            this.gBoxNewPayementMethod.TabStop = false;
            this.gBoxNewPayementMethod.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 93);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 42;
            // 
            // btnCloseNewPaiement
            // 
            this.btnCloseNewPaiement.BackColor = System.Drawing.Color.Salmon;
            this.btnCloseNewPaiement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseNewPaiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseNewPaiement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseNewPaiement.Location = new System.Drawing.Point(215, 13);
            this.btnCloseNewPaiement.Name = "btnCloseNewPaiement";
            this.btnCloseNewPaiement.Size = new System.Drawing.Size(31, 23);
            this.btnCloseNewPaiement.TabIndex = 41;
            this.btnCloseNewPaiement.Text = "X";
            this.btnCloseNewPaiement.UseVisualStyleBackColor = false;
            this.btnCloseNewPaiement.Click += new System.EventHandler(this.buttonCloseNewPaiement_Click);
            // 
            // btnSaveNewPayementMethod
            // 
            this.btnSaveNewPayementMethod.Location = new System.Drawing.Point(6, 211);
            this.btnSaveNewPayementMethod.Name = "btnSaveNewPayementMethod";
            this.btnSaveNewPayementMethod.Size = new System.Drawing.Size(100, 23);
            this.btnSaveNewPayementMethod.TabIndex = 12;
            this.btnSaveNewPayementMethod.Text = "Enregistrer";
            this.btnSaveNewPayementMethod.UseVisualStyleBackColor = true;
            this.btnSaveNewPayementMethod.Click += new System.EventHandler(this.btnSaveNewPayementMethod_Click);
            // 
            // lblPayementMethod
            // 
            this.lblPayementMethod.AutoSize = true;
            this.lblPayementMethod.Location = new System.Drawing.Point(112, 70);
            this.lblPayementMethod.Name = "lblPayementMethod";
            this.lblPayementMethod.Size = new System.Drawing.Size(110, 13);
            this.lblPayementMethod.TabIndex = 1;
            this.lblPayementMethod.Text = "Methode de paiement";
            // 
            // txtNewPayementMethod
            // 
            this.txtNewPayementMethod.Location = new System.Drawing.Point(6, 67);
            this.txtNewPayementMethod.Name = "txtNewPayementMethod";
            this.txtNewPayementMethod.Size = new System.Drawing.Size(100, 20);
            this.txtNewPayementMethod.TabIndex = 0;
            // 
            // gBoxNewPlace
            // 
            this.gBoxNewPlace.Controls.Add(this.cmbNouveauSiteVille);
            this.gBoxNewPlace.Controls.Add(this.btnAppliquerNouveauSite);
            this.gBoxNewPlace.Controls.Add(this.btnAnnulerNouveauSite);
            this.gBoxNewPlace.Controls.Add(this.btnOkNouveauSite);
            this.gBoxNewPlace.Controls.Add(this.lblNewPostalCode);
            this.gBoxNewPlace.Controls.Add(this.lblNewCity);
            this.gBoxNewPlace.Controls.Add(this.lblNewDoorNumber);
            this.gBoxNewPlace.Controls.Add(this.lblNewPlaceName);
            this.gBoxNewPlace.Controls.Add(this.txtNouveauSiteCodePostal);
            this.gBoxNewPlace.Controls.Add(this.txtNouveauSiteAdresse);
            this.gBoxNewPlace.Controls.Add(this.txtNouveauSiteNom);
            this.gBoxNewPlace.Location = new System.Drawing.Point(202, 12);
            this.gBoxNewPlace.Name = "gBoxNewPlace";
            this.gBoxNewPlace.Size = new System.Drawing.Size(364, 229);
            this.gBoxNewPlace.TabIndex = 2;
            this.gBoxNewPlace.TabStop = false;
            this.gBoxNewPlace.Visible = false;
            // 
            // lblNewPostalCode
            // 
            this.lblNewPostalCode.AutoSize = true;
            this.lblNewPostalCode.Location = new System.Drawing.Point(139, 113);
            this.lblNewPostalCode.Name = "lblNewPostalCode";
            this.lblNewPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblNewPostalCode.TabIndex = 10;
            this.lblNewPostalCode.Text = "Code Postal";
            // 
            // lblNewCity
            // 
            this.lblNewCity.AutoSize = true;
            this.lblNewCity.Location = new System.Drawing.Point(139, 87);
            this.lblNewCity.Name = "lblNewCity";
            this.lblNewCity.Size = new System.Drawing.Size(26, 13);
            this.lblNewCity.TabIndex = 9;
            this.lblNewCity.Text = "Ville";
            // 
            // lblNewDoorNumber
            // 
            this.lblNewDoorNumber.AutoSize = true;
            this.lblNewDoorNumber.Location = new System.Drawing.Point(139, 60);
            this.lblNewDoorNumber.Name = "lblNewDoorNumber";
            this.lblNewDoorNumber.Size = new System.Drawing.Size(92, 13);
            this.lblNewDoorNumber.TabIndex = 7;
            this.lblNewDoorNumber.Text = "Numero d\'adresse";
            // 
            // lblNewPlaceName
            // 
            this.lblNewPlaceName.AutoSize = true;
            this.lblNewPlaceName.Location = new System.Drawing.Point(139, 34);
            this.lblNewPlaceName.Name = "lblNewPlaceName";
            this.lblNewPlaceName.Size = new System.Drawing.Size(83, 13);
            this.lblNewPlaceName.TabIndex = 5;
            this.lblNewPlaceName.Text = "Nom de l\'endroit";
            // 
            // txtNouveauSiteCodePostal
            // 
            this.txtNouveauSiteCodePostal.Location = new System.Drawing.Point(13, 110);
            this.txtNouveauSiteCodePostal.Name = "txtNouveauSiteCodePostal";
            this.txtNouveauSiteCodePostal.Size = new System.Drawing.Size(120, 20);
            this.txtNouveauSiteCodePostal.TabIndex = 4;
            // 
            // txtNouveauSiteAdresse
            // 
            this.txtNouveauSiteAdresse.Location = new System.Drawing.Point(13, 57);
            this.txtNouveauSiteAdresse.Name = "txtNouveauSiteAdresse";
            this.txtNouveauSiteAdresse.Size = new System.Drawing.Size(120, 20);
            this.txtNouveauSiteAdresse.TabIndex = 1;
            // 
            // txtNouveauSiteNom
            // 
            this.txtNouveauSiteNom.Location = new System.Drawing.Point(13, 31);
            this.txtNouveauSiteNom.Name = "txtNouveauSiteNom";
            this.txtNouveauSiteNom.Size = new System.Drawing.Size(120, 20);
            this.txtNouveauSiteNom.TabIndex = 0;
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
            // buttonNewPlace
            // 
            this.buttonNewPlace.Location = new System.Drawing.Point(16, 12);
            this.buttonNewPlace.Name = "buttonNewPlace";
            this.buttonNewPlace.Size = new System.Drawing.Size(156, 47);
            this.buttonNewPlace.TabIndex = 0;
            this.buttonNewPlace.Text = "Créer un nouveau site";
            this.buttonNewPlace.UseVisualStyleBackColor = true;
            this.buttonNewPlace.Click += new System.EventHandler(this.buttonNewPlace_Click);
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
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(307, 557);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(141, 26);
            this.btnSupprimerClient.TabIndex = 56;
            this.btnSupprimerClient.Text = "Supprimer le client";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnAppliquerNouveauSite
            // 
            this.btnAppliquerNouveauSite.Location = new System.Drawing.Point(245, 148);
            this.btnAppliquerNouveauSite.Name = "btnAppliquerNouveauSite";
            this.btnAppliquerNouveauSite.Size = new System.Drawing.Size(110, 23);
            this.btnAppliquerNouveauSite.TabIndex = 43;
            this.btnAppliquerNouveauSite.Text = "Appliquer";
            this.btnAppliquerNouveauSite.UseVisualStyleBackColor = true;
            this.btnAppliquerNouveauSite.Click += new System.EventHandler(this.btnAppliquerNouveauSite_Click);
            // 
            // btnAnnulerNouveauSite
            // 
            this.btnAnnulerNouveauSite.Location = new System.Drawing.Point(129, 148);
            this.btnAnnulerNouveauSite.Name = "btnAnnulerNouveauSite";
            this.btnAnnulerNouveauSite.Size = new System.Drawing.Size(110, 23);
            this.btnAnnulerNouveauSite.TabIndex = 42;
            this.btnAnnulerNouveauSite.Text = "Annuler";
            this.btnAnnulerNouveauSite.UseVisualStyleBackColor = true;
            // 
            // btnOkNouveauSite
            // 
            this.btnOkNouveauSite.Location = new System.Drawing.Point(13, 148);
            this.btnOkNouveauSite.Name = "btnOkNouveauSite";
            this.btnOkNouveauSite.Size = new System.Drawing.Size(110, 23);
            this.btnOkNouveauSite.TabIndex = 41;
            this.btnOkNouveauSite.Text = "OK";
            this.btnOkNouveauSite.UseVisualStyleBackColor = true;
            // 
            // cmbNouveauSiteVille
            // 
            this.cmbNouveauSiteVille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNouveauSiteVille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNouveauSiteVille.DataSource = this.villeBindingSource;
            this.cmbNouveauSiteVille.DisplayMember = "Ville";
            this.cmbNouveauSiteVille.FormattingEnabled = true;
            this.cmbNouveauSiteVille.Location = new System.Drawing.Point(13, 83);
            this.cmbNouveauSiteVille.Name = "cmbNouveauSiteVille";
            this.cmbNouveauSiteVille.Size = new System.Drawing.Size(120, 21);
            this.cmbNouveauSiteVille.TabIndex = 45;
            this.cmbNouveauSiteVille.ValueMember = "VilleId";
            // 
            // dataSetVille
            // 
            this.dataSetVille.DataSetName = "DataSetVille";
            this.dataSetVille.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "Ville";
            this.villeBindingSource.DataSource = this.dataSetVille;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1128, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlIDM);
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
            this.pnlSolde.ResumeLayout(false);
            this.tabPageLocal.ResumeLayout(false);
            this.gBoxSearchDoorResult.ResumeLayout(false);
            this.gBoxSearchDoorResult.PerformLayout();
            this.gBoxFindDoor.ResumeLayout(false);
            this.gBoxFindDoor.PerformLayout();
            this.gBoxFindDoorSpecificSearch.ResumeLayout(false);
            this.gBoxFindDoorSpecificSearch.PerformLayout();
            this.tabPageAdmin.ResumeLayout(false);
            this.gBoxNewPayementMethod.ResumeLayout(false);
            this.gBoxNewPayementMethod.PerformLayout();
            this.gBoxNewPlace.ResumeLayout(false);
            this.gBoxNewPlace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.Button btnAddNewDoor;
        private System.Windows.Forms.GroupBox gBoxFindDoor;
        private System.Windows.Forms.ComboBox cmbFindDoorParkingList;
        private System.Windows.Forms.Label lblFindDoorParkingList;
        private System.Windows.Forms.Label lblFindDoorDoorList;
        private System.Windows.Forms.ComboBox cmbFindDoorDoorList;
        private System.Windows.Forms.GroupBox gBoxFindDoorSpecificSearch;
        private System.Windows.Forms.Button btnFindDoorAction;
        private System.Windows.Forms.TextBox txtFindDoorSpecificSearch;
        private System.Windows.Forms.RadioButton rBtnDoorDoor;
        private System.Windows.Forms.RadioButton rBtnDoorPrice;
        private System.Windows.Forms.RadioButton rBtnDoorSize;
        private System.Windows.Forms.RadioButton rBtnDoorPlace;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.GroupBox gBoxSearchDoorResult;
        private System.Windows.Forms.Button btnVoirSoldeClient;
        private System.Windows.Forms.Panel pnlSolde;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseDoorResult;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.GroupBox gBoxNewPayementMethod;
        private System.Windows.Forms.GroupBox gBoxNewPlace;
        private System.Windows.Forms.Label lblNewPostalCode;
        private System.Windows.Forms.Label lblNewCity;
        private System.Windows.Forms.Label lblNewDoorNumber;
        private System.Windows.Forms.Label lblNewPlaceName;
        private System.Windows.Forms.TextBox txtNouveauSiteCodePostal;
        private System.Windows.Forms.TextBox txtNouveauSiteAdresse;
        private System.Windows.Forms.TextBox txtNouveauSiteNom;
        private System.Windows.Forms.Button btnNewPayementMethod;
        private System.Windows.Forms.Button buttonNewPlace;
        private System.Windows.Forms.Button btnSaveNewPayementMethod;
        private System.Windows.Forms.Label lblPayementMethod;
        private System.Windows.Forms.TextBox txtNewPayementMethod;
        private System.Windows.Forms.Button btnCloseNewPaiement;
        private DataSetIDM dataSetIDM;
        private System.Windows.Forms.BindingSource porteBindingSource;
        private DataSetIDMTableAdapters.PorteTableAdapter porteTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParkingDoor;
        private System.Windows.Forms.Label lblDoorSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLisencePlate;
        private System.Windows.Forms.Label lblDoorCust;
        private System.Windows.Forms.Label lblDoorNumber;
        private System.Windows.Forms.Label lblDoorPlace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxResultat;
        private System.Windows.Forms.Button btnEffectuerPaiement;
        private System.Windows.Forms.Button btnModifierTax;
        private System.Windows.Forms.GroupBox groupBoxDossierClient;
        private System.Windows.Forms.Button btnFermerDossier;
        private System.Windows.Forms.Button btnCreerContrat;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnAfficherTousClients;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnAppliquerNouveauSite;
        private System.Windows.Forms.Button btnAnnulerNouveauSite;
        private System.Windows.Forms.Button btnOkNouveauSite;
        private System.Windows.Forms.ComboBox cmbNouveauSiteVille;
        private BaseDonnee.DataSetVille dataSetVille;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter villeTableAdapter;





    }
}

