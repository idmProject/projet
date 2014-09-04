using IDM2.BaseDonnee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.Controleur;

namespace IDM2.Vue
{
    public partial class FormSolde : Form
    {
        private Test _test;
        private Client _client;
        private Loyer[] _loyers;
        private int _gbLastPositionY;
        private int _gbLastHeight;

        public FormSolde(Client client)
        {
            InitializeComponent();
            _client = client;
            _test = new Test();
            _loyers = Controller.Loyer.LoyersParClientDescending(_client);

            for (int i = 0; i < _loyers.Length; i++)
                this.Controls.Add(ObtenirVueLoyer(_loyers[i], i));

            this.lblDate.Text = Tools.FormatDate(_test.Date);
            this.lblMontantDue.Text = lblMontantDue.Text + " " + Tools.FormatArgent(Controller.Loyer.MontantTotalDue(_client));
            this.lblNomClient.Text = _client.Prenom + " " + _client.Nom;

        }

        public GroupBox ObtenirVueLoyer(Loyer loyer, int index)
        {
            Paiement[] paiements = Controller.Loyer.ObtenirPaiementsParLoyer(loyer);
            bool estCommenter = false;

            for (int i = 0; i < paiements.Length; i++)
                if (paiements[i].Commentaire != "")
                    estCommenter = true;

            GroupBox gbLoyer;
            Label lblCommentaire;
            TextBox txtCommentaire;
            Label lblMontantPaye;
            TextBox txtMontantPaye;
            TextBox txtMontantLoyer;
            Label lblMontant;
            Label lblDateLoyer;
            Label lblDatePaiement;

            gbLoyer = new GroupBox();
            lblDateLoyer = new Label();
            lblMontant = new Label();
            txtMontantLoyer = new TextBox();
            txtMontantPaye = new TextBox();
            lblMontantPaye = new Label();
            txtCommentaire = new TextBox();
            lblCommentaire = new Label();
            lblDatePaiement = new Label();


            // gbLoyer
            // 
            int sizeY = 186 - 73; // txtCommentaire.Height;
            if (estCommenter)
            {
                gbLoyer.Controls.Add(lblCommentaire);
                gbLoyer.Controls.Add(txtCommentaire);
                sizeY = 186;
            }
            gbLoyer.Controls.Add(lblMontantPaye);
            gbLoyer.Controls.Add(txtMontantPaye);
            gbLoyer.Controls.Add(txtMontantLoyer);
            gbLoyer.Controls.Add(lblMontant);
            gbLoyer.Controls.Add(lblDateLoyer);
            gbLoyer.Controls.Add(lblDatePaiement);
            gbLoyer.BackColor = Color.White;
            gbLoyer.Size = new System.Drawing.Size(583, sizeY);
            if (_gbLastHeight == 0 && _gbLastPositionY == 0)
                gbLoyer.Location = new System.Drawing.Point(12, 65 + gbLoyer.Height * index);
            else
                gbLoyer.Location = new System.Drawing.Point(12, _gbLastHeight + _gbLastPositionY);
            gbLoyer.Name = "gbLoyer";
            gbLoyer.TabIndex = 0;
            gbLoyer.TabStop = false;
            gbLoyer.Text = "";

            // 
            // lblDateLoyer
            // 
            lblDateLoyer.AutoSize = true;
            lblDateLoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateLoyer.Location = new System.Drawing.Point(16, 27);
            lblDateLoyer.Name = "lblDateLoyer";
            lblDateLoyer.Size = new System.Drawing.Size(96, 15);
            lblDateLoyer.TabIndex = 0;
            lblDateLoyer.Text = Tools.FormatDate(loyer.DateLoyer);
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.Location = new System.Drawing.Point(80, 54);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new System.Drawing.Size(86, 13);
            lblMontant.TabIndex = 1;
            lblMontant.Text = "Montant du loyer";
            // 
            // txtMontantLoyer
            // 
            txtMontantLoyer.Enabled = false;
            txtMontantLoyer.Location = new System.Drawing.Point(19, 51);
            txtMontantLoyer.Name = "txtMontantLoyer";
            txtMontantLoyer.Size = new System.Drawing.Size(55, 20);
            txtMontantLoyer.TabIndex = 2;
            txtMontantLoyer.Text = Tools.FormatArgent(loyer.MontantLoyer);
            // 
            // txtMontantPaye
            // 
            txtMontantPaye.Enabled = false;
            txtMontantPaye.Location = new System.Drawing.Point(19, 77);
            txtMontantPaye.Name = "txtMontantPaye";
            txtMontantPaye.Size = new System.Drawing.Size(55, 20);
            txtMontantPaye.TabIndex = 3;
            txtMontantPaye.Text = Tools.FormatArgent(loyer.MontantPayer);
            if ((bool)loyer.EstPayer)
                txtMontantPaye.BackColor = Color.LightGreen;
            else
                txtMontantPaye.BackColor = Color.LightCoral;
            // 
            // lblMontantPaye
            // 
            lblMontantPaye.AutoSize = true;
            lblMontantPaye.Location = new System.Drawing.Point(80, 80);
            lblMontantPaye.Name = "lblMontantPaye";
            lblMontantPaye.Size = new System.Drawing.Size(72, 13);
            lblMontantPaye.TabIndex = 4;
            lblMontantPaye.Text = "Montant payé";
            // 
            // lblDatePaiement
            // 
            lblDatePaiement.AutoSize = true;
            lblDatePaiement.Location = new System.Drawing.Point(170, 80);
            lblDatePaiement.Name = "lblDatePaiement";
            lblDatePaiement.Size = new System.Drawing.Size(91, 13);
            lblDatePaiement.TabIndex = 5;
            string text = "";
            for (int i = 0; i < paiements.Length; i++)
                text += Tools.FormatDateParenthese(paiements[i].DatePaiement) + " ";
            lblDatePaiement.Text = text;
            // 
            // txtCommentaire
            // 
            txtCommentaire.Enabled = false;
            txtCommentaire.Location = new System.Drawing.Point(19, 104);
            txtCommentaire.Multiline = true;
            txtCommentaire.Name = "txtCommentaire";
            txtCommentaire.Size = new System.Drawing.Size(242, 73);
            txtCommentaire.TabIndex = 6;
            string textCommentaire = "";
            for (int i = 0; i < paiements.Length; i++)
                textCommentaire += Tools.FormatDateParenthese(paiements[i].DatePaiement) + ": " + paiements[i].Commentaire + "\r\n";
            txtCommentaire.Text = textCommentaire;

            // 
            // lblCommentaire
            // 
            lblCommentaire.AutoSize = true;
            lblCommentaire.Location = new System.Drawing.Point(267, 135);
            lblCommentaire.Name = "lblCommentaire";
            lblCommentaire.Size = new System.Drawing.Size(73, 13);
            lblCommentaire.TabIndex = 7;
            lblCommentaire.Text = "Commentaires";

            _gbLastHeight = sizeY;
            _gbLastPositionY = gbLoyer.Location.Y;
            return gbLoyer;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //this.po
        }
    }
}
