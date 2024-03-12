namespace WinFormsApp3
{
    partial class FormCollectorMain
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dateTimePickerArrival = new DateTimePicker();
            txtBoxMail = new TextBox();
            txtBoxPlate = new TextBox();
            txtBoxSurname = new TextBox();
            txtBoxDesc = new TextBox();
            txtBoxName = new TextBox();
            dgtCollectorJobs = new DataGridView();
            txtBoxPhoneNumber = new TextBox();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgtCollectorJobs).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerArrival
            // 
            dateTimePickerArrival.Location = new Point(82, 426);
            dateTimePickerArrival.Name = "dateTimePickerArrival";
            dateTimePickerArrival.Size = new Size(213, 27);
            dateTimePickerArrival.TabIndex = 26;
            // 
            // txtBoxMail
            // 
            txtBoxMail.Enabled = false;
            txtBoxMail.Location = new Point(468, 303);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.Size = new Size(166, 27);
            txtBoxMail.TabIndex = 23;
            // 
            // txtBoxPlate
            // 
            txtBoxPlate.Enabled = false;
            txtBoxPlate.Location = new Point(468, 355);
            txtBoxPlate.Name = "txtBoxPlate";
            txtBoxPlate.Size = new Size(166, 27);
            txtBoxPlate.TabIndex = 19;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Enabled = false;
            txtBoxSurname.Location = new Point(271, 303);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(166, 27);
            txtBoxSurname.TabIndex = 18;
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.Enabled = false;
            txtBoxDesc.Location = new Point(82, 355);
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(168, 27);
            txtBoxDesc.TabIndex = 17;
            // 
            // txtBoxName
            // 
            txtBoxName.Enabled = false;
            txtBoxName.Location = new Point(82, 303);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(168, 27);
            txtBoxName.TabIndex = 16;
            // 
            // dgtCollectorJobs
            // 
            dgtCollectorJobs.AllowUserToAddRows = false;
            dgtCollectorJobs.AllowUserToDeleteRows = false;
            dgtCollectorJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtCollectorJobs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgtCollectorJobs.BackgroundColor = Color.Lavender;
            dgtCollectorJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgtCollectorJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Pink;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgtCollectorJobs.DefaultCellStyle = dataGridViewCellStyle3;
            dgtCollectorJobs.Dock = DockStyle.Top;
            dgtCollectorJobs.GridColor = Color.Black;
            dgtCollectorJobs.Location = new Point(0, 0);
            dgtCollectorJobs.MultiSelect = false;
            dgtCollectorJobs.Name = "dgtCollectorJobs";
            dgtCollectorJobs.ReadOnly = true;
            dgtCollectorJobs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgtCollectorJobs.RowHeadersVisible = false;
            dgtCollectorJobs.RowHeadersWidth = 51;
            dgtCollectorJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtCollectorJobs.ShowEditingIcon = false;
            dgtCollectorJobs.Size = new Size(1148, 232);
            dgtCollectorJobs.TabIndex = 15;
            dgtCollectorJobs.CellClick += dgtCollectorJobs_CellClick;
            // 
            // txtBoxPhoneNumber
            // 
            txtBoxPhoneNumber.Enabled = false;
            txtBoxPhoneNumber.Location = new Point(271, 355);
            txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            txtBoxPhoneNumber.Size = new Size(166, 27);
            txtBoxPhoneNumber.TabIndex = 27;
            // 
            // ıconButton1
            // 
            ıconButton1.FlatAppearance.MouseDownBackColor = Color.White;
            ıconButton1.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ıconButton1.ForeColor = Color.IndianRed;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            ıconButton1.IconColor = Color.FloralWhite;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(333, 408);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(187, 107);
            ıconButton1.TabIndex = 29;
            ıconButton1.Text = "İŞİ TAMAMLA";
            ıconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            ıconButton1.UseVisualStyleBackColor = true;
            ıconButton1.Click += btnCompleteJob_Click;
            // 
            // FormCollectorMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(ıconButton1);
            Controls.Add(txtBoxPhoneNumber);
            Controls.Add(dateTimePickerArrival);
            Controls.Add(txtBoxMail);
            Controls.Add(txtBoxPlate);
            Controls.Add(txtBoxSurname);
            Controls.Add(txtBoxDesc);
            Controls.Add(txtBoxName);
            Controls.Add(dgtCollectorJobs);
            Name = "FormCollectorMain";
            Text = "FormCollectorMain";
            Load += FormCollectorMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgtCollectorJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgtCollectorJobs;
        private DateTimePicker dateTimePickerArrival;
        private TextBox txtBoxMail;
        private TextBox txtBoxPlate;
        private TextBox txtBoxSurname;
        private TextBox txtBoxDesc;
        private TextBox txtBoxName;
        private TextBox txtBoxPhoneNumber;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}