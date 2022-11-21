namespace ITMovies
{
    partial class GestionClient2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetPwdBtn = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resetPwdBtn);
            this.panel2.Controls.Add(this.idField);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(355, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 100);
            this.panel2.TabIndex = 6;
            // 
            // resetPwdBtn
            // 
            this.resetPwdBtn.Location = new System.Drawing.Point(158, 30);
            this.resetPwdBtn.Name = "resetPwdBtn";
            this.resetPwdBtn.Size = new System.Drawing.Size(90, 43);
            this.resetPwdBtn.TabIndex = 2;
            this.resetPwdBtn.Text = "Reset pwd";
            this.resetPwdBtn.UseVisualStyleBackColor = true;
            this.resetPwdBtn.Click += new System.EventHandler(this.resetPwdBtn_Click);
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(30, 40);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 22);
            this.idField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // validerBtn
            // 
            this.validerBtn.Location = new System.Drawing.Point(22, 263);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(87, 41);
            this.validerBtn.TabIndex = 5;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchField);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(812, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 100);
            this.panel1.TabIndex = 4;
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(99, 41);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(176, 22);
            this.searchField.TabIndex = 1;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche";
            // 
            // GestionClient2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionClient2";
            this.Text = "GestionClient2";
            this.Load += new System.EventHandler(this.GestionClient2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resetPwdBtn;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label1;
    }
}