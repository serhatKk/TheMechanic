namespace WinFormsApp3
{
    partial class FormBossCollector
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtBoxPsw = new TextBox();
            txtBoxMail = new TextBox();
            txtBoxPhoneNumber = new TextBox();
            txtBoxSurname = new TextBox();
            txtBoxName = new TextBox();
            btnSave = new FontAwesome.Sharp.IconButton();
            tabPage2 = new TabPage();
            btnUpdateMec = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUPsw = new TextBox();
            txtUMail = new TextBox();
            txtUphone = new TextBox();
            txtUSurname = new TextBox();
            txtUName = new TextBox();
            dtgCollector = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCollector).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1148, 676);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(57, 20, 94);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(txtBoxPsw);
            tabPage1.Controls.Add(txtBoxMail);
            tabPage1.Controls.Add(txtBoxPhoneNumber);
            tabPage1.Controls.Add(txtBoxSurname);
            tabPage1.Controls.Add(txtBoxName);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1140, 643);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hire Collector";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(156, 444);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 48;
            label6.Text = "Password :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(185, 356);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 47;
            label7.Text = "Mail :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(115, 283);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 46;
            label8.Text = "PhoneNumber:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(168, 213);
            label9.Name = "label9";
            label9.Size = new Size(89, 28);
            label9.TabIndex = 45;
            label9.Text = "Surname";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(183, 143);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 44;
            label10.Text = "Name:";
            // 
            // txtBoxPsw
            // 
            txtBoxPsw.Anchor = AnchorStyles.None;
            txtBoxPsw.Location = new Point(266, 444);
            txtBoxPsw.Name = "txtBoxPsw";
            txtBoxPsw.PasswordChar = '*';
            txtBoxPsw.PlaceholderText = "********";
            txtBoxPsw.Size = new Size(201, 27);
            txtBoxPsw.TabIndex = 43;
            // 
            // txtBoxMail
            // 
            txtBoxMail.Anchor = AnchorStyles.None;
            txtBoxMail.Location = new Point(266, 360);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.PlaceholderText = "ex@example.com";
            txtBoxMail.Size = new Size(201, 27);
            txtBoxMail.TabIndex = 42;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Anchor = AnchorStyles.None;
            txtBoxPhoneNumber.Location = new Point(266, 284);
            txtBoxPhoneNumber.MaxLength = 10;
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.PlaceholderText = "111111111111";
            txtBoxPhoneNumber.Size = new Size(201, 27);
            txtBoxPhoneNumber.TabIndex = 41;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Anchor = AnchorStyles.None;
            txtBoxSurname.Location = new Point(266, 213);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.PlaceholderText = "Kahraman";
            txtBoxSurname.Size = new Size(201, 27);
            txtBoxSurname.TabIndex = 40;
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.None;
            txtBoxName.Location = new Point(266, 147);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "Sero";
            txtBoxName.Size = new Size(201, 27);
            txtBoxName.TabIndex = 39;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 18F);
            btnSave.ForeColor = Color.AliceBlue;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            btnSave.IconColor = SystemColors.GradientInactiveCaption;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 90;
            btnSave.Location = new Point(609, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(298, 128);
            btnSave.TabIndex = 38;
            btnSave.Text = "Hire Collector";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnHireCol_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(57, 20, 94);
            tabPage2.Controls.Add(btnUpdateMec);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtUPsw);
            tabPage2.Controls.Add(txtUMail);
            tabPage2.Controls.Add(txtUphone);
            tabPage2.Controls.Add(txtUSurname);
            tabPage2.Controls.Add(txtUName);
            tabPage2.Controls.Add(dtgCollector);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1140, 643);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update Collector";
            // 
            // btnUpdateMec
            // 
            btnUpdateMec.Anchor = AnchorStyles.None;
            btnUpdateMec.FlatStyle = FlatStyle.Flat;
            btnUpdateMec.Font = new Font("Arial Narrow", 18F);
            btnUpdateMec.ForeColor = Color.Wheat;
            btnUpdateMec.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
            btnUpdateMec.IconColor = Color.GhostWhite;
            btnUpdateMec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdateMec.Location = new Point(496, 472);
            btnUpdateMec.Name = "btnUpdateMec";
            btnUpdateMec.Size = new Size(197, 68);
            btnUpdateMec.TabIndex = 49;
            btnUpdateMec.Text = "Update";
            btnUpdateMec.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateMec.UseVisualStyleBackColor = true;
            btnUpdateMec.Click += btnUpdateCol_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(766, 312);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 48;
            label1.Text = "Password :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(415, 366);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 47;
            label2.Text = "Mail :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(345, 312);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 46;
            label3.Text = "PhoneNumber:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(26, 355);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 45;
            label4.Text = "Surname";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(41, 303);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 44;
            label5.Text = "Name:";
            // 
            // txtUPsw
            // 
            txtUPsw.Anchor = AnchorStyles.None;
            txtUPsw.Location = new Point(874, 315);
            txtUPsw.Name = "txtUPsw";
            txtUPsw.PlaceholderText = "********";
            txtUPsw.Size = new Size(201, 27);
            txtUPsw.TabIndex = 43;
            // 
            // txtUMail
            // 
            txtUMail.Anchor = AnchorStyles.None;
            txtUMail.Location = new Point(496, 370);
            txtUMail.Name = "txtUMail";
            txtUMail.PlaceholderText = "ex@example.com";
            txtUMail.Size = new Size(201, 27);
            txtUMail.TabIndex = 42;
            // 
            // txtUphone
            // 
            txtUphone.Anchor = AnchorStyles.None;
            txtUphone.Location = new Point(496, 313);
            txtUphone.MaxLength = 10;
            txtUphone.Name = "txtUphone";
            txtUphone.PlaceholderText = "111111111111";
            txtUphone.Size = new Size(201, 27);
            txtUphone.TabIndex = 41;
            // 
            // txtUSurname
            // 
            txtUSurname.Anchor = AnchorStyles.None;
            txtUSurname.Location = new Point(124, 355);
            txtUSurname.Name = "txtUSurname";
            txtUSurname.PlaceholderText = "Kahraman";
            txtUSurname.Size = new Size(201, 27);
            txtUSurname.TabIndex = 40;
            // 
            // txtUName
            // 
            txtUName.Anchor = AnchorStyles.None;
            txtUName.Location = new Point(124, 307);
            txtUName.Name = "txtUName";
            txtUName.PlaceholderText = "Sero";
            txtUName.Size = new Size(201, 27);
            txtUName.TabIndex = 39;
            // 
            // dtgCollector
            // 
            dtgCollector.AllowUserToAddRows = false;
            dtgCollector.AllowUserToDeleteRows = false;
            dtgCollector.Anchor = AnchorStyles.None;
            dtgCollector.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCollector.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgCollector.BackgroundColor = Color.Lavender;
            dtgCollector.BorderStyle = BorderStyle.None;
            dtgCollector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lavender;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgCollector.DefaultCellStyle = dataGridViewCellStyle1;
            dtgCollector.Location = new Point(3, 3);
            dtgCollector.Name = "dtgCollector";
            dtgCollector.ReadOnly = true;
            dtgCollector.RowHeadersVisible = false;
            dtgCollector.RowHeadersWidth = 51;
            dtgCollector.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCollector.Size = new Size(1134, 270);
            dtgCollector.TabIndex = 38;
            dtgCollector.CellClick += dtgCollector_CellClick;
            // 
            // FormBossCollector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(tabControl1);
            Name = "FormBossCollector";
            Text = "FormBossCollector";
            Load += FormBossCollector_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCollector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnUpdateMec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUPsw;
        private TextBox txtUMail;
        private TextBox txtUphone;
        private TextBox txtUSurname;
        private TextBox txtUName;
        private DataGridView dtgCollector;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtBoxPsw;
        private TextBox txtBoxMail;
        private TextBox txtBoxPhoneNumber;
        private TextBox txtBoxSurname;
        private TextBox txtBoxName;
    }
}