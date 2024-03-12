namespace WinFormsApp3
{
    partial class Form_CustomerLogin
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
            usrnameTxtBox = new TextBox();
            pswTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new FontAwesome.Sharp.IconButton();
            btnRegister = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // usrnameTxtBox
            // 
            usrnameTxtBox.Anchor = AnchorStyles.None;
            usrnameTxtBox.BackColor = SystemColors.ButtonFace;
            usrnameTxtBox.Location = new Point(514, 242);
            usrnameTxtBox.Name = "usrnameTxtBox";
            usrnameTxtBox.PlaceholderText = "example@example.com";
            usrnameTxtBox.Size = new Size(217, 27);
            usrnameTxtBox.TabIndex = 0;
            // 
            // pswTextBox
            // 
            pswTextBox.Anchor = AnchorStyles.None;
            pswTextBox.BackColor = SystemColors.ButtonFace;
            pswTextBox.Location = new Point(514, 289);
            pswTextBox.Name = "pswTextBox";
            pswTextBox.PasswordChar = '*';
            pswTextBox.PlaceholderText = "*************";
            pswTextBox.Size = new Size(217, 27);
            pswTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(422, 245);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Username : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(431, 289);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Password: ";
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
            btnLogin.Location = new Point(568, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 47);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
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
            btnRegister.Location = new Point(568, 389);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(123, 47);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form_CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(usrnameTxtBox);
            Controls.Add(label1);
            Controls.Add(pswTextBox);
            Controls.Add(label2);
            Name = "Form_CustomerLogin";
            Tag = "CustomerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usrnameTxtBox;
        private TextBox pswTextBox;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnRegister;
    }
}