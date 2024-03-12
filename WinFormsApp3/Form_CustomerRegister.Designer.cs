namespace WinFormsApp3
{
    partial class Form_CustomerRegister
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
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxSurname = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxMail = new TextBox();
            textBoxPassword = new TextBox();
            btnSave = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Location = new Point(371, 145);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Sero";
            textBoxName.Size = new Size(201, 27);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(288, 141);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(273, 193);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 7;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(220, 250);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 8;
            label3.Text = "PhoneNumber:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(290, 304);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 9;
            label4.Text = "Mail :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(261, 359);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 10;
            label5.Text = "Password :";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.Location = new Point(371, 193);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.PlaceholderText = "Kahraman";
            textBoxSurname.Size = new Size(201, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Anchor = AnchorStyles.None;
            textBoxPhoneNumber.Location = new Point(371, 251);
            textBoxPhoneNumber.MaxLength = 10;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "111111111111";
            textBoxPhoneNumber.Size = new Size(201, 27);
            textBoxPhoneNumber.TabIndex = 2;
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.None;
            textBoxMail.Location = new Point(371, 308);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "ex@example.com";
            textBoxMail.Size = new Size(201, 27);
            textBoxMail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(371, 359);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "********";
            textBoxPassword.Size = new Size(201, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.ForeColor = Color.AliceBlue;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            btnSave.IconColor = SystemColors.ButtonShadow;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 90;
            btnSave.Location = new Point(667, 206);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(198, 100);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // Form_CustomerRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1119, 549);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Name = "Form_CustomerRegister";
            Tag = "Customer Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxSurname;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxMail;
        private TextBox textBoxPassword;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}