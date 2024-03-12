namespace WinFormsApp3
{
    partial class FormBossMechanic
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnSave = new FontAwesome.Sharp.IconButton();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            txtBoxPsw = new TextBox();
            txtBoxMail = new TextBox();
            txtBoxPhoneNumber = new TextBox();
            txtBoxSurname = new TextBox();
            txtBoxName = new TextBox();
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
            dtgMechanics = new DataGridView();
            tabPage3 = new TabPage();
            panel5 = new Panel();
            btnGiveJob = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel7 = new Panel();
            dtgNeedToFixCars = new DataGridView();
            panel3 = new Panel();
            label13 = new Label();
            label14 = new Label();
            txtBoxCarID = new TextBox();
            txtBoxCarPlate = new TextBox();
            panel6 = new Panel();
            txtBoxMecID = new TextBox();
            txtBoxMecName = new TextBox();
            label15 = new Label();
            txtBoxMecSurname = new TextBox();
            label17 = new Label();
            label16 = new Label();
            dtgFreeMecs = new DataGridView();
            label12 = new Label();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMechanics).BeginInit();
            tabPage3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNeedToFixCars).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFreeMecs).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(7, 3);
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1148, 676);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(57, 20, 94);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1140, 641);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hire Mechanic";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 20, 94);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(txtBoxPsw);
            panel1.Controls.Add(txtBoxMail);
            panel1.Controls.Add(txtBoxPhoneNumber);
            panel1.Controls.Add(txtBoxSurname);
            panel1.Controls.Add(txtBoxName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 635);
            panel1.TabIndex = 12;
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
            btnSave.Location = new Point(612, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(298, 128);
            btnSave.TabIndex = 27;
            btnSave.Text = "Hire MECHANIC";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnHireMec_Click;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.ForeColor = SystemColors.ControlLight;
            label18.Location = new Point(224, 408);
            label18.Name = "label18";
            label18.Size = new Size(102, 28);
            label18.TabIndex = 26;
            label18.Text = "Password :";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.ForeColor = SystemColors.ControlLight;
            label19.Location = new Point(253, 353);
            label19.Name = "label19";
            label19.Size = new Size(59, 28);
            label19.TabIndex = 25;
            label19.Text = "Mail :";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.ForeColor = SystemColors.ControlLight;
            label20.Location = new Point(183, 299);
            label20.Name = "label20";
            label20.Size = new Size(143, 28);
            label20.TabIndex = 24;
            label20.Text = "PhoneNumber:";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.ForeColor = SystemColors.ControlLight;
            label21.Location = new Point(236, 242);
            label21.Name = "label21";
            label21.Size = new Size(89, 28);
            label21.TabIndex = 23;
            label21.Text = "Surname";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.None;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.ForeColor = SystemColors.ControlLight;
            label22.Location = new Point(251, 190);
            label22.Name = "label22";
            label22.Size = new Size(68, 28);
            label22.TabIndex = 22;
            label22.Text = "Name:";
            // 
            // txtBoxPsw
            // 
            txtBoxPsw.Anchor = AnchorStyles.None;
            txtBoxPsw.Location = new Point(334, 408);
            txtBoxPsw.Name = "txtBoxPsw";
            txtBoxPsw.PasswordChar = '*';
            txtBoxPsw.PlaceholderText = "********";
            txtBoxPsw.Size = new Size(201, 27);
            txtBoxPsw.TabIndex = 21;
            // 
            // txtBoxMail
            // 
            txtBoxMail.Anchor = AnchorStyles.None;
            txtBoxMail.Location = new Point(334, 357);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.PlaceholderText = "ex@example.com";
            txtBoxMail.Size = new Size(201, 27);
            txtBoxMail.TabIndex = 20;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Anchor = AnchorStyles.None;
            txtBoxPhoneNumber.Location = new Point(334, 300);
            txtBoxPhoneNumber.MaxLength = 10;
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.PlaceholderText = "111111111111";
            txtBoxPhoneNumber.Size = new Size(201, 27);
            txtBoxPhoneNumber.TabIndex = 19;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Anchor = AnchorStyles.None;
            txtBoxSurname.Location = new Point(334, 242);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.PlaceholderText = "Kahraman";
            txtBoxSurname.Size = new Size(201, 27);
            txtBoxSurname.TabIndex = 18;
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.None;
            txtBoxName.Location = new Point(334, 194);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PlaceholderText = "Sero";
            txtBoxName.Size = new Size(201, 27);
            txtBoxName.TabIndex = 17;
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
            tabPage2.Controls.Add(dtgMechanics);
            tabPage2.ForeColor = SystemColors.ControlText;
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1140, 641);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update Mechanic";
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
            btnUpdateMec.Location = new Point(496, 373);
            btnUpdateMec.Name = "btnUpdateMec";
            btnUpdateMec.Size = new Size(197, 68);
            btnUpdateMec.TabIndex = 37;
            btnUpdateMec.Text = "Update";
            btnUpdateMec.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateMec.UseVisualStyleBackColor = true;
            btnUpdateMec.Click += btnUpdateMec_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(766, 213);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 36;
            label1.Text = "Password :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(415, 267);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 35;
            label2.Text = "Mail :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(345, 213);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 34;
            label3.Text = "PhoneNumber:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(26, 256);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 33;
            label4.Text = "Surname";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(41, 204);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 32;
            label5.Text = "Name:";
            // 
            // txtUPsw
            // 
            txtUPsw.Anchor = AnchorStyles.None;
            txtUPsw.Location = new Point(874, 216);
            txtUPsw.Name = "txtUPsw";
            txtUPsw.PlaceholderText = "********";
            txtUPsw.Size = new Size(201, 27);
            txtUPsw.TabIndex = 31;
            // 
            // txtUMail
            // 
            txtUMail.Anchor = AnchorStyles.None;
            txtUMail.Location = new Point(496, 271);
            txtUMail.Name = "txtUMail";
            txtUMail.PlaceholderText = "ex@example.com";
            txtUMail.Size = new Size(201, 27);
            txtUMail.TabIndex = 30;
            // 
            // txtUphone
            // 
            txtUphone.Anchor = AnchorStyles.None;
            txtUphone.Location = new Point(496, 214);
            txtUphone.MaxLength = 10;
            txtUphone.Name = "txtUphone";
            txtUphone.PlaceholderText = "111111111111";
            txtUphone.Size = new Size(201, 27);
            txtUphone.TabIndex = 29;
            // 
            // txtUSurname
            // 
            txtUSurname.Anchor = AnchorStyles.None;
            txtUSurname.Location = new Point(124, 256);
            txtUSurname.Name = "txtUSurname";
            txtUSurname.PlaceholderText = "Kahraman";
            txtUSurname.Size = new Size(201, 27);
            txtUSurname.TabIndex = 28;
            // 
            // txtUName
            // 
            txtUName.Anchor = AnchorStyles.None;
            txtUName.Location = new Point(124, 208);
            txtUName.Name = "txtUName";
            txtUName.PlaceholderText = "Sero";
            txtUName.Size = new Size(201, 27);
            txtUName.TabIndex = 27;
            // 
            // dtgMechanics
            // 
            dtgMechanics.AllowUserToAddRows = false;
            dtgMechanics.AllowUserToDeleteRows = false;
            dtgMechanics.Anchor = AnchorStyles.None;
            dtgMechanics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMechanics.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgMechanics.BackgroundColor = Color.Lavender;
            dtgMechanics.BorderStyle = BorderStyle.None;
            dtgMechanics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lavender;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgMechanics.DefaultCellStyle = dataGridViewCellStyle1;
            dtgMechanics.Location = new Point(3, 3);
            dtgMechanics.Name = "dtgMechanics";
            dtgMechanics.ReadOnly = true;
            dtgMechanics.RowHeadersVisible = false;
            dtgMechanics.RowHeadersWidth = 51;
            dtgMechanics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgMechanics.Size = new Size(1134, 161);
            dtgMechanics.TabIndex = 0;
            dtgMechanics.CellClick += dtgMechanics_CellClick;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(57, 20, 94);
            tabPage3.Controls.Add(panel5);
            tabPage3.Controls.Add(panel2);
            tabPage3.Controls.Add(label11);
            tabPage3.ForeColor = SystemColors.ControlLightLight;
            tabPage3.Location = new Point(4, 31);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1140, 641);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Give Job To Mechanic";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(btnGiveJob);
            panel5.Location = new Point(922, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(215, 635);
            panel5.TabIndex = 29;
            // 
            // btnGiveJob
            // 
            btnGiveJob.Anchor = AnchorStyles.None;
            btnGiveJob.FlatAppearance.BorderSize = 3;
            btnGiveJob.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnGiveJob.FlatStyle = FlatStyle.Flat;
            btnGiveJob.ForeColor = SystemColors.Info;
            btnGiveJob.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            btnGiveJob.IconColor = Color.BlanchedAlmond;
            btnGiveJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGiveJob.Location = new Point(45, 229);
            btnGiveJob.Name = "btnGiveJob";
            btnGiveJob.Size = new Size(146, 140);
            btnGiveJob.TabIndex = 14;
            btnGiveJob.Text = "İŞ VER";
            btnGiveJob.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGiveJob.UseVisualStyleBackColor = true;
            btnGiveJob.Click += btnGiveJobToMec_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(dtgFreeMecs);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 635);
            panel2.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.Controls.Add(dtgNeedToFixCars);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(txtBoxCarID);
            panel7.Controls.Add(txtBoxCarPlate);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 320);
            panel7.Name = "panel7";
            panel7.Size = new Size(913, 346);
            panel7.TabIndex = 27;
            // 
            // dtgNeedToFixCars
            // 
            dtgNeedToFixCars.AllowUserToAddRows = false;
            dtgNeedToFixCars.AllowUserToDeleteRows = false;
            dtgNeedToFixCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgNeedToFixCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgNeedToFixCars.BackgroundColor = Color.Lavender;
            dtgNeedToFixCars.BorderStyle = BorderStyle.None;
            dtgNeedToFixCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Lavender;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgNeedToFixCars.DefaultCellStyle = dataGridViewCellStyle2;
            dtgNeedToFixCars.Dock = DockStyle.Top;
            dtgNeedToFixCars.Location = new Point(0, 11);
            dtgNeedToFixCars.Name = "dtgNeedToFixCars";
            dtgNeedToFixCars.ReadOnly = true;
            dtgNeedToFixCars.RowHeadersVisible = false;
            dtgNeedToFixCars.RowHeadersWidth = 51;
            dtgNeedToFixCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgNeedToFixCars.Size = new Size(913, 182);
            dtgNeedToFixCars.TabIndex = 12;
            dtgNeedToFixCars.CellClick += dtgNeedToFixCars_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(913, 11);
            panel3.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(42, 203);
            label13.Name = "label13";
            label13.Size = new Size(50, 22);
            label13.TabIndex = 21;
            label13.Text = "Car ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(253, 203);
            label14.Name = "label14";
            label14.Size = new Size(41, 22);
            label14.TabIndex = 22;
            label14.Text = "Plate";
            // 
            // txtBoxCarID
            // 
            txtBoxCarID.Enabled = false;
            txtBoxCarID.Location = new Point(14, 228);
            txtBoxCarID.Name = "txtBoxCarID";
            txtBoxCarID.Size = new Size(125, 27);
            txtBoxCarID.TabIndex = 17;
            // 
            // txtBoxCarPlate
            // 
            txtBoxCarPlate.Enabled = false;
            txtBoxCarPlate.Location = new Point(219, 228);
            txtBoxCarPlate.Name = "txtBoxCarPlate";
            txtBoxCarPlate.Size = new Size(125, 27);
            txtBoxCarPlate.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtBoxMecID);
            panel6.Controls.Add(txtBoxMecName);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(txtBoxMecSurname);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label16);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 220);
            panel6.Name = "panel6";
            panel6.Size = new Size(913, 100);
            panel6.TabIndex = 26;
            // 
            // txtBoxMecID
            // 
            txtBoxMecID.Anchor = AnchorStyles.None;
            txtBoxMecID.Enabled = false;
            txtBoxMecID.Location = new Point(14, 48);
            txtBoxMecID.Name = "txtBoxMecID";
            txtBoxMecID.Size = new Size(89, 27);
            txtBoxMecID.TabIndex = 18;
            // 
            // txtBoxMecName
            // 
            txtBoxMecName.Anchor = AnchorStyles.None;
            txtBoxMecName.Enabled = false;
            txtBoxMecName.Location = new Point(172, 48);
            txtBoxMecName.Name = "txtBoxMecName";
            txtBoxMecName.Size = new Size(157, 27);
            txtBoxMecName.TabIndex = 16;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new Point(14, 23);
            label15.Name = "label15";
            label15.Size = new Size(89, 22);
            label15.TabIndex = 23;
            label15.Text = "Mechanic ID";
            // 
            // txtBoxMecSurname
            // 
            txtBoxMecSurname.Anchor = AnchorStyles.None;
            txtBoxMecSurname.Enabled = false;
            txtBoxMecSurname.Location = new Point(406, 48);
            txtBoxMecSurname.Name = "txtBoxMecSurname";
            txtBoxMecSurname.Size = new Size(152, 27);
            txtBoxMecSurname.TabIndex = 20;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Location = new Point(406, 23);
            label17.Name = "label17";
            label17.Size = new Size(135, 22);
            label17.TabIndex = 25;
            label17.Text = "Mechanic Surname";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Location = new Point(191, 23);
            label16.Name = "label16";
            label16.Size = new Size(115, 22);
            label16.TabIndex = 24;
            label16.Text = "Mechanic Name";
            // 
            // dtgFreeMecs
            // 
            dtgFreeMecs.AllowUserToAddRows = false;
            dtgFreeMecs.AllowUserToDeleteRows = false;
            dtgFreeMecs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgFreeMecs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgFreeMecs.BackgroundColor = Color.Lavender;
            dtgFreeMecs.BorderStyle = BorderStyle.None;
            dtgFreeMecs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Lavender;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgFreeMecs.DefaultCellStyle = dataGridViewCellStyle3;
            dtgFreeMecs.Dock = DockStyle.Top;
            dtgFreeMecs.Location = new Point(0, 22);
            dtgFreeMecs.Name = "dtgFreeMecs";
            dtgFreeMecs.ReadOnly = true;
            dtgFreeMecs.RowHeadersVisible = false;
            dtgFreeMecs.RowHeadersWidth = 51;
            dtgFreeMecs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgFreeMecs.Size = new Size(913, 198);
            dtgFreeMecs.TabIndex = 11;
            dtgFreeMecs.CellClick += dtgFreeMecs_CellClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Top;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(79, 22);
            label12.TabIndex = 15;
            label12.Text = "Mechanics";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 188);
            label11.Name = "label11";
            label11.Size = new Size(40, 22);
            label11.TabIndex = 14;
            label11.Text = "Cars";
            // 
            // FormBossMechanic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(tabControl1);
            Name = "FormBossMechanic";
            Text = "FormHireMechanic";
            Load += FormHireMechanic_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMechanics).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNeedToFixCars).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgFreeMecs).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dtgMechanics;
        private TabPage tabPage3;
        private Button btnGiveJoba;
        private DataGridView dtgNeedToFixCars;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private TextBox txtBoxCarPlate;
        private TextBox txtBoxMecID;
        private TextBox txtBoxCarID;
        private TextBox txtBoxMecName;
        private TextBox txtBoxMecSurname;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnSave;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txtBoxPsw;
        private TextBox txtBoxMail;
        private TextBox txtBoxPhoneNumber;
        private TextBox txtBoxSurname;
        private TextBox txtBoxName;
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
        private FontAwesome.Sharp.IconButton btnUpdateMec;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private DataGridView dtgFreeMecs;
        private FontAwesome.Sharp.IconButton btnGiveJob;
    }
}