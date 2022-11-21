namespace ITMovies
{
    partial class GestionClient
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
            this.modifierBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supprimerBtn = new System.Windows.Forms.Button();
            this.idFieldSupprimer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.mdpField = new System.Windows.Forms.TextBox();
            this.telField = new System.Windows.Forms.TextBox();
            this.nomField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFieldAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // modifierBtn
            // 
            this.modifierBtn.Location = new System.Drawing.Point(908, 191);
            this.modifierBtn.Name = "modifierBtn";
            this.modifierBtn.Size = new System.Drawing.Size(75, 23);
            this.modifierBtn.TabIndex = 5;
            this.modifierBtn.Text = "Modifier";
            this.modifierBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.supprimerBtn);
            this.panel2.Controls.Add(this.idFieldSupprimer);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(464, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 72);
            this.panel2.TabIndex = 4;
            // 
            // supprimerBtn
            // 
            this.supprimerBtn.Location = new System.Drawing.Point(190, 23);
            this.supprimerBtn.Name = "supprimerBtn";
            this.supprimerBtn.Size = new System.Drawing.Size(86, 23);
            this.supprimerBtn.TabIndex = 2;
            this.supprimerBtn.Text = "Supprimer";
            this.supprimerBtn.UseVisualStyleBackColor = true;
            // 
            // idFieldSupprimer
            // 
            this.idFieldSupprimer.Location = new System.Drawing.Point(69, 23);
            this.idFieldSupprimer.Name = "idFieldSupprimer";
            this.idFieldSupprimer.Size = new System.Drawing.Size(100, 22);
            this.idFieldSupprimer.TabIndex = 1;
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
            this.panel1.Location = new System.Drawing.Point(90, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 215);
            this.panel1.TabIndex = 3;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Location = new System.Drawing.Point(243, 186);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(75, 23);
            this.ajouterBtn.TabIndex = 7;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = true;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // mdpField
            // 
            this.mdpField.Location = new System.Drawing.Point(132, 146);
            this.mdpField.Name = "mdpField";
            this.mdpField.Size = new System.Drawing.Size(187, 22);
            this.mdpField.TabIndex = 6;
            // 
            // telField
            // 
            this.telField.Location = new System.Drawing.Point(132, 93);
            this.telField.Name = "telField";
            this.telField.Size = new System.Drawing.Size(187, 22);
            this.telField.TabIndex = 5;
            // 
            // nomField
            // 
            this.nomField.Location = new System.Drawing.Point(132, 45);
            this.nomField.Name = "nomField";
            this.nomField.Size = new System.Drawing.Size(187, 22);
            this.nomField.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 266);
            this.dataGridView1.TabIndex = 6;
            // 
            // idFieldAdd
            // 
            this.idFieldAdd.Location = new System.Drawing.Point(132, 17);
            this.idFieldAdd.Name = "idFieldAdd";
            this.idFieldAdd.Size = new System.Drawing.Size(186, 22);
            this.idFieldAdd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modifierBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GestionClient";
            this.Text = "GestionClient";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modifierBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button supprimerBtn;
        private System.Windows.Forms.TextBox idFieldSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.TextBox mdpField;
        private System.Windows.Forms.TextBox telField;
        private System.Windows.Forms.TextBox nomField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idFieldAdd;
    }
}