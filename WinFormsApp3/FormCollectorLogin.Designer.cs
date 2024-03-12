namespace WinFormsApp3
{
    partial class FormCollectorLogin
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
            btnRegister = new FontAwesome.Sharp.IconButton();
            btnLogin = new FontAwesome.Sharp.IconButton();
            txtBoxUsername = new TextBox();
            label3 = new Label();
            txtBoxPsw = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnRegister.IconColor = SystemColors.ButtonShadow;
            btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegister.IconSize = 44;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(570, 387);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(123, 47);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnCollectorRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            btnLogin.IconColor = SystemColors.ButtonShadow;
            btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogin.IconSize = 44;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(570, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 47);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnCollectorLogin_Click;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Anchor = AnchorStyles.None;
            txtBoxUsername.BackColor = SystemColors.ButtonFace;
            txtBoxUsername.Location = new Point(516, 240);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.PlaceholderText = "example@example.com";
            txtBoxUsername.Size = new Size(217, 27);
            txtBoxUsername.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(424, 243);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 14;
            label3.Text = "Username : ";
            // 
            // txtBoxPsw
            // 
            txtBoxPsw.Anchor = AnchorStyles.None;
            txtBoxPsw.BackColor = SystemColors.ButtonFace;
            txtBoxPsw.Location = new Point(516, 287);
            txtBoxPsw.Name = "txtBoxPsw";
            txtBoxPsw.PasswordChar = '*';
            txtBoxPsw.PlaceholderText = "*************";
            txtBoxPsw.Size = new Size(217, 27);
            txtBoxPsw.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(433, 287);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 15;
            label4.Text = "Password: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxPsw);
            panel1.Controls.Add(txtBoxUsername);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 676);
            panel1.TabIndex = 18;
            // 
            // FormCollectorLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(panel1);
            Name = "FormCollectorLogin";
            Tag = "Collector Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegister;
        private FontAwesome.Sharp.IconButton btnLogin;
        private TextBox txtBoxUsername;
        private Label label3;
        private TextBox txtBoxPsw;
        private Label label4;
        private Panel panel1;
    }
}