namespace WinFormsApp3
{
    partial class FormCustomerMain
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
            btnMyCars = new FontAwesome.Sharp.IconButton();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnMyCars
            // 
            btnMyCars.Anchor = AnchorStyles.None;
            btnMyCars.FlatStyle = FlatStyle.Flat;
            btnMyCars.Font = new Font("Segoe UI", 12F);
            btnMyCars.ForeColor = Color.MintCream;
            btnMyCars.IconChar = FontAwesome.Sharp.IconChar.User;
            btnMyCars.IconColor = Color.Black;
            btnMyCars.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyCars.Location = new Point(153, 265);
            btnMyCars.Name = "btnMyCars";
            btnMyCars.Size = new Size(230, 148);
            btnMyCars.TabIndex = 2;
            btnMyCars.Text = "Servisteki Arabalarım";
            btnMyCars.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyCars.UseVisualStyleBackColor = true;
            btnMyCars.Click += button1_Click;
            // 
            // ıconButton1
            // 
            ıconButton1.Anchor = AnchorStyles.None;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.Font = new Font("Segoe UI", 11F);
            ıconButton1.ForeColor = Color.MintCream;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.VolumeControlPhone;
            ıconButton1.IconColor = SystemColors.ActiveCaptionText;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(464, 266);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(230, 148);
            ıconButton1.TabIndex = 3;
            ıconButton1.Text = "Servis Çağır  (Araba Kaydı)";
            ıconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton1.UseVisualStyleBackColor = true;
            ıconButton1.Click += button2_Click;
            // 
            // ıconButton2
            // 
            ıconButton2.Anchor = AnchorStyles.None;
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.Font = new Font("Segoe UI", 11F);
            ıconButton2.ForeColor = Color.MintCream;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Automobile;
            ıconButton2.IconColor = SystemColors.ActiveCaptionText;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.Location = new Point(790, 265);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(230, 148);
            ıconButton2.TabIndex = 4;
            ıconButton2.Text = "Arabamı Teslim Al";
            ıconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton2.UseVisualStyleBackColor = true;
            ıconButton2.Click += ıconButton2_Click;
            // 
            // FormCustomerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(ıconButton2);
            Controls.Add(ıconButton1);
            Controls.Add(btnMyCars);
            Name = "FormCustomerMain";
            Tag = "Menu";
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnMyCars;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
    }
}