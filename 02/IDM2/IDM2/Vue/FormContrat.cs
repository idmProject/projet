using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.Vue;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Vue
{
    public partial class FormContrat : Form
    {
        private Client _client;

        private CoClient _controllerClient;
        private CoContrat _controllerContrat;
        private DossierClient _dossierClient;


        public FormContrat(Client client)
        {
            InitializeComponent();

            _client = client;
            _controllerClient = new CoClient();
            _controllerContrat = new CoContrat();
            _dossierClient = new DossierClient(_client);

            // Section Dossier Client
            GroupBox gb = _dossierClient.ObtenirVueDossierClient();
            gb.Location = new Point(0, 0);
            gb.Parent = this;
            gb.Visible = true;


            // Section Contrat
            txtDateCreation.Text = DateTime.Now.Day + " " + Tools.GetMonth(DateTime.Now.Month) + " " + DateTime.Now.Year;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBoxDateSortie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxDateSortie.Checked)
                dateTimePickerDateSortie.Enabled = true;
            else
                dateTimePickerDateSortie.Enabled = false;
        }
    }
}
