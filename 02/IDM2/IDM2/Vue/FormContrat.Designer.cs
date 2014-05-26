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
            this.groupBoxContrat = new System.Windows.Forms.GroupBox();
            this.cmbSite = new System.Windows.Forms.ComboBox();
            this.cmbNoLocal = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.cmbTypeLocation = new System.Windows.Forms.ComboBox();
            this.lblTypeLocation = new System.Windows.Forms.Label();
            this.cmbNoStationnement = new System.Windows.Forms.ComboBox();
            this.lblNoStationnement = new System.Windows.Forms.Label();
            this.txtDateCreation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateEntree = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateSortie = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBoxDateSortie = new System.Windows.Forms.CheckBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrixSuggerer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.groupBoxContrat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxContrat
            // 
            this.groupBoxContrat.Controls.Add(this.label4);
            this.groupBoxContrat.Controls.Add(this.txtPrixSuggerer);
            this.groupBoxContrat.Controls.Add(this.label3);
            this.groupBoxContrat.Controls.Add(this.txtPrix);
            this.groupBoxContrat.Controls.Add(this.chkBoxDateSortie);
            this.groupBoxContrat.Controls.Add(this.label2);
            this.groupBoxContrat.Controls.Add(this.dateTimePickerDateSortie);
            this.groupBoxContrat.Controls.Add(this.dateTimePickerDateEntree);
            this.groupBoxContrat.Controls.Add(this.label1);
            this.groupBoxContrat.Controls.Add(this.txtDateCreation);
            this.groupBoxContrat.Controls.Add(this.lblNoStationnement);
            this.groupBoxContrat.Controls.Add(this.cmbNoStationnement);
            this.groupBoxContrat.Controls.Add(this.lblTypeLocation);
            this.groupBoxContrat.Controls.Add(this.cmbTypeLocation);
            this.groupBoxContrat.Controls.Add(this.lblLocal);
            this.groupBoxContrat.Controls.Add(this.lblSite);
            this.groupBoxContrat.Controls.Add(this.cmbNoLocal);
            this.groupBoxContrat.Controls.Add(this.cmbSite);
            this.groupBoxContrat.Location = new System.Drawing.Point(315, 0);
            this.groupBoxContrat.Name = "groupBoxContrat";
            this.groupBoxContrat.Size = new System.Drawing.Size(300, 306);
            this.groupBoxContrat.TabIndex = 0;
            this.groupBoxContrat.TabStop = false;
            this.groupBoxContrat.Text = "Création d\'un contrat";
            // 
            // cmbSite
            // 
            this.cmbSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSite.FormattingEnabled = true;
            this.cmbSite.Location = new System.Drawing.Point(6, 37);
            this.cmbSite.Name = "cmbSite";
            this.cmbSite.Size = new System.Drawing.Size(121, 21);
            this.cmbSite.TabIndex = 0;
            // 
            // cmbNoLocal
            // 
            this.cmbNoLocal.Enabled = false;
            this.cmbNoLocal.FormattingEnabled = true;
            this.cmbNoLocal.Location = new System.Drawing.Point(6, 91);
            this.cmbNoLocal.Name = "cmbNoLocal";
            this.cmbNoLocal.Size = new System.Drawing.Size(121, 21);
            this.cmbNoLocal.TabIndex = 1;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(133, 40);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 2;
            this.lblSite.Text = "Site";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(133, 94);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(84, 13);
            this.lblLocal.TabIndex = 3;
            this.lblLocal.Text = "Numéro de local";
            // 
            // cmbTypeLocation
            // 
            this.cmbTypeLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeLocation.FormattingEnabled = true;
            this.cmbTypeLocation.Location = new System.Drawing.Point(6, 64);
            this.cmbTypeLocation.Name = "cmbTypeLocation";
            this.cmbTypeLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeLocation.TabIndex = 4;
            // 
            // lblTypeLocation
            // 
            this.lblTypeLocation.AutoSize = true;
            this.lblTypeLocation.Location = new System.Drawing.Point(133, 67);
            this.lblTypeLocation.Name = "lblTypeLocation";
            this.lblTypeLocation.Size = new System.Drawing.Size(86, 13);
            this.lblTypeLocation.TabIndex = 5;
            this.lblTypeLocation.Text = "Type de location";
            // 
            // cmbNoStationnement
            // 
            this.cmbNoStationnement.Enabled = false;
            this.cmbNoStationnement.FormattingEnabled = true;
            this.cmbNoStationnement.Location = new System.Drawing.Point(6, 118);
            this.cmbNoStationnement.Name = "cmbNoStationnement";
            this.cmbNoStationnement.Size = new System.Drawing.Size(121, 21);
            this.cmbNoStationnement.TabIndex = 6;
            // 
            // lblNoStationnement
            // 
            this.lblNoStationnement.AutoSize = true;
            this.lblNoStationnement.Location = new System.Drawing.Point(133, 121);
            this.lblNoStationnement.Name = "lblNoStationnement";
            this.lblNoStationnement.Size = new System.Drawing.Size(128, 13);
            this.lblNoStationnement.TabIndex = 7;
            this.lblNoStationnement.Text = "Numéro de stationnement";
            // 
            // txtDateCreation
            // 
            this.txtDateCreation.Enabled = false;
            this.txtDateCreation.Location = new System.Drawing.Point(7, 146);
            this.txtDateCreation.Name = "txtDateCreation";
            this.txtDateCreation.Size = new System.Drawing.Size(120, 20);
            this.txtDateCreation.TabIndex = 8;
            this.txtDateCreation.Text = "DateAujourdhui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date de création du contrat";
            // 
            // dateTimePickerDateEntree
            // 
            this.dateTimePickerDateEntree.Location = new System.Drawing.Point(7, 172);
            this.dateTimePickerDateEntree.Name = "dateTimePickerDateEntree";
            this.dateTimePickerDateEntree.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDateEntree.TabIndex = 10;
            // 
            // dateTimePickerDateSortie
            // 
            this.dateTimePickerDateSortie.Enabled = false;
            this.dateTimePickerDateSortie.Location = new System.Drawing.Point(6, 198);
            this.dateTimePickerDateSortie.Name = "dateTimePickerDateSortie";
            this.dateTimePickerDateSortie.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDateSortie.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date d\'entrée";
            // 
            // chkBoxDateSortie
            // 
            this.chkBoxDateSortie.AutoSize = true;
            this.chkBoxDateSortie.Location = new System.Drawing.Point(136, 198);
            this.chkBoxDateSortie.Name = "chkBoxDateSortie";
            this.chkBoxDateSortie.Size = new System.Drawing.Size(92, 17);
            this.chkBoxDateSortie.TabIndex = 14;
            this.chkBoxDateSortie.Text = "Date de sortie";
            this.chkBoxDateSortie.UseVisualStyleBackColor = true;
            this.chkBoxDateSortie.CheckedChanged += new System.EventHandler(this.chkBoxDateSortie_CheckedChanged);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(6, 242);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(92, 20);
            this.txtPrix.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Prix";
            // 
            // txtPrixSuggerer
            // 
            this.txtPrixSuggerer.Enabled = false;
            this.txtPrixSuggerer.Location = new System.Drawing.Point(7, 269);
            this.txtPrixSuggerer.Name = "txtPrixSuggerer";
            this.txtPrixSuggerer.Size = new System.Drawing.Size(91, 20);
            this.txtPrixSuggerer.TabIndex = 17;
            this.txtPrixSuggerer.Text = "PrixSuggéré";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Prix suggéré";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(315, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info du local!";
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
            // 
            // FormContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 660);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxContrat);
            this.Name = "FormContrat";
            this.Text = "FormContrat";
            this.groupBoxContrat.ResumeLayout(false);
            this.groupBoxContrat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateCreation;
        private System.Windows.Forms.Label lblNoStationnement;
        private System.Windows.Forms.ComboBox cmbNoStationnement;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAppliquer;

    }
}