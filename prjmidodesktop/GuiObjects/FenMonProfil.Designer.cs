namespace DesktopIHM.GuiObjects
{
    partial class FenMonProfil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monProfile = new System.Windows.Forms.Label();
            this.monEmail = new System.Windows.Forms.Label();
            this.monLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monProfile);
            this.groupBox1.Controls.Add(this.monEmail);
            this.groupBox1.Controls.Add(this.monLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes données personnelles";
            // 
            // monProfile
            // 
            this.monProfile.AutoSize = true;
            this.monProfile.Location = new System.Drawing.Point(112, 87);
            this.monProfile.Name = "monProfile";
            this.monProfile.Size = new System.Drawing.Size(0, 13);
            this.monProfile.TabIndex = 5;
            // 
            // monEmail
            // 
            this.monEmail.AutoSize = true;
            this.monEmail.Location = new System.Drawing.Point(112, 61);
            this.monEmail.Name = "monEmail";
            this.monEmail.Size = new System.Drawing.Size(0, 13);
            this.monEmail.TabIndex = 4;
            // 
            // monLogin
            // 
            this.monLogin.AutoSize = true;
            this.monLogin.Location = new System.Drawing.Point(112, 31);
            this.monLogin.Name = "monLogin";
            this.monLogin.Size = new System.Drawing.Size(0, 13);
            this.monLogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mon profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mon email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mon login";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(21, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mes permissions";
            // 
            // FenMonProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FenMonProfil";
            this.Text = "Mon profile Utilisateur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monProfile;
        private System.Windows.Forms.Label monEmail;
        private System.Windows.Forms.Label monLogin;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}