namespace IDM2.Vue
{
    partial class FormSolde
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
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblMontantDue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(13, 13);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(74, 15);
            this.lblNomClient.TabIndex = 0;
            this.lblNomClient.Text = "NomClient";
            // 
            // lblMontantDue
            // 
            this.lblMontantDue.AutoSize = true;
            this.lblMontantDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantDue.Location = new System.Drawing.Point(13, 38);
            this.lblMontantDue.Name = "lblMontantDue";
            this.lblMontantDue.Size = new System.Drawing.Size(93, 15);
            this.lblMontantDue.TabIndex = 1;
            this.lblMontantDue.Text = "Montant Due:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(764, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "DateAujourdhui";
            // 
            // FormSolde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(896, 357);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMontantDue);
            this.Controls.Add(this.lblNomClient);
            this.Name = "FormSolde";
            this.Text = "FormSolde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblMontantDue;
        private System.Windows.Forms.Label lblDate;


    }
}