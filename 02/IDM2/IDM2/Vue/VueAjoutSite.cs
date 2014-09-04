using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDM2.BaseDonnee;
using IDM2.Controleur;
using System.Windows.Forms;
using System.Threading;


namespace IDM2.Vue
{
    public class VueAjoutSite : VueSectionAdminAbstrait
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbVille;
        private System.Windows.Forms.Label lblNewPostalCode;
        private System.Windows.Forms.Label lblNewCity;
        private System.Windows.Forms.Label lblNewDoorNumber;
        private System.Windows.Forms.Label lblNewPlaceName;
        private System.Windows.Forms.TextBox txtNouveauSiteCodePostal;
        private System.Windows.Forms.TextBox txtNouveauSiteAdresse;
        private System.Windows.Forms.TextBox txtNouveauSiteNom;



        private BaseDonnee.DataSetVille dataSetVille;
        private System.Windows.Forms.BindingSource dataSetVilleBindingSource;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter villeTableAdapter;
        private System.Windows.Forms.BindingSource villeBindingSource1;


        private bool _gotData = false;

        public VueAjoutSite()
            : base()
        {
            InitializeComponent();
        }

        protected override void btnAppliquer_Click(object sender, EventArgs e)
        {
            Site s = ObtenirDonneeSite();
            if (s != null)
                Controller.Site.AjouterSite(s);
            btnAppliquer.Enabled = false;
        }

        public void ThreadFillData()
        {
            this.villeTableAdapter.Fill(this.dataSetVille.Ville);
            // this.villeTableAdapter.FillBySaint(this.dataSetVille.Ville, "V%");
        }

        private Site ObtenirDonneeSite()
        {
            Site site = new Site();

            if (cmbVille.SelectedValue == null)
                return null;
            if (!Controller.Ville.ValiderVille((int)cmbVille.SelectedValue))
                return null;

            site.Adresse = txtNouveauSiteAdresse.Text;
            site.Alias = txtNouveauSiteNom.Text;
            site.VilleId = (int)cmbVille.SelectedValue;

            return site;
        }

        private void site_valueChange(object sender, EventArgs e)
        {
            btnAppliquer.Enabled = true;
        }

        protected override void InitializeComponent()
        {
            base.InitializeComponent();

            this.components = new System.ComponentModel.Container();
            this.cmbVille = new System.Windows.Forms.ComboBox();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVille = new IDM2.BaseDonnee.DataSetVille();
            this.villeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);

            this.lblNewPostalCode = new System.Windows.Forms.Label();
            this.lblNewCity = new System.Windows.Forms.Label();
            this.lblNewDoorNumber = new System.Windows.Forms.Label();
            this.lblNewPlaceName = new System.Windows.Forms.Label();
            this.txtNouveauSiteCodePostal = new System.Windows.Forms.TextBox();
            this.txtNouveauSiteAdresse = new System.Windows.Forms.TextBox();
            this.txtNouveauSiteNom = new System.Windows.Forms.TextBox();
            this.villeTableAdapter = new IDM2.BaseDonnee.DataSetVilleTableAdapters.VilleTableAdapter();

            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource1)).BeginInit();

            // cmbNouveauSiteVille
            // 
            //this.cmbVille.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            //this.cmbVille.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            //this.cmbVille.DisplayMember = "Ville";
            //this.cmbVille.FormattingEnabled = true;
            //this.cmbVille.Location = new System.Drawing.Point(13, 83);
            //this.cmbVille.Name = "cmbNouveauSiteVille";
            //this.cmbVille.Size = new System.Drawing.Size(120, 21);
            //this.cmbVille.TabIndex = 45;
            //this.cmbVille.ValueMember = "VilleId";
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
            this.txtNouveauSiteNom.TextChanged += new EventHandler(site_valueChange);
            // 
            // txtNouveauSiteAdresse
            // 
            this.txtNouveauSiteAdresse.Location = new System.Drawing.Point(13, 57);
            this.txtNouveauSiteAdresse.Name = "txtNouveauSiteAdresse";
            this.txtNouveauSiteAdresse.Size = new System.Drawing.Size(120, 20);
            this.txtNouveauSiteAdresse.TabIndex = 1;
            this.txtNouveauSiteAdresse.TextChanged += new EventHandler(site_valueChange);

            // 
            // txtNouveauSiteNom
            // 
            this.txtNouveauSiteNom.Location = new System.Drawing.Point(13, 31);
            this.txtNouveauSiteNom.Name = "txtNouveauSiteNom";
            this.txtNouveauSiteNom.Size = new System.Drawing.Size(120, 20);
            this.txtNouveauSiteNom.TabIndex = 0;
            this.txtNouveauSiteNom.TextChanged += new EventHandler(site_valueChange);
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
            this.cmbVille.Location = new System.Drawing.Point(13, 83);
            this.cmbVille.Name = "cmbVille";
            this.cmbVille.Size = new System.Drawing.Size(120, 20);
            this.cmbVille.TabIndex = 3;
            this.cmbVille.ValueMember = "VilleId";
            this.cmbVille.SelectedValueChanged += new EventHandler(site_valueChange);
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
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;

            this._gbVue.Controls.Add(cmbVille);
            this._gbVue.Controls.Add(lblNewPostalCode);
            this._gbVue.Controls.Add(lblNewDoorNumber);
            this._gbVue.Controls.Add(lblNewCity);
            this._gbVue.Controls.Add(lblNewPlaceName);
            this._gbVue.Controls.Add(txtNouveauSiteCodePostal);
            this._gbVue.Controls.Add(txtNouveauSiteAdresse);
            this._gbVue.Controls.Add(txtNouveauSiteNom);


            _gbVue.MouseEnter += new EventHandler(FillData);

            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource1)).EndInit();

        }

        private void FillData(object sender, EventArgs e)
        {
            if (!_gotData)
            {
                this.villeTableAdapter.Fill(this.dataSetVille.Ville);
                _gotData = true;
            }
        }
    }
}
