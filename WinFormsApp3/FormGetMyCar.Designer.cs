namespace WinFormsApp3
{
    partial class FormGetMyCar
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBoxCusName = new TextBox();
            label1 = new Label();
            textBoxPlate = new TextBox();
            lbl = new Label();
            textBoxBrand = new TextBox();
            label4 = new Label();
            textBoxModel = new TextBox();
            label5 = new Label();
            textBoxDesc = new TextBox();
            label6 = new Label();
            textBoxCost = new TextBox();
            btnOkey = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(57, 20, 94);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Lavender;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1119, 169);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(54, 289);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 22;
            label2.Text = "Plate";
            // 
            // textBoxCusName
            // 
            textBoxCusName.BackColor = Color.FromArgb(57, 20, 94);
            textBoxCusName.Enabled = false;
            textBoxCusName.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            textBoxCusName.ForeColor = SystemColors.ButtonHighlight;
            textBoxCusName.Location = new Point(54, 228);
            textBoxCusName.Multiline = true;
            textBoxCusName.Name = "textBoxCusName";
            textBoxCusName.Size = new Size(216, 39);
            textBoxCusName.TabIndex = 21;
            textBoxCusName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(54, 207);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 24;
            label1.Text = "Name";
            // 
            // textBoxPlate
            // 
            textBoxPlate.BackColor = Color.FromArgb(57, 20, 94);
            textBoxPlate.Enabled = false;
            textBoxPlate.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            textBoxPlate.ForeColor = SystemColors.ButtonHighlight;
            textBoxPlate.Location = new Point(54, 310);
            textBoxPlate.Multiline = true;
            textBoxPlate.Name = "textBoxPlate";
            textBoxPlate.Size = new Size(216, 39);
            textBoxPlate.TabIndex = 23;
            textBoxPlate.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = SystemColors.ButtonFace;
            lbl.Location = new Point(370, 207);
            lbl.Name = "lbl";
            lbl.Size = new Size(47, 15);
            lbl.TabIndex = 26;
            lbl.Text = "Brand";
            // 
            // textBoxBrand
            // 
            textBoxBrand.BackColor = Color.FromArgb(57, 20, 94);
            textBoxBrand.Enabled = false;
            textBoxBrand.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            textBoxBrand.ForeColor = SystemColors.ButtonHighlight;
            textBoxBrand.Location = new Point(370, 228);
            textBoxBrand.Multiline = true;
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(216, 39);
            textBoxBrand.TabIndex = 25;
            textBoxBrand.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(370, 289);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 28;
            label4.Text = "Model";
            // 
            // textBoxModel
            // 
            textBoxModel.BackColor = Color.FromArgb(57, 20, 94);
            textBoxModel.Enabled = false;
            textBoxModel.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            textBoxModel.ForeColor = SystemColors.ButtonHighlight;
            textBoxModel.Location = new Point(370, 310);
            textBoxModel.Multiline = true;
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(216, 39);
            textBoxModel.TabIndex = 27;
            textBoxModel.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(648, 207);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 30;
            label5.Text = "Description";
            // 
            // textBoxDesc
            // 
            textBoxDesc.BackColor = Color.FromArgb(57, 20, 94);
            textBoxDesc.Enabled = false;
            textBoxDesc.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            textBoxDesc.ForeColor = SystemColors.ButtonHighlight;
            textBoxDesc.Location = new Point(648, 228);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(216, 39);
            textBoxDesc.TabIndex = 29;
            textBoxDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(648, 289);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 32;
            label6.Text = "Fix Cost";
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = Color.FromArgb(57, 20, 94);
            textBoxCost.Enabled = false;
            textBoxCost.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            textBoxCost.ForeColor = SystemColors.ButtonHighlight;
            textBoxCost.Location = new Point(648, 310);
            textBoxCost.Multiline = true;
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(216, 39);
            textBoxCost.TabIndex = 31;
            textBoxCost.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOkey
            // 
            btnOkey.FlatAppearance.MouseDownBackColor = Color.White;
            btnOkey.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnOkey.FlatStyle = FlatStyle.Flat;
            btnOkey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOkey.ForeColor = Color.GreenYellow;
            btnOkey.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            btnOkey.IconColor = Color.DarkSeaGreen;
            btnOkey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOkey.Location = new Point(370, 398);
            btnOkey.Name = "btnOkey";
            btnOkey.Size = new Size(209, 92);
            btnOkey.TabIndex = 33;
            btnOkey.Text = "TESLİM AL";
            btnOkey.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOkey.UseVisualStyleBackColor = true;
            btnOkey.Click += btnOkey_Click;
            // 
            // FormGetMyCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1119, 549);
            Controls.Add(btnOkey);
            Controls.Add(label6);
            Controls.Add(textBoxCost);
            Controls.Add(label5);
            Controls.Add(textBoxDesc);
            Controls.Add(label4);
            Controls.Add(textBoxModel);
            Controls.Add(lbl);
            Controls.Add(textBoxBrand);
            Controls.Add(label1);
            Controls.Add(textBoxPlate);
            Controls.Add(label2);
            Controls.Add(textBoxCusName);
            Controls.Add(dataGridView1);
            Name = "FormGetMyCar";
            Load += FormGetMyCar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBoxCusName;
        private Label label1;
        private TextBox textBoxPlate;
        private Label lbl;
        private TextBox textBoxBrand;
        private Label label4;
        private TextBox textBoxModel;
        private Label label5;
        private TextBox textBoxDesc;
        private Label label6;
        private TextBox textBoxCost;
        private FontAwesome.Sharp.IconButton btnOkey;
    }
}