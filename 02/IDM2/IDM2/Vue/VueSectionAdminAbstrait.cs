using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Vue
{
    public abstract class VueSectionAdminAbstrait
    {
        protected const string BTN_APPLIQUER_NAME = "btnAppliquer";

        protected System.Windows.Forms.Button btnAppliquer;
        protected System.Windows.Forms.Button btnAnnuler;
        protected System.Windows.Forms.Button btnOk;
       
        protected GroupBox _gbVue;
        
        protected Taxe _tpsActuel;
        protected Taxe _tvqActuel;
        protected bool _modification;

        protected GroupBox GbVue { get { return _gbVue; } }

        protected  VueSectionAdminAbstrait()
        {
            _gbVue = new GroupBox();
            _gbVue.Size = new Size(364, 400);


            _tpsActuel = DonneeMemoire.Tps;
            _tvqActuel = DonneeMemoire.Tvq;
            _modification = false;

        }

        protected virtual void InitializeComponent()
        {
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(197, 350);
            this.btnAppliquer.Name = BTN_APPLIQUER_NAME;
            this.btnAppliquer.Size = new System.Drawing.Size(75, 23);
            this.btnAppliquer.TabIndex = 8;
            this.btnAppliquer.Text = "Appliquer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            this.btnAppliquer.Enabled = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(116, 350);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(35, 350);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);


            _gbVue.Controls.Add(btnAppliquer);
            _gbVue.Controls.Add(btnAnnuler);
            _gbVue.Controls.Add(btnOk);
        }

        public GroupBox ObtenirVue()
        {
            return _gbVue;
        }

        protected abstract void btnAppliquer_Click(object sender, EventArgs e);

        protected void btnAnnuler_Click(object sender, EventArgs e)
        {
            _gbVue.Dispose();
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            btnAppliquer.PerformClick();
            _gbVue.Dispose();
        }

        protected void EnabledButton(Button sender, bool enabled)
        {
            _gbVue.Controls[sender.Name].Enabled = enabled;
        }
    }
}
