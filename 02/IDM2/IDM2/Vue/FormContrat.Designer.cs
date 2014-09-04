namespace IDM2.Vue
{
    partial class FormContrat
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
            this.gbCreationContrat = new System.Windows.Forms.GroupBox();
            this.cmbNoStationnement = new System.Windows.Forms.ComboBox();
            this.stationnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVille = new IDM2.BaseDonnee.DataSetVille();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrixSuggerer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.chkBoxDateSortie = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateSortie = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateEntree = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateCreation = new System.Windows.Forms.TextBox();
            this.lblTypeLocation = new System.Windows.Forms.Label();
            this.cmbTypeLocation = new System.Windows.Forms.ComboBox();
            this.typeEspaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.cmbNoLocal = new System.Windows.Forms.ComboBox();
            this.localBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.siteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.SiteTableAdapter();
            this.typeEspaceTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.TypeEspaceTableAdapter();
            this.localTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.LocalTableAdapter();
            this.espaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.espaceTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.EspaceTableAdapter();
            this.stationnementTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.StationnementTableAdapter();
            this.lblNoStationnement = new System.Windows.Forms.Label();
            this.gbCreationContrat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEspaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCreationContrat
            // 
            this.gbCreationContrat.Controls.Add(this.lblNoStationnement);
            this.gbCreationContrat.Controls.Add(this.cmbNoStationnement);
            this.gbCreationContrat.Controls.Add(this.label4);
            this.gbCreationContrat.Controls.Add(this.txtPrixSuggerer);
            this.gbCreationContrat.Controls.Add(this.label3);
            this.gbCreationContrat.Controls.Add(this.dateTimePickerDateSortie);
            this.gbCreationContrat.Controls.Add(this.txtPrix);
            this.gbCreationContrat.Controls.Add(this.chkBoxDateSortie);
            this.gbCreationContrat.Controls.Add(this.lblTypeLocation);
            this.gbCreationContrat.Controls.Add(this.txtDateCreation);
            this.gbCreationContrat.Controls.Add(this.label2);
            this.gbCreationContrat.Controls.Add(this.cmbTypeLocation);
            this.gbCreationContrat.Controls.Add(this.label1);
            this.gbCreationContrat.Controls.Add(this.lblLocal);
            this.gbCreationContrat.Controls.Add(this.dateTimePickerDateEntree);
            this.gbCreationContrat.Controls.Add(this.lblSite);
            this.gbCreationContrat.Controls.Add(this.cmbNoLocal);
            this.gbCreationContrat.Controls.Add(this.cmbSite);
            this.gbCreationContrat.Location = new System.Drawing.Point(315, 0);
            this.gbCreationContrat.Name = "gbCreationContrat";
            this.gbCreationContrat.Size = new System.Drawing.Size(300, 360);
            this.gbCreationContrat.TabIndex = 0;
            this.gbCreationContrat.TabStop = false;
            this.gbCreationContrat.Text = "Création d\'un contrat";
            // 
            // cmbNoStationnement
            // 
            this.cmbNoStationnement.DataSource = this.stationnementBindingSource;
            this.cmbNoStationnement.DisplayMember = "NoStationnement";
            this.cmbNoStationnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoStationnement.Enabled = false;
            this.cmbNoStationnement.FormattingEnabled = true;
            this.cmbNoStationnement.Location = new System.Drawing.Point(6, 223);
            this.cmbNoStationnement.Name = "cmbNoStationnement";
            this.cmbNoStationnement.Size = new System.Drawing.Size(121, 21);
            this.cmbNoStationnement.TabIndex = 19;
            this.cmbNoStationnement.ValueMember = "EspaceId";
            this.cmbNoStationnement.SelectedIndexChanged += new System.EventHandler(this.cmbNoStationnement_SelectedIndexChanged);
            // 
            // stationnementBindingSource
            // 
            this.stationnementBindingSource.DataMember = "Stationnement";
            this.stationnementBindingSource.DataSource = this.dataSetVille;
            // 
            // dataSetVille
            // 
            this.dataSetVille.DataSetName = "DataSetVille";
            this.dataSetVille.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Prix suggéré";
            // 
            // txtPrixSuggerer
            // 
            this.txtPrixSuggerer.Enabled = false;
            this.txtPrixSuggerer.Location = new System.Drawing.Point(5, 316);
            this.txtPrixSuggerer.Name = "txtPrixSuggerer";
            this.txtPrixSuggerer.Size = new System.Drawing.Size(92, 20);
            this.txtPrixSuggerer.TabIndex = 17;
            this.txtPrixSuggerer.Text = "PrixSuggéré";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Prix";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(5, 289);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(92, 20);
            this.txtPrix.TabIndex = 15;
            // 
            // chkBoxDateSortie
            // 
            this.chkBoxDateSortie.AutoSize = true;
            this.chkBoxDateSortie.Location = new System.Drawing.Point(135, 85);
            this.chkBoxDateSortie.Name = "chkBoxDateSortie";
            this.chkBoxDateSortie.Size = new System.Drawing.Size(92, 17);
            this.chkBoxDateSortie.TabIndex = 14;
            this.chkBoxDateSortie.Text = "Date de sortie";
            this.chkBoxDateSortie.UseVisualStyleBackColor = true;
            this.chkBoxDateSortie.CheckedChanged += new System.EventHandler(this.chkBoxDateSortie_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date d\'entrée";
            // 
            // dateTimePickerDateSortie
            // 
            this.dateTimePickerDateSortie.Enabled = false;
            this.dateTimePickerDateSortie.Location = new System.Drawing.Point(5, 85);
            this.dateTimePickerDateSortie.Name = "dateTimePickerDateSortie";
            this.dateTimePickerDateSortie.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDateSortie.TabIndex = 11;
            // 
            // dateTimePickerDateEntree
            // 
            this.dateTimePickerDateEntree.Location = new System.Drawing.Point(6, 59);
            this.dateTimePickerDateEntree.Name = "dateTimePickerDateEntree";
            this.dateTimePickerDateEntree.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDateEntree.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date de création du contrat";
            // 
            // txtDateCreation
            // 
            this.txtDateCreation.Enabled = false;
            this.txtDateCreation.Location = new System.Drawing.Point(6, 33);
            this.txtDateCreation.Name = "txtDateCreation";
            this.txtDateCreation.Size = new System.Drawing.Size(120, 20);
            this.txtDateCreation.TabIndex = 8;
            this.txtDateCreation.Text = "DateAujourdhui";
            // 
            // lblTypeLocation
            // 
            this.lblTypeLocation.AutoSize = true;
            this.lblTypeLocation.Location = new System.Drawing.Point(133, 172);
            this.lblTypeLocation.Name = "lblTypeLocation";
            this.lblTypeLocation.Size = new System.Drawing.Size(86, 13);
            this.lblTypeLocation.TabIndex = 5;
            this.lblTypeLocation.Text = "Type de location";
            // 
            // cmbTypeLocation
            // 
            this.cmbTypeLocation.DataSource = this.typeEspaceBindingSource;
            this.cmbTypeLocation.DisplayMember = "Description";
            this.cmbTypeLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeLocation.FormattingEnabled = true;
            this.cmbTypeLocation.Location = new System.Drawing.Point(6, 169);
            this.cmbTypeLocation.Name = "cmbTypeLocation";
            this.cmbTypeLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeLocation.TabIndex = 4;
            this.cmbTypeLocation.ValueMember = "TypeEspaceId";
            this.cmbTypeLocation.SelectedIndexChanged += new System.EventHandler(this.cmbTypeLocation_SelectedIndexChanged);
            // 
            // typeEspaceBindingSource
            // 
            this.typeEspaceBindingSource.DataMember = "TypeEspace";
            this.typeEspaceBindingSource.DataSource = this.dataSetVille;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(133, 199);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(84, 13);
            this.lblLocal.TabIndex = 3;
            this.lblLocal.Text = "Numéro de local";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(133, 145);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 2;
            this.lblSite.Text = "Site";
            // 
            // cmbNoLocal
            // 
            this.cmbNoLocal.DataSource = this.localBindingSource;
            this.cmbNoLocal.DisplayMember = "NoLocal";
            this.cmbNoLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoLocal.Enabled = false;
            this.cmbNoLocal.FormattingEnabled = true;
            this.cmbNoLocal.Location = new System.Drawing.Point(6, 196);
            this.cmbNoLocal.Name = "cmbNoLocal";
            this.cmbNoLocal.Size = new System.Drawing.Size(121, 21);
            this.cmbNoLocal.TabIndex = 1;
            this.cmbNoLocal.ValueMember = "EspaceId";
            this.cmbNoLocal.SelectedIndexChanged += new System.EventHandler(this.cmbNoLocal_SelectedIndexChanged);
            // 
            // localBindingSource
            // 
            this.localBindingSource.DataMember = "Local";
            this.localBindingSource.DataSource = this.dataSetVille;
            // 
            // cmbSite
            // 
            this.cmbSite.DataSource = this.siteBindingSource1;
            this.cmbSite.DisplayMember = "Alias";
            this.cmbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(6, 142);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(121, 21);
            this.cmbSite.TabIndex = 0;
            this.cmbSite.ValueMember = "SiteId";
            this.cmbSite.SelectedIndexChanged += new System.EventHandler(this.cmbSite_SelectedIndexChanged);
            // 
            // siteBindingSource1
            // 
            this.siteBindingSource1.DataMember = "Site";
            this.siteBindingSource1.DataSource = this.dataSetVille;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(351, 625);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(467, 625);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(110, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(583, 625);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(110, 23);
            this.btnAppliquer.TabIndex = 4;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.dataSetVille;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // typeEspaceTableAdapter
            // 
            this.typeEspaceTableAdapter.ClearBeforeFill = true;
            // 
            // localTableAdapter
            // 
            this.localTableAdapter.ClearBeforeFill = true;
            // 
            // espaceBindingSource
            // 
            this.espaceBindingSource.DataMember = "Espace";
            this.espaceBindingSource.DataSource = this.dataSetVille;
            // 
            // espaceTableAdapter
            // 
            this.espaceTableAdapter.ClearBeforeFill = true;
            // 
            // stationnementTableAdapter
            // 
            this.stationnementTableAdapter.ClearBeforeFill = true;
            // 
            // lblNoStationnement
            // 
            this.lblNoStationnement.AutoSize = true;
            this.lblNoStationnement.Location = new System.Drawing.Point(133, 226);
            this.lblNoStationnement.Name = "lblNoStationnement";
            this.lblNoStationnement.Size = new System.Drawing.Size(130, 13);
            this.lblNoStationnement.TabIndex = 20;
            this.lblNoStationnement.Text = "Numéro de Stationnement";
            // 
            // FormContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 660);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbCreationContrat);
            this.Name = "FormContrat";
            this.Text = "FormContrat";
            this.Load += new System.EventHandler(this.FormContrat_Load);
            this.gbCreationContrat.ResumeLayout(false);
            this.gbCreationContrat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEspaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espaceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreationContrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateCreation;
        private System.Windows.Forms.Label lblTypeLocation;
        private System.Windows.Forms.ComboBox cmbTypeLocation;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.ComboBox cmbNoLocal;
        private System.Windows.Forms.ComboBox cmbSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrixSuggerer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.CheckBox chkBoxDateSortie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSortie;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEntree;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAppliquer;
        private BaseDonnee.DataSetVille dataSetVille;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.BindingSource typeEspaceBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.TypeEspaceTableAdapter typeEspaceTableAdapter;
        private System.Windows.Forms.BindingSource siteBindingSource1;
        private System.Windows.Forms.BindingSource localBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.LocalTableAdapter localTableAdapter;
        private System.Windows.Forms.BindingSource espaceBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.EspaceTableAdapter espaceTableAdapter;
        private System.Windows.Forms.BindingSource stationnementBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.StationnementTableAdapter stationnementTableAdapter;
        private System.Windows.Forms.ComboBox cmbNoStationnement;
        private System.Windows.Forms.Label lblNoStationnement;

    }
}