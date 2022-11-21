namespace ITMovies
{
    partial class GestionAdmins
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomField = new System.Windows.Forms.TextBox();
            this.telField = new System.Windows.Forms.TextBox();
            this.mdpField = new System.Windows.Forms.TextBox();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.idFieldSuppr = new System.Windows.Forms.TextBox();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.modifierBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFieldAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.idFieldAdd);
            this.panel1.Controls.Add(this.ajouterBtn);
            this.panel1.Controls.Add(this.mdpField);
            this.panel1.Controls.Add(this.telField);
            this.panel1.Controls.Add(this.nomField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(51, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 204);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
            // 
            // nomField
            // 
            this.nomField.Location = new System.Drawing.Point(133, 31);
            this.nomField.Name = "nomField";
            this.nomField.Size = new System.Drawing.Size(187, 22);
            this.nomField.TabIndex = 4;
            // 
            // telField
            // 
            this.telField.Location = new System.Drawing.Point(133, 79);
            this.telField.Name = "telField";
            this.telField.Size = new System.Drawing.Size(187, 22);
            this.telField.TabIndex = 5;
            // 
            // mdpField
            // 
            this.mdpField.Location = new System.Drawing.Point(133, 132);
            this.mdpField.Name = "mdpField";
            this.mdpField.Size = new System.Drawing.Size(187, 22);
            this.mdpField.TabIndex = 6;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Location = new System.Drawing.Point(244, 172);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(75, 23);
            this.ajouterBtn.TabIndex = 7;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = true;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.supprimerBtn);
            this.panel2.Controls.Add(this.idFieldSuppr);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(425, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 72);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // idFieldSuppr
            // 
            this.idFieldSuppr.Location = new System.Drawing.Point(69, 23);
            this.idFieldSuppr.Name = "idFieldSuppr";
            this.idFieldSuppr.Size = new System.Drawing.Size(100, 22);
            this.idFieldSuppr.TabIndex = 1;
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.Location = new System.Drawing.Point(190, 23);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(86, 23);
            this.supprimerBtn.TabIndex = 2;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = true;
            this.supprimerBtn.Click += new System.EventHandler(this.supprimerBtn_Click);
            // 
            // modifierBtn
            // 
            this.modifierBtn.Location = new System.Drawing.Point(869, 221);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(75, 23);
            this.modifierBtn.TabIndex = 2;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // idFieldAdd
            // 
            this.idFieldAdd.Location = new System.Drawing.Point(133, 3);
            this.idFieldAdd.Name = "idFieldAdd";
            this.idFieldAdd.Size = new System.Drawing.Size(187, 22);
            this.idFieldAdd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id";
            // 
            // GestionAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GestionAdmins";
            this.Text = "GestionAdmins";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.TextBox mdpField;
        private System.Windows.Forms.TextBox telField;
        private System.Windows.Forms.TextBox nomField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.TextBox idFieldSuppr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idFieldAdd;
    }
}