namespace WinFormsApp3
{
    partial class FormMechanicLogin
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
            usrnameTxtBox = new TextBox();
            label3 = new Label();
            txtBoxPsw = new TextBox();
            label4 = new Label();
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
            btnRegister.Location = new Point(564, 390);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(123, 47);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
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
            btnLogin.Location = new Point(564, 337);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 47);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // usrnameTxtBox
            // 
            usrnameTxtBox.Anchor = AnchorStyles.None;
            usrnameTxtBox.BackColor = SystemColors.ButtonFace;
            usrnameTxtBox.Location = new Point(510, 243);
            usrnameTxtBox.Name = "usrnameTxtBox";
            usrnameTxtBox.PlaceholderText = "example@example.com";
            usrnameTxtBox.Size = new Size(217, 27);
            usrnameTxtBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(418, 246);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 14;
            label3.Text = "Username : ";
            // 
            // txtBoxPsw
            // 
            txtBoxPsw.Anchor = AnchorStyles.None;
            txtBoxPsw.BackColor = SystemColors.ButtonFace;
            txtBoxPsw.Location = new Point(510, 290);
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
            label4.Location = new Point(427, 290);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 15;
            label4.Text = "Password: ";
            // 
            // FormMechanicLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(usrnameTxtBox);
            Controls.Add(label3);
            Controls.Add(txtBoxPsw);
            Controls.Add(label4);
            Name = "FormMechanicLogin";
            Tag = "Mechanic Login ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegister;
        private FontAwesome.Sharp.IconButton btnLogin;
        private TextBox usrnameTxtBox;
        private Label label3;
        private TextBox txtBoxPsw;
        private Label label4;
    }
}