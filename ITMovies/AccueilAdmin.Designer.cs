namespace ITMovies
{
    partial class AccueilAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.changerMdpBtn = new System.Windows.Forms.Button();
            this.gererLesAdminsBtn = new System.Windows.Forms.Button();
            this.afficherHistoriqueBtn = new System.Windows.Forms.Button();
            this.gererLesClientsBtn = new System.Windows.Forms.Button();
            this.gererLesFilmsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changerMdpBtn);
            this.panel1.Controls.Add(this.gererLesAdminsBtn);
            this.panel1.Controls.Add(this.afficherHistoriqueBtn);
            this.panel1.Controls.Add(this.gererLesClientsBtn);
            this.panel1.Controls.Add(this.gererLesFilmsBtn);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 579);
            this.panel1.TabIndex = 0;
            // 
            // changerMdpBtn
            // 
            this.changerMdpBtn.Location = new System.Drawing.Point(419, 395);
            this.changerMdpBtn.Name = "changerMdpBtn";
            this.changerMdpBtn.Size = new System.Drawing.Size(107, 46);
            this.changerMdpBtn.TabIndex = 4;
            this.changerMdpBtn.Text = "Changer son mot de passe";
            this.changerMdpBtn.UseVisualStyleBackColor = true;
            // 
            // gererLesAdminsBtn
            // 
            this.gererLesAdminsBtn.Enabled = false;
            this.gererLesAdminsBtn.Location = new System.Drawing.Point(419, 328);
            this.gererLesAdminsBtn.Name = "gererLesAdminsBtn";
            this.gererLesAdminsBtn.Size = new System.Drawing.Size(107, 46);
            this.gererLesAdminsBtn.TabIndex = 3;
            this.gererLesAdminsBtn.Text = "Gerer les administrateurs";
            this.gererLesAdminsBtn.UseVisualStyleBackColor = true;
            // 
            // afficherHistoriqueBtn
            // 
            this.afficherHistoriqueBtn.Location = new System.Drawing.Point(419, 260);
            this.afficherHistoriqueBtn.Name = "afficherHistoriqueBtn";
            this.afficherHistoriqueBtn.Size = new System.Drawing.Size(107, 46);
            this.afficherHistoriqueBtn.TabIndex = 2;
            this.afficherHistoriqueBtn.Text = "Afficher l\'historique";
            this.afficherHistoriqueBtn.UseVisualStyleBackColor = true;
            // 
            // gererLesClientsBtn
            // 
            this.gererLesClientsBtn.Location = new System.Drawing.Point(419, 195);
            this.gererLesClientsBtn.Name = "gererLesClientsBtn";
            this.gererLesClientsBtn.Size = new System.Drawing.Size(107, 46);
            this.gererLesClientsBtn.TabIndex = 1;
            this.gererLesClientsBtn.Text = "Gerer les clients";
            this.gererLesClientsBtn.UseVisualStyleBackColor = true;
            // 
            // gererLesFilmsBtn
            // 
            this.gererLesFilmsBtn.Location = new System.Drawing.Point(419, 129);
            this.gererLesFilmsBtn.Name = "gererLesFilmsBtn";
            this.gererLesFilmsBtn.Size = new System.Drawing.Size(107, 46);
            this.gererLesFilmsBtn.TabIndex = 0;
            this.gererLesFilmsBtn.Text = "Gerer les films";
            this.gererLesFilmsBtn.UseVisualStyleBackColor = true;
            // 
            // AccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 604);
            this.Controls.Add(this.panel1);
            this.Name = "AccueilAdmin";
            this.Text = "AccueilAdmin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changerMdpBtn;
        private System.Windows.Forms.Button gererLesAdminsBtn;
        private System.Windows.Forms.Button afficherHistoriqueBtn;
        private System.Windows.Forms.Button gererLesClientsBtn;
        private System.Windows.Forms.Button gererLesFilmsBtn;
    }
}