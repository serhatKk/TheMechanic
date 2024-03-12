namespace WinFormsApp3
{
    partial class FormBossMain
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
            btnCollectors = new FontAwesome.Sharp.IconButton();
            btnMec = new FontAwesome.Sharp.IconButton();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // btnCollectors
            // 
            btnCollectors.Anchor = AnchorStyles.None;
            btnCollectors.FlatStyle = FlatStyle.Flat;
            btnCollectors.Font = new Font("Segoe UI", 11F);
            btnCollectors.ForeColor = Color.MintCream;
            btnCollectors.IconChar = FontAwesome.Sharp.IconChar.VolumeControlPhone;
            btnCollectors.IconColor = SystemColors.ActiveCaptionText;
            btnCollectors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCollectors.Location = new Point(433, 238);
            btnCollectors.Name = "btnCollectors";
            btnCollectors.Size = new Size(230, 148);
            btnCollectors.TabIndex = 5;
            btnCollectors.Text = "COLLECTORS";
            btnCollectors.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCollectors.UseVisualStyleBackColor = true;
            btnCollectors.Click += btnCollectors_Click;
            // 
            // btnMec
            // 
            btnMec.Anchor = AnchorStyles.None;
            btnMec.FlatStyle = FlatStyle.Flat;
            btnMec.Font = new Font("Segoe UI", 12F);
            btnMec.ForeColor = Color.MintCream;
            btnMec.IconChar = FontAwesome.Sharp.IconChar.User;
            btnMec.IconColor = Color.Black;
            btnMec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMec.Location = new Point(95, 237);
            btnMec.Name = "btnMec";
            btnMec.Size = new Size(230, 148);
            btnMec.TabIndex = 4;
            btnMec.Text = "MECHANICS";
            btnMec.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMec.UseVisualStyleBackColor = true;
            btnMec.Click += btnMec_Click;
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
            ıconButton1.Location = new Point(768, 238);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(230, 148);
            ıconButton1.TabIndex = 6;
            ıconButton1.Text = "FINANCE";
            ıconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // FormBossMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(ıconButton1);
            Controls.Add(btnCollectors);
            Controls.Add(btnMec);
            Name = "FormBossMain";
            Text = "FormBossMain";
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCollectors;
        private FontAwesome.Sharp.IconButton btnMec;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}