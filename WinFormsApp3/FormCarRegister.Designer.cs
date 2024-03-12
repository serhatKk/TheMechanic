namespace WinFormsApp3
{
    partial class FormCarRegister
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDesc = new TextBox();
            textBoxModel = new TextBox();
            textBoxBrand = new TextBox();
            textBoxPlate = new TextBox();
            comboBox1 = new ComboBox();
            databaseConnectionBindingSource = new BindingSource(components);
            label6 = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            txtBoxAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(316, 464);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 21;
            label5.Text = "Collector";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(300, 367);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 20;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(333, 313);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 19;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(337, 255);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 18;
            label2.Text = "Brand";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(343, 207);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 17;
            label1.Text = "Plate";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Anchor = AnchorStyles.None;
            textBoxDesc.Location = new Point(391, 364);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(151, 27);
            textBoxDesc.TabIndex = 15;
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.None;
            textBoxModel.Location = new Point(391, 310);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(151, 27);
            textBoxModel.TabIndex = 14;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Anchor = AnchorStyles.None;
            textBoxBrand.Location = new Point(391, 252);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(151, 27);
            textBoxBrand.TabIndex = 13;
            // 
            // textBoxPlate
            // 
            textBoxPlate.Anchor = AnchorStyles.None;
            textBoxPlate.Location = new Point(391, 204);
            textBoxPlate.Name = "textBoxPlate";
            textBoxPlate.Size = new Size(151, 27);
            textBoxPlate.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(391, 461);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 17;
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(272, 20);
            label6.TabIndex = 26;
            label6.Text = "Servise Gönderebileceğiniz Arabalarınız";
            // 
            // ıconButton1
            // 
            ıconButton1.Anchor = AnchorStyles.None;
            ıconButton1.FlatStyle = FlatStyle.Popup;
            ıconButton1.Font = new Font("Segoe UI", 11F);
            ıconButton1.ForeColor = Color.MintCream;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.VolumeControlPhone;
            ıconButton1.IconColor = Color.Pink;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(630, 261);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(215, 126);
            ıconButton1.TabIndex = 18;
            ıconButton1.Text = "Servis Çağır  ";
            ıconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton1.UseVisualStyleBackColor = true;
            ıconButton1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 20, 94);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(57, 20, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(0, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1148, 109);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(57, 20, 94);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(57, 20, 94);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.GridColor = SystemColors.InfoText;
            dataGridView2.Location = new Point(0, 539);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1148, 137);
            dataGridView2.TabIndex = 30;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(0, 519);
            label7.Name = "label7";
            label7.Size = new Size(253, 20);
            label7.TabIndex = 31;
            label7.Text = "ALINMAYI BEKLEYEN ARABALARINIZ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(316, 410);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 33;
            label8.Text = "Address";
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.Anchor = AnchorStyles.None;
            txtBoxAddress.Location = new Point(391, 410);
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(151, 27);
            txtBoxAddress.TabIndex = 16;
            // 
            // FormCarRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(label8);
            Controls.Add(txtBoxAddress);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(ıconButton1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxBrand);
            Controls.Add(textBoxPlate);
            ForeColor = SystemColors.Control;
            Name = "FormCarRegister";
            Tag = "SERVİS ÇAĞIR";
            Text = "FormCarRegister";
            Load += FormCarRegister_Load;
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDesc;
        private TextBox textBoxModel;
        private TextBox textBoxBrand;
        private TextBox textBoxPlate;
        private ComboBox comboBox1;
        private BindingSource databaseConnectionBindingSource;
        private Label label6;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label7;
        private Label label8;
        private TextBox txtBoxAddress;
    }
}