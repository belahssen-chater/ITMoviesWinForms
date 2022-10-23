namespace ITMovies
{
    partial class ChangerMdp
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
            this.button1 = new System.Windows.Forms.Button();
            this.newPwdField = new System.Windows.Forms.TextBox();
            this.oldPwdField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPwdField2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newPwdField2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.newPwdField);
            this.panel1.Controls.Add(this.oldPwdField);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(308, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 348);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Changer le mot de passe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newPwdField
            // 
            this.newPwdField.Location = new System.Drawing.Point(216, 95);
            this.newPwdField.Name = "newPwdField";
            this.newPwdField.PasswordChar = '*';
            this.newPwdField.Size = new System.Drawing.Size(183, 22);
            this.newPwdField.TabIndex = 3;
            // 
            // oldPwdField
            // 
            this.oldPwdField.Location = new System.Drawing.Point(216, 30);
            this.oldPwdField.Name = "oldPwdField";
            this.oldPwdField.PasswordChar = '*';
            this.oldPwdField.Size = new System.Drawing.Size(183, 22);
            this.oldPwdField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouveau mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancien mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmation du noueau mdp";
            // 
            // newPwdField2
            // 
            this.newPwdField2.Location = new System.Drawing.Point(216, 154);
            this.newPwdField2.Name = "newPwdField2";
            this.newPwdField2.PasswordChar = '*';
            this.newPwdField2.Size = new System.Drawing.Size(183, 22);
            this.newPwdField2.TabIndex = 5;
            // 
            // ChangerMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.panel1);
            this.Name = "ChangerMdp";
            this.Text = "ChangerMdp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newPwdField;
        private System.Windows.Forms.TextBox oldPwdField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPwdField2;
        private System.Windows.Forms.Label label3;
    }
}