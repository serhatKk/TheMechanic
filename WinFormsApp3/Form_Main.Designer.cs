namespace WinFormsApp3
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnCollector2 = new Button();
            panelMenu = new Panel();
            btnBoss = new FontAwesome.Sharp.IconButton();
            btnCollector = new FontAwesome.Sharp.IconButton();
            btnMechanic = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitle = new Panel();
            btnUsername = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            labeltitle = new Label();
            iconHome = new FontAwesome.Sharp.IconPictureBox();
            panelMain = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconHome).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(283, 563);
            button1.Name = "button1";
            button1.Size = new Size(195, 55);
            button1.TabIndex = 0;
            button1.Text = "Customer";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(533, 472);
            button2.Name = "button2";
            button2.Size = new Size(236, 167);
            button2.TabIndex = 1;
            button2.Text = "Mechanic";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.OldLace;
            button3.Location = new Point(825, 533);
            button3.Name = "button3";
            button3.Size = new Size(158, 106);
            button3.TabIndex = 2;
            button3.Text = "BOSS";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnCollector2
            // 
            btnCollector2.Location = new Point(1041, 404);
            btnCollector2.Name = "btnCollector2";
            btnCollector2.Size = new Size(134, 98);
            btnCollector2.TabIndex = 3;
            btnCollector2.Text = "button4";
            btnCollector2.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(47, 21, 74);
            panelMenu.Controls.Add(btnBoss);
            panelMenu.Controls.Add(btnCollector);
            panelMenu.Controls.Add(btnMechanic);
            panelMenu.Controls.Add(btnCustomer);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(215, 788);
            panelMenu.TabIndex = 4;
            // 
            // btnBoss
            // 
            btnBoss.Dock = DockStyle.Bottom;
            btnBoss.FlatAppearance.BorderSize = 0;
            btnBoss.FlatStyle = FlatStyle.Flat;
            btnBoss.ForeColor = SystemColors.ButtonFace;
            btnBoss.IconChar = FontAwesome.Sharp.IconChar.Key;
            btnBoss.IconColor = Color.White;
            btnBoss.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBoss.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoss.Location = new Point(0, 710);
            btnBoss.Name = "btnBoss";
            btnBoss.Padding = new Padding(20, 0, 20, 0);
            btnBoss.Size = new Size(215, 78);
            btnBoss.TabIndex = 4;
            btnBoss.Text = "BOSS";
            btnBoss.TextAlign = ContentAlignment.MiddleLeft;
            btnBoss.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBoss.UseVisualStyleBackColor = true;
            btnBoss.Click += btnBoss_Click;
            // 
            // btnCollector
            // 
            btnCollector.Dock = DockStyle.Top;
            btnCollector.FlatAppearance.BorderSize = 0;
            btnCollector.FlatStyle = FlatStyle.Flat;
            btnCollector.ForeColor = SystemColors.ButtonFace;
            btnCollector.IconChar = FontAwesome.Sharp.IconChar.Trailer;
            btnCollector.IconColor = Color.WhiteSmoke;
            btnCollector.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCollector.ImageAlign = ContentAlignment.MiddleLeft;
            btnCollector.Location = new Point(0, 319);
            btnCollector.Name = "btnCollector";
            btnCollector.Padding = new Padding(20, 5, 20, 0);
            btnCollector.Size = new Size(215, 78);
            btnCollector.TabIndex = 3;
            btnCollector.Text = "Collectors";
            btnCollector.TextAlign = ContentAlignment.MiddleLeft;
            btnCollector.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCollector.UseVisualStyleBackColor = true;
            btnCollector.Click += btnCollector_Click;
            // 
            // btnMechanic
            // 
            btnMechanic.Dock = DockStyle.Top;
            btnMechanic.FlatAppearance.BorderSize = 0;
            btnMechanic.FlatStyle = FlatStyle.Flat;
            btnMechanic.ForeColor = SystemColors.ButtonFace;
            btnMechanic.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            btnMechanic.IconColor = Color.WhiteSmoke;
            btnMechanic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMechanic.ImageAlign = ContentAlignment.MiddleLeft;
            btnMechanic.Location = new Point(0, 241);
            btnMechanic.Name = "btnMechanic";
            btnMechanic.Padding = new Padding(20, 5, 20, 0);
            btnMechanic.Size = new Size(215, 78);
            btnMechanic.TabIndex = 2;
            btnMechanic.Text = "Mechanics";
            btnMechanic.TextAlign = ContentAlignment.MiddleLeft;
            btnMechanic.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMechanic.UseVisualStyleBackColor = true;
            btnMechanic.Click += btnMechanic_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = SystemColors.ButtonFace;
            btnCustomer.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            btnCustomer.IconColor = Color.WhiteSmoke;
            btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 163);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(20, 5, 20, 0);
            btnCustomer.Size = new Size(215, 78);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customers";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(215, 163);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.Image = TheMec.Properties.Resources.logo_removebg_preview;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(215, 163);
            btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(47, 21, 74);
            panelTitle.Controls.Add(btnUsername);
            panelTitle.Controls.Add(btnLogout);
            panelTitle.Controls.Add(labeltitle);
            panelTitle.Controls.Add(iconHome);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(215, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1166, 65);
            panelTitle.TabIndex = 5;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // btnUsername
            // 
            btnUsername.Dock = DockStyle.Right;
            btnUsername.FlatAppearance.BorderSize = 0;
            btnUsername.FlatStyle = FlatStyle.Flat;
            btnUsername.ForeColor = SystemColors.ButtonHighlight;
            btnUsername.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnUsername.IconColor = SystemColors.ButtonHighlight;
            btnUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsername.IconSize = 30;
            btnUsername.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsername.Location = new Point(915, 0);
            btnUsername.Name = "btnUsername";
            btnUsername.Size = new Size(178, 65);
            btnUsername.TabIndex = 7;
            btnUsername.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsername.UseVisualStyleBackColor = true;
            btnUsername.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnLogout.IconColor = SystemColors.ButtonHighlight;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 30;
            btnLogout.Location = new Point(1093, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(73, 65);
            btnLogout.TabIndex = 8;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labeltitle.ForeColor = SystemColors.ButtonFace;
            labeltitle.Location = new Point(77, 21);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(65, 28);
            labeltitle.TabIndex = 6;
            labeltitle.Text = "Home";
            // 
            // iconHome
            // 
            iconHome.BackColor = Color.FromArgb(47, 21, 74);
            iconHome.ForeColor = Color.Khaki;
            iconHome.IconChar = FontAwesome.Sharp.IconChar.Pagelines;
            iconHome.IconColor = Color.Khaki;
            iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHome.IconSize = 47;
            iconHome.Location = new Point(19, 12);
            iconHome.Name = "iconHome";
            iconHome.Size = new Size(52, 47);
            iconHome.TabIndex = 0;
            iconHome.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(57, 20, 94);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(215, 65);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1166, 723);
            panelMain.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1166, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 723);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = TheMec.Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(404, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 396);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 788);
            Controls.Add(panelMain);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            Controls.Add(button1);
            Controls.Add(btnCollector2);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconHome).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnCollector2;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCollector;
        private FontAwesome.Sharp.IconButton btnMechanic;
        private FontAwesome.Sharp.IconButton btnBoss;
        private PictureBox btnHome;
        private Panel panelTitle;
        private Label labeltitle;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnUsername;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}
