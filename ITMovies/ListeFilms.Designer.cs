namespace ITMovies
{
    partial class ListeFilms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.acheterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.acheterBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idField);
            this.panel1.Location = new System.Drawing.Point(798, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 73);
            this.panel1.TabIndex = 1;
            // 
            // acheterBtn
            // 
            this.acheterBtn.Location = new System.Drawing.Point(208, 26);
            this.acheterBtn.Name = "acheterBtn";
            this.acheterBtn.Size = new System.Drawing.Size(75, 23);
            this.acheterBtn.TabIndex = 2;
            this.acheterBtn.Text = "Acheter";
            this.acheterBtn.UseVisualStyleBackColor = true;
            this.acheterBtn.Click += new System.EventHandler(this.acheterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(73, 24);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 22);
            this.idField.TabIndex = 0;
            // 
            // ListeFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeFilms";
            this.Text = "ListeFilms";
            this.Load += new System.EventHandler(this.ListeFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button acheterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idField;
    }
}