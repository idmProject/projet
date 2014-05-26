using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using IDM2.Controleur;
using IDM2.BaseDonnee;


namespace IDM2
{
    public partial class AjoutClient : Form
    {
        private class ControlsEntreeTelephone
        {
            public Control[] Controls { get; set; }
            public ControlsEntreeTelephone(Control[] controls)
            {
                Controls = controls;
            }
        }

        private CoClient _controllerClient;
        private CoTelephone _controllerTelephone;
        private CoCodeElectronique _controllerCode;
        private CoVille _controllerVille;
        private int _nbEntreeTelephone;
        private List<ControlsEntreeTelephone> _controlsEntreesTelephones;
        private const int PIXEL_EXT_GPTELEPHONE = 40;
        private const string NOM_TXTBOX_TELEPHONE = "txtTelephone";
        private const string NOM_TXTBOX_CONTACT = "txtContact";
        private const string NOM_TXTBOX_DESCRIPTION = "txtDescription";

        public Client ClientOrigine { get; set; }

        public AjoutClient()
        {
            InitializeComponent();
            DataSetVille ds = new DataSetVille();
            for (int i = 0; i < ds.Ville.Rows.Count; i++)
                cmbVille.Items.Add(ds.Ville);

            _controllerClient = new CoClient();
            _controllerTelephone = new CoTelephone();
            _controllerCode = new CoCodeElectronique();
            _controllerVille = new CoVille();
            _nbEntreeTelephone = 1;
            _controlsEntreesTelephones = new List<ControlsEntreeTelephone>();
            AjouterEntreeTelephone(_nbEntreeTelephone, 5, _nbEntreeTelephone * 35);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox))
                throw new Exception("txt_TextChanged est un Event pour TextBox");


            TextBox t = (TextBox)sender;


            #region CHANGEMENT_FOCUS_TELEPHONE

            string caFin = t.Name.ElementAt(t.Name.Length - 1).ToString();

            if (t.Name.Contains(NOM_TXTBOX_TELEPHONE) && caFin != (2).ToString() && t.Text.Length == 3)
            {
                string name = "";
                for (int i = 0; i < t.Name.Length - 1; i++)
                    name += t.Name[i];
                string ta = t.Name.ElementAt(t.Name.Length - 1).ToString();
                int fin = Convert.ToInt32(ta) + 1;

                name += fin.ToString();

                gbTelephone.Controls[name].Focus();
            }
            else if (t.Name.Contains(NOM_TXTBOX_TELEPHONE) && caFin == (2).ToString() && t.Text.Length == 4)
            {
                gbTelephone.Controls[NOM_TXTBOX_CONTACT + t.Name.ElementAt(t.Name.Length - 2).ToString()].Focus();
            }

            #endregion

        }

        public void AjouterDonneeClient(Client client)
        {
            txtNom.Text = client.Nom;
            txtPrenom.Text = client.Prenom;
            chkBoxActif.Checked = client.Actif;
            txtAdresse.Text = client.Adresse;
            txtCommentaire.Text = client.Commentaire;
        }

        private void AjoutClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSetVille.Ville'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.villeTableAdapter.Fill(this.dataSetVille.Ville);
            // TODO: cette ligne de code charge les données dans la table 'dataSetIDM.Porte'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.porteTableAdapter.Fill(this.dataSetIDM.Porte);
            // TODO: cette ligne de code charge les données dans la table 'dataSetIDM.MethodePaiement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            // this.methodePaiementTableAdapter.Fill(this.dataSetIDM.MethodePaiement);

        }

        private void AjouterClient()
        {
            Client client = _controllerClient.AjouterClient(ObtenirDonneesClient());
            _controllerCode.AjouterCodesElectroniques(ObtenirDonneesCode(), client);
            _controllerTelephone.AjouterTelephones(ObtenirDonneesTelephones(), client);
        }

        private Client ObtenirDonneesClient()
        {
            Client mc = new Client();
            mc.Actif = chkBoxActif.Checked;
            mc.Adresse = txtAdresse.Text;
            mc.DateEntree = dateTimePickerEntree.Value;
            mc.Nom = txtNom.Text;
            mc.Prenom = txtPrenom.Text;
            mc.Commentaire = txtCommentaire.Text;
            if (_controllerVille.ValiderVille(cmbVille.Text))
                mc.VilleId = (int)cmbVille.SelectedValue;
            else
                MessageBox.Show("Ville invalide");

          //  mc.MethodePaiement = cmdMethodePaiement.SelectedText.ToString();

            return mc;
        }

        private List<CodeElectronique> ObtenirDonneesCode()
        {
            List<CodeElectronique> codes = new List<CodeElectronique>() { ObtenirDonneesCode("Porte", txtCodePorte), ObtenirDonneesCode("Barriere", txtCodeBarriere) };
            return codes;
        }

        private CodeElectronique ObtenirDonneesCode(string type, TextBox txtCode)
        {
            CodeElectronique code = new CodeElectronique();
            code.TypeCode = type;
            try
            {
                code.NoCode = int.Parse(txtCode.Text);
            }
            catch
            {
                code.NoCode = 00000;
            }
            return code;
        }

        private List<Telephone> ObtenirDonneesTelephones()
        {
            List<Telephone> tels = new List<Telephone>();

            for (int i = 0; i < _controlsEntreesTelephones.Count; i++)
            {
                Telephone tel = new Telephone();
                string noTel = "";

                // (i + 1) car _nbEntreeTelephone start a 1 pour determiner le nom des textbox
                for (int j = 0; j < 3; j++)
                    noTel += _controlsEntreesTelephones[i].Controls.FirstOrDefault(c => c.Name == NOM_TXTBOX_TELEPHONE + (i + 1).ToString() + j.ToString()).Text;

                tel.NoTel = noTel;
                tel.Contact = _controlsEntreesTelephones[i].Controls.FirstOrDefault(c => c.Name == NOM_TXTBOX_CONTACT + (i + 1).ToString()).Text;
                tel.Description = _controlsEntreesTelephones[i].Controls.FirstOrDefault(c => c.Name == NOM_TXTBOX_DESCRIPTION + (i + 1).ToString()).Text;

                tels.Add(tel);
            }

            return tels;
        }

        private void UpdateCustomer()
        {
            _controllerClient.ModifierClient(this.ClientOrigine, ObtenirDonneesClient());
        }

        private Control[] AjouterEntreeTelephone(int n, int x, int y)
        {
            int xt = x;
            int yt = y;
            List<Control> controls = new List<Control>();
            // Ajout des entrees de no
            for (int i = 0; i < 3; i++)
            {
                TextBox txt = new TextBox();
                txt.Name = NOM_TXTBOX_TELEPHONE + n.ToString() + i.ToString();
                txt.Visible = true;
                txt.Size = new Size(36, 20);
                txt.Location = new Point(xt, yt);
                txt.TextChanged += new EventHandler(txt_TextChanged);
                gbTelephone.Controls.Add(txt);
                xt += 42;
                controls.Add(txt);
            }

            Label lblTelephone = new Label();
            lblTelephone.Name = "lblTelephone" + n.ToString();
            lblTelephone.Size = new Size(120, 13);
            lblTelephone.Location = new Point(x, yt - 13);
            lblTelephone.Text = "No. Tel.";
            lblTelephone.Visible = true;
            lblTelephone.Parent = groupBoxAjoutClient;
            gbTelephone.Controls.Add(lblTelephone);
            controls.Add(lblTelephone);

            xt += 12;

            // Contact
            TextBox txtContact = new TextBox();
            txtContact.Name = NOM_TXTBOX_CONTACT + n.ToString();
            txtContact.Visible = true;
            txtContact.Size = new Size(120, 20);
            txtContact.Location = new Point(xt, yt);
            gbTelephone.Controls.Add(txtContact);
            controls.Add(txtContact);

            Label lblContact = new Label();
            lblContact.Name = "lblContact" + n.ToString();
            lblContact.Size = new Size(120, 13);
            lblContact.Location = new Point(txtContact.Location.X, yt - 13);
            lblContact.Text = "Contact";
            lblContact.Visible = true;
            lblContact.Parent = groupBoxAjoutClient;
            gbTelephone.Controls.Add(lblContact);
            controls.Add(lblContact);

            xt += 12 + txtContact.Width;

            // Description
            TextBox txtDescription = new TextBox();
            txtDescription.Name = NOM_TXTBOX_DESCRIPTION + n.ToString();
            txtDescription.Visible = true;
            txtDescription.Size = new Size(120, 20);
            txtDescription.Location = new Point(xt, yt);
            gbTelephone.Controls.Add(txtDescription);
            controls.Add(txtDescription);

            Label lblDescription = new Label();
            lblDescription.Name = "lblDescription" + n.ToString();
            lblDescription.Size = new Size(120, 13);
            lblDescription.Location = new Point(txtDescription.Location.X, yt - 13);
            lblDescription.Text = "Description";
            lblDescription.Visible = true;
            gbTelephone.Controls.Add(lblDescription);
            controls.Add(lblDescription);


            ControlsEntreeTelephone ce = new ControlsEntreeTelephone(controls.ToArray());
            _controlsEntreesTelephones.Add(ce);
            return controls.ToArray();
        }

        #region ButtonEvent
        //#######################  ButtonEvent  ################################

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            if (this.AccessibleName == "UPDATE")
                UpdateCustomer();

            if (this.AccessibleName == "INSERT")
                AjouterClient();


        }

        private void btnPlusTel_Click(object sender, EventArgs e)
        {
            if (_nbEntreeTelephone < 9)
            {
                _nbEntreeTelephone++;
                gbTelephone.Size = new Size(gbTelephone.Size.Width, gbTelephone.Size.Height + PIXEL_EXT_GPTELEPHONE);

               AjouterEntreeTelephone(_nbEntreeTelephone, 5, _nbEntreeTelephone * 35);
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
           // gbTelephone.Controls.Remove
            if (_controlsEntreesTelephones.Count >= 1)
            {
                for (int i = 0; i < _controlsEntreesTelephones.Last().Controls.Length; i++)
                {
                    gbTelephone.Controls.Remove(_controlsEntreesTelephones.Last().Controls[i]);
                }
                _controlsEntreesTelephones.RemoveAt(_controlsEntreesTelephones.Count - 1);
                _nbEntreeTelephone--;
                gbTelephone.Size = new Size(gbTelephone.Size.Width, gbTelephone.Size.Height - PIXEL_EXT_GPTELEPHONE);

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.AccessibleName == "UPDATE")
                UpdateCustomer();

            if (this.AccessibleName == "INSERT")
                AjouterClient();

            this.Close();

        }

        #endregion
    }
}
