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
    /// <summary>
    /// AUTEUR: J-R
    /// DESCRIPTION: Form permettant d'ajouter OU modifier un client
    /// </summary>
    public partial class AjoutClient : Form
    {
        /// <summary>
        /// AUTEUR: J-R
        /// DESCRIPTION: Classe contenant un tableau de controls utilisés pour une section d'ajout de téléphone
        /// </summary>
        private class ControlsEntreeTelephone
        {
            public Control[] Controls { get; set; }

            /// <summary>
            /// Constructeur
            /// </summary>
            /// <param name="controls">tableau de controls utilisés pour une section d'ajout de téléphone</param>
            public ControlsEntreeTelephone(Control[] controls)
            {
                Controls = controls;
            }
        }

        // CONSTANTES
        private const int PIXEL_EXT_GPTELEPHONE = 40;
        private const string NOM_TXTBOX_TELEPHONE = "txtTelephone";
        private const string NOM_TXTBOX_CONTACT = "txtContact";
        private const string NOM_TXTBOX_DESCRIPTION = "txtDescription";

        // CHAMPS
        private int _nbEntreeTelephone;
        private bool _modifierClient;
        private List<ControlsEntreeTelephone> _controlsEntreesTelephones;
        private Control[] _controlsEntreeClient;

        // PROPRIETES ACCESSIBLES
        public Client ClientOrigine { get; set; }
        public bool IsModifierClient
        {
            get { return _modifierClient; }

            // En modifiant la propriété, d'autre propriété de la Form doivent être modifié
            private set
            {
                _modifierClient = value;
                if (value)
                {
                    this.Text = "Modifier le client";
                    this.AccessibleName = "UPDATE";
                }
            }
        }
        public int NbEntreeTelephone
        {
            get { return _nbEntreeTelephone; }

            // En changeant le nombre d'entrée de téléphone au nombre désiré, tout ce qui se produit
            // en cliquant sur le bouton Moins, sera exécuté jusqu'à ce qu'on obtienne le nombre désiré
            private set
            {
                int difference = value - _nbEntreeTelephone;

                if (difference > 0)
                    for (int i = 0; i < difference; i++)
                        btnMoins.PerformClick();

                _nbEntreeTelephone = value;
            }
        }


        /// <summary>
        /// Constructeur: Construit la form, pour ajouter ou modifier un client
        /// </summary>
        /// <param name="modifierClient">TRUE: si le client doit être modifié, FALSE: si le client doit être créer</param>
        public AjoutClient(bool modifierClient)
        {
            InitializeComponent();

            IsModifierClient = modifierClient;

            DataSetVille ds = new DataSetVille();
            for (int i = 0; i < ds.Ville.Rows.Count; i++)
                cmbVille.Items.Add(ds.Ville);

            _nbEntreeTelephone = 1;

            _controlsEntreesTelephones = new List<ControlsEntreeTelephone>();
            _controlsEntreeClient = new Control[] { txtPrenom, txtNom, txtAdresse, cmbVille, cmdMethodePaiement, chkBoxCodeBarriere, txtCodeBarriere,
                chkBoxCodePorte, txtCodePorte, dateTimePickerEntree, txtCommentaire,chkBoxActif, btnPlusTel, btnMoins};

            AjouterEntreeTelephone(_nbEntreeTelephone, 5, _nbEntreeTelephone * 35);
            VerifierDisponibiliteBoutonTephone();
        }

        /// <summary>
        /// Methode qui appele les controllers pour ajouter les information du client dans la base de donnée
        /// </summary>
        private void AjouterClient()
        {
            ClientOrigine = Controller.Client.AjouterClient(ObtenirDonneesClient());
            Controller.CodeElectronique.AjouterCodesElectroniques(ObtenirDonneesCode(), ClientOrigine);
            Controller.Telephone.AjouterTelephones(ObtenirDonneesTelephones(), ClientOrigine);
        }

        /// <summary>
        /// Methode qui appele les controllers pour modifier les information du client dans la base de donnée
        /// </summary>
        private void ModifierClient()
        {
            Client client = Controller.Client.ModifierClient(this.ClientOrigine, ObtenirDonneesClient());
            Controller.CodeElectronique.ModifierCodesElectroniques(ObtenirDonneesCode().ToArray(), client);
            Controller.Telephone.ModifierTelephones(ObtenirDonneesTelephones().ToArray(), client);
        }

        
        #region LectureControls

        /// <summary>
        /// Methode qui lit dans les controls les informations et les associes à un nouveau modèle client
        /// </summary>
        /// <returns>Modèle client</returns>
        private Client ObtenirDonneesClient()
        {
            Client mc = new Client();
            mc.Actif = chkBoxActif.Checked;
            mc.Adresse = txtAdresse.Text;
            mc.DateEntree = dateTimePickerEntree.Value;
            mc.Nom = txtNom.Text;
            mc.Prenom = txtPrenom.Text;
            mc.Commentaire = txtCommentaire.Text;
            if (Controller.Ville.ValiderVille(cmbVille.Text))
                mc.VilleId = (int)cmbVille.SelectedValue;
            else
                MessageBox.Show("Ville invalide");

            //  mc.MethodePaiement = cmdMethodePaiement.SelectedText.ToString();

            return mc;
        }

        /// <summary>
        /// Methode qui crée 2 codes associés au client
        /// </summary>
        /// <returns>codes du client</returns>
        private List<CodeElectronique> ObtenirDonneesCode()
        {
            List<CodeElectronique> codes = new List<CodeElectronique>() { ObtenirDonneesCode("Porte", txtCodePorte), ObtenirDonneesCode("Barriere", txtCodeBarriere) };
            return codes;
        }

        /// <summary>
        /// Methode qui lit dans les controls les informations et les associes à un nouveau modèle CodeElectronique
        /// </summary>
        /// <param name="type">Type de Code (Barriere ou Porte)</param>
        /// <param name="txtCode">Control contenant le noCode</param>
        /// <returns>>Modèle CodeElectronique</returns>
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

        /// <summary>
        /// Methode qui lit dans les controls les informations et les associes à un nouveau modèle Telephone
        /// </summary>
        /// <returns>Modèle Telephone</returns>
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

        #endregion

        #region EcritureControls

        /// <summary>
        /// Methode utilisé pour MODIFIER un client: ajoute toutes les données du client dans les
        /// controls appropriés pour pouvoir être modifiés par l'utilisateur
        /// </summary>
        /// <param name="client">client à modifier</param>
        public void AfficherDonneeClient(Client client)
        {
            EcrireDonnesClient(client);
            EcrireDonnesCodesClient(client);
            EcrireDonneesTelephonesClient(client);
        }

        /// <summary>
        /// Ecrit les données du clients dans les Controls appropriés
        /// </summary>
        /// <param name="client">client affiché</param>
        private void EcrireDonnesClient(Client client)
        {
            txtNom.Text = client.Nom;
            txtPrenom.Text = client.Prenom;
            chkBoxActif.Checked = client.Actif;
            HandleCheckBoxClick(chkBoxActif);

            txtAdresse.Text = client.Adresse;
            txtCommentaire.Text = client.Commentaire;
            dateTimePickerEntree.Value = (DateTime)client.DateEntree;
            cmbVille.SelectedValue = client.VilleId;
        }

        /// <summary>
        /// Ecrit les données des CodesElectoniques du client dans les Controls appropriés
        /// </summary>
        /// <param name="client">client affiché</param>
        private void EcrireDonnesCodesClient(Client client)
        {

            CodeElectronique[] codes = Controller.CodeElectronique.ObtenirCodesElectroniques(client).ToArray();
            for (int i = 0; i < codes.Length; i++)
                switch (codes[i].TypeCode)
                {
                    case "Barriere":
                        if (codes[i].NoCode != 0)
                        {
                            chkBoxCodeBarriere.Checked = true;
                            txtCodeBarriere.Text = codes[i].NoCode.ToString();
                        }
                        else
                        {
                            chkBoxCodeBarriere.Checked = false;
                            txtCodeBarriere.Enabled = false;
                        }
                        break;

                    case "Porte":
                        if (codes[i].NoCode != 0)
                        {
                            chkBoxCodePorte.Checked = true;
                            txtCodePorte.Text = codes[i].NoCode.ToString();
                        }
                        else
                        {
                            chkBoxCodePorte.Checked = false;
                            txtCodePorte.Enabled = false;
                        }
                        break;

                    default:
                        throw new Exception("Aucun type de code valide");
                }
        }

        /// <summary>
        /// Ecrit les données des Téléphones du clients dans les Controls appropriés
        /// </summary>
        /// <param name="client">client affiché</param>
        private void EcrireDonneesTelephonesClient(Client client)
        {
            Telephone[] tels = Controller.Telephone.ObtenirTelephones(client);
            int nbTel = tels.Length;
            short pos = 0;

            for (int i = 1; i <= nbTel; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TextBox t = (TextBox)gbTelephone.Controls[NOM_TXTBOX_TELEPHONE + i.ToString() + j.ToString()];
                    if (j != 2)
                    {
                        t.Text = tels[i - 1].NoTel.Substring(pos, 3);
                        pos += 3;
                    }
                    else
                    {
                        t.Text = tels[i - 1].NoTel.Substring(pos, 4);
                        pos = 0;
                    }
                }

                TextBox contact = (TextBox)gbTelephone.Controls[NOM_TXTBOX_CONTACT + i.ToString()];
                contact.Text = tels[i - 1].Contact;

                TextBox description = (TextBox)gbTelephone.Controls[NOM_TXTBOX_DESCRIPTION + i.ToString()];
                description.Text = tels[i - 1].Description;

                if (i < nbTel)
                    btnPlusTel.PerformClick();
            }
        }

        #endregion

        #region CreationControls

        /// <summary>
        /// Ajoute une section d'entrée pour la création de téléphone d'un client contenant tous les Controls nécessaire
        /// </summary>
        /// <param name="n">Numéro de la section</param>
        /// <param name="x">Position en X de la section</param>
        /// <param name="y">Position en Y de la section</param>
        /// <returns>Tableau contenant tous les controls de la nouvelle section</returns>
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

        /// <summary>
        /// Détermine si une entrée de téléphone peut être ajouté ou supprimé
        /// </summary>
        private void VerifierDisponibiliteBoutonTephone()
        {
            switch (_nbEntreeTelephone)
            {
                case 1:
                    btnMoins.Enabled = false;
                    break;
                case 8:
                    btnPlusTel.Enabled = false;
                    break;
                default:
                    btnPlusTel.Enabled = true;
                    btnMoins.Enabled = true;
                    break;
            }
        }


        #endregion



        #region FormEvent

        /// <summary>
        /// Methode qui ajoute les données du comboBox Villes pendant le load de la form
        /// </summary>
        private void AjoutClient_Load(object sender, EventArgs e)
        {
            this.villeTableAdapter.Fill(this.dataSetVille.Ville);
        }

        #endregion

        #region ButtonEvent

        /// <summary>
        /// Permet d'ajouter ou modifier un client dans la base de donnée sans fermer la Form
        /// </summary>
        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            btnAppliquer.Enabled = false;

            if (IsModifierClient)
                ModifierClient();
            else
            {
                AjouterClient();
                for (int i = 0; i < _controlsEntreeClient.Length; i++)
                    _controlsEntreeClient[i].Enabled = false;

                for (int i = 0; i < _controlsEntreesTelephones.Count; i++)
                    for (int j = 0; j < _controlsEntreesTelephones[i].Controls.Length; j++)
                        _controlsEntreesTelephones[i].Controls[j].Enabled = false;

                Button btnModifierInfoClient = new Button();
                btnModifierInfoClient.Size = new Size(btnAppliquer.Location.X + btnAppliquer.Size.Width - btnOk.Location.X, btnOk.Size.Height);
                btnModifierInfoClient.Name = "btnModifierInfoClient";
                btnModifierInfoClient.Text = "Modifier les informations du client";
                btnModifierInfoClient.Location = new Point(btnOk.Location.X, btnOk.Location.Y - btnModifierInfoClient.Size.Height - 30);
                btnModifierInfoClient.Visible = true;
                btnModifierInfoClient.Enabled = true;
                groupBoxAjoutClient.Controls.Add(btnModifierInfoClient);
                btnModifierInfoClient.Click += new EventHandler(btnModifierInfoClient_click);

                Button btnAjouterNouveauClient = new Button();
                btnAjouterNouveauClient.Size = new Size(btnAppliquer.Location.X + btnAppliquer.Size.Width - btnOk.Location.X, btnOk.Size.Height);
                btnAjouterNouveauClient.Name = "btnAjouterNouveauClient";
                btnAjouterNouveauClient.Text = "Ajouter un nouveau client";
                btnAjouterNouveauClient.Location = new Point(btnOk.Location.X, btnOk.Location.Y - btnAjouterNouveauClient.Size.Height - 60);
                btnAjouterNouveauClient.Visible = true;
                btnAjouterNouveauClient.Enabled = true;
                groupBoxAjoutClient.Controls.Add(btnAjouterNouveauClient);
                btnAjouterNouveauClient.Click += new EventHandler(btnAjouterNouveauClient_click);
            }
        }

        /// <summary>
        /// Permet de modifier les informations du client qui vient tout juste d'être ajouter à la BD
        /// </summary>
        private void btnModifierInfoClient_click(object sender, EventArgs e)
        {
            btnAppliquer.Enabled = true;
            groupBoxAjoutClient.Controls.Remove(groupBoxAjoutClient.Controls["btnModifierInfoClient"]);
            groupBoxAjoutClient.Controls.Remove(groupBoxAjoutClient.Controls["btnAjouterNouveauClient"]);

            IsModifierClient = true;

            for (int i = 0; i < _controlsEntreeClient.Length; i++)
                _controlsEntreeClient[i].Enabled = true;

            for (int i = 0; i < _controlsEntreesTelephones.Count; i++)
                for (int j = 0; j < _controlsEntreesTelephones[i].Controls.Length; j++)
                    _controlsEntreesTelephones[i].Controls[j].Enabled = true;


            AfficherDonneeClient(ClientOrigine);
        }

        /// <summary>
        /// Permet d'ajouter un nouveau client, réinitialise tous les controls de la Form
        /// </summary>
        private void btnAjouterNouveauClient_click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();

            _nbEntreeTelephone = 1;
            AjouterEntreeTelephone(_nbEntreeTelephone, 5, _nbEntreeTelephone * 35);
            VerifierDisponibiliteBoutonTephone();

            //ResetAllControls(this);
            //ResetAllControls(gbTelephone);
            //ResetAllControls(groupBoxAjoutClient);
            //NbEntreeTelephone = 1;
        }

        /// <summary>
        /// Permet d'ajouter une nouvelle section d'ajout de téléphone
        /// </summary>
        private void btnPlusTel_Click(object sender, EventArgs e)
        {
            if (_nbEntreeTelephone < 9)
            {
                _nbEntreeTelephone++;
                gbTelephone.Size = new Size(gbTelephone.Size.Width, gbTelephone.Size.Height + PIXEL_EXT_GPTELEPHONE);

                AjouterEntreeTelephone(_nbEntreeTelephone, 5, _nbEntreeTelephone * 35);
            }

            VerifierDisponibiliteBoutonTephone();
        }

        /// <summary>
        /// Permet de retirer une section d'ajout de téléphone
        /// </summary>
        private void btnMoins_Click(object sender, EventArgs e)
        {
            // gbTelephone.Controls.Remove
            if (_controlsEntreesTelephones.Count > 1)
            {
                for (int i = 0; i < _controlsEntreesTelephones.Last().Controls.Length; i++)
                {
                    gbTelephone.Controls.Remove(_controlsEntreesTelephones.Last().Controls[i]);
                }
                _controlsEntreesTelephones.RemoveAt(_controlsEntreesTelephones.Count - 1);
                _nbEntreeTelephone--;
                gbTelephone.Size = new Size(gbTelephone.Size.Width, gbTelephone.Size.Height - PIXEL_EXT_GPTELEPHONE);
            }

            VerifierDisponibiliteBoutonTephone();
        }

        /// <summary>
        /// Ferme la Form sans enregistrer
        /// </summary>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// Ferme la Form en enregistrant les informations du client
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnAppliquer.Enabled)
            {
                if (IsModifierClient)
                    ModifierClient();
                else
                    AjouterClient();
            }

            this.Close();

        }

        #endregion

        #region CheckBoxEvent

        private void chkBoxCodeBarriere_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCodeBarriere.Checked)
                txtCodeBarriere.Enabled = true;
            else
                txtCodeBarriere.Enabled = false;

        }

        private void chkBoxCodePorte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCodePorte.Checked)
                txtCodePorte.Enabled = true;
            else
                txtCodePorte.Enabled = false;
        }

        private void chkBoxActif_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxClick((CheckBox)sender);
        }

        private void HandleCheckBoxClick(CheckBox sender)
        {
            if (chkBoxActif.Checked)
                chkBoxActif.BackColor = Color.PaleGreen;
            else
                chkBoxActif.BackColor = Color.LightSalmon;
        }

        #endregion

        #region TextBoxEvent

        /// <summary>
        /// Methode changeant automatiquement le focus d'un textbox dans la section d'ajout de téléphone
        /// </summary>
        /// <param name="sender">Textbox ayant présentement le focus</param>
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
       
        #endregion
    }
}
