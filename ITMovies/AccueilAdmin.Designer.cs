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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.changerMdpBtn = new System.Windows.Forms.Button();
            this.gererLesAdminsBtn = new System.Windows.Forms.Button();
            this.afficherHistoriqueBtn = new System.Windows.Forms.Button();
            this.gererLesClientsBtn = new System.Windows.Forms.Button();
            this.gererLesFilms = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BackgroundImage = global::ITMovies.Properties.Resources.IT__3_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.changerMdpBtn);
            this.panel1.Controls.Add(this.gererLesAdminsBtn);
            this.panel1.Controls.Add(this.afficherHistoriqueBtn);
            this.panel1.Controls.Add(this.gererLesClientsBtn);
            this.panel1.Controls.Add(this.gererLesFilms);
            this.panel1.Location = new System.Drawing.Point(-55, -36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 672);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(612, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // changerMdpBtn
            // 
            this.changerMdpBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.changerMdpBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changerMdpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.changerMdpBtn.Location = new System.Drawing.Point(552, 440);
            this.changerMdpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changerMdpBtn.Name = "changerMdpBtn";
            this.changerMdpBtn.Size = new System.Drawing.Size(260, 46);
            this.changerMdpBtn.TabIndex = 4;
            this.changerMdpBtn.Text = "Change your password";
            this.changerMdpBtn.UseVisualStyleBackColor = false;
            this.changerMdpBtn.Click += new System.EventHandler(this.changerMdpBtn_Click);
            // 
            // gererLesAdminsBtn
            // 
            this.gererLesAdminsBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.gererLesAdminsBtn.Enabled = false;
            this.gererLesAdminsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gererLesAdminsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.gererLesAdminsBtn.Location = new System.Drawing.Point(552, 372);
            this.gererLesAdminsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gererLesAdminsBtn.Name = "gererLesAdminsBtn";
            this.gererLesAdminsBtn.Size = new System.Drawing.Size(260, 46);
            this.gererLesAdminsBtn.TabIndex = 3;
            this.gererLesAdminsBtn.Text = "Manage administrators";
            this.gererLesAdminsBtn.UseVisualStyleBackColor = false;
            this.gererLesAdminsBtn.Click += new System.EventHandler(this.gererLesAdminsBtn_Click);
            // 
            // afficherHistoriqueBtn
            // 
            this.afficherHistoriqueBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.afficherHistoriqueBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficherHistoriqueBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.afficherHistoriqueBtn.Location = new System.Drawing.Point(552, 296);
            this.afficherHistoriqueBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.afficherHistoriqueBtn.Name = "afficherHistoriqueBtn";
            this.afficherHistoriqueBtn.Size = new System.Drawing.Size(260, 46);
            this.afficherHistoriqueBtn.TabIndex = 2;
            this.afficherHistoriqueBtn.Text = "Show history";
            this.afficherHistoriqueBtn.UseVisualStyleBackColor = false;
            this.afficherHistoriqueBtn.Click += new System.EventHandler(this.afficherHistoriqueBtn_Click);
            // 
            // gererLesClientsBtn
            // 
            this.gererLesClientsBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.gererLesClientsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gererLesClientsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.gererLesClientsBtn.Location = new System.Drawing.Point(552, 221);
            this.gererLesClientsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gererLesClientsBtn.Name = "gererLesClientsBtn";
            this.gererLesClientsBtn.Size = new System.Drawing.Size(260, 46);
            this.gererLesClientsBtn.TabIndex = 1;
            this.gererLesClientsBtn.Text = "Manage customers";
            this.gererLesClientsBtn.UseVisualStyleBackColor = false;
            this.gererLesClientsBtn.Click += new System.EventHandler(this.gererLesClientsBtn_Click);
            // 
            // gererLesFilms
            // 
            this.gererLesFilms.BackColor = System.Drawing.Color.MediumOrchid;
            this.gererLesFilms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gererLesFilms.ForeColor = System.Drawing.SystemColors.Control;
            this.gererLesFilms.Location = new System.Drawing.Point(552, 145);
            this.gererLesFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gererLesFilms.Name = "gererLesFilms";
            this.gererLesFilms.Size = new System.Drawing.Size(260, 46);
            this.gererLesFilms.TabIndex = 0;
            this.gererLesFilms.Text = "Manage Movies";
            this.gererLesFilms.UseVisualStyleBackColor = false;
            this.gererLesFilms.Click += new System.EventHandler(this.gererLesFilms_Click);
            // 
            // AccueilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 629);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccueilAdmin";
            this.Text = "AccueilAdmin";
            this.Load += new System.EventHandler(this.AccueilAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changerMdpBtn;
        private System.Windows.Forms.Button gererLesAdminsBtn;
        private System.Windows.Forms.Button afficherHistoriqueBtn;
        private System.Windows.Forms.Button gererLesClientsBtn;
        private System.Windows.Forms.Button gererLesFilms;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}