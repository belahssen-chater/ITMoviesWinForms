namespace ITMovies
{
    partial class GestionFilms
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
            this.retourBtn = new System.Windows.Forms.Button();
            this.ajouterPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.realField = new System.Windows.Forms.TextBox();
            this.langueField = new System.Windows.Forms.TextBox();
            this.dureeField = new System.Windows.Forms.TextBox();
            this.prixField = new System.Windows.Forms.TextBox();
            this.titreField = new System.Windows.Forms.TextBox();
            this.supprimerPanel = new System.Windows.Forms.Panel();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Langue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajouterPanel.SuspendLayout();
            this.supprimerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // retourBtn
            // 
            this.retourBtn.Location = new System.Drawing.Point(13, 13);
            this.retourBtn.Name = "retourBtn";
            this.retourBtn.Size = new System.Drawing.Size(93, 35);
            this.retourBtn.TabIndex = 0;
            this.retourBtn.Text = "Retour";
            this.retourBtn.UseVisualStyleBackColor = true;
            // 
            // ajouterPanel
            // 
            this.ajouterPanel.Controls.Add(this.titreField);
            this.ajouterPanel.Controls.Add(this.realField);
            this.ajouterPanel.Controls.Add(this.ajouterBtn);
            this.ajouterPanel.Controls.Add(this.langueField);
            this.ajouterPanel.Controls.Add(this.dureeField);
            this.ajouterPanel.Controls.Add(this.prixField);
            this.ajouterPanel.Controls.Add(this.label5);
            this.ajouterPanel.Controls.Add(this.label4);
            this.ajouterPanel.Controls.Add(this.label3);
            this.ajouterPanel.Controls.Add(this.label2);
            this.ajouterPanel.Controls.Add(this.label1);
            this.ajouterPanel.Location = new System.Drawing.Point(97, 66);
            this.ajouterPanel.Name = "ajouterPanel";
            this.ajouterPanel.Size = new System.Drawing.Size(377, 262);
            this.ajouterPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Realisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Langue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix";
            // 
            // realField
            // 
            this.realField.Location = new System.Drawing.Point(131, 65);
            this.realField.Name = "realField";
            this.realField.Size = new System.Drawing.Size(212, 22);
            this.realField.TabIndex = 2;
            // 
            // langueField
            // 
            this.langueField.Location = new System.Drawing.Point(131, 106);
            this.langueField.Name = "langueField";
            this.langueField.Size = new System.Drawing.Size(212, 22);
            this.langueField.TabIndex = 3;
            // 
            // dureeField
            // 
            this.dureeField.Location = new System.Drawing.Point(131, 146);
            this.dureeField.Name = "dureeField";
            this.dureeField.Size = new System.Drawing.Size(212, 22);
            this.dureeField.TabIndex = 4;
            // 
            // prixField
            // 
            this.prixField.Location = new System.Drawing.Point(131, 188);
            this.prixField.Name = "prixField";
            this.prixField.Size = new System.Drawing.Size(212, 22);
            this.prixField.TabIndex = 5;
            // 
            // titreField
            // 
            this.titreField.Location = new System.Drawing.Point(131, 20);
            this.titreField.Name = "titreField";
            this.titreField.Size = new System.Drawing.Size(212, 22);
            this.titreField.TabIndex = 6;
            // 
            // supprimerPanel
            // 
            this.supprimerPanel.Controls.Add(this.label6);
            this.supprimerPanel.Controls.Add(this.idField);
            this.supprimerPanel.Controls.Add(this.supprimerBtn);
            this.supprimerPanel.Location = new System.Drawing.Point(624, 243);
            this.supprimerPanel.Name = "supprimerPanel";
            this.supprimerPanel.Size = new System.Drawing.Size(278, 85);
            this.supprimerPanel.TabIndex = 2;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Location = new System.Drawing.Point(268, 216);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(75, 23);
            this.ajouterBtn.TabIndex = 0;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = true;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.Location = new System.Drawing.Point(1009, 270);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(75, 23);
            this.modifierBtn.TabIndex = 1;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = true;
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.Location = new System.Drawing.Point(186, 28);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(75, 23);
            this.supprimerBtn.TabIndex = 2;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = true;
            this.supprimerBtn.Click += new System.EventHandler(this.supprimerBtn_Click);
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(80, 28);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 22);
            this.idField.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre,
            this.Realisateur,
            this.Langue,
            this.Duree,
            this.Prix});
            this.dataGridView1.Location = new System.Drawing.Point(37, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 261);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Titre
            // 
            this.Titre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titre.DataPropertyName = "titre";
            this.Titre.HeaderText = "Titre";
            this.Titre.MinimumWidth = 6;
            this.Titre.Name = "Titre";
            // 
            // Realisateur
            // 
            this.Realisateur.DataPropertyName = "realisateur";
            this.Realisateur.HeaderText = "Réalisateur";
            this.Realisateur.MinimumWidth = 6;
            this.Realisateur.Name = "Realisateur";
            this.Realisateur.Width = 125;
            // 
            // Langue
            // 
            this.Langue.DataPropertyName = "langue";
            this.Langue.HeaderText = "Langue";
            this.Langue.MinimumWidth = 6;
            this.Langue.Name = "Langue";
            this.Langue.Width = 125;
            // 
            // Duree
            // 
            this.Duree.DataPropertyName = "duree";
            this.Duree.HeaderText = "Duree";
            this.Duree.MinimumWidth = 6;
            this.Duree.Name = "Duree";
            this.Duree.Width = 125;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.Width = 125;
            // 
            // GestionFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.supprimerPanel);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.ajouterPanel);
            this.Controls.Add(this.retourBtn);
            this.Name = "GestionFilms";
            this.Text = "GestionFilms";
            this.ajouterPanel.ResumeLayout(false);
            this.ajouterPanel.PerformLayout();
            this.supprimerPanel.ResumeLayout(false);
            this.supprimerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retourBtn;
        private System.Windows.Forms.Panel ajouterPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titreField;
        private System.Windows.Forms.TextBox realField;
        private System.Windows.Forms.TextBox langueField;
        private System.Windows.Forms.TextBox dureeField;
        private System.Windows.Forms.TextBox prixField;
        private System.Windows.Forms.Panel supprimerPanel;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Realisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Langue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
    }
}