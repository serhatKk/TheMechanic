using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WinFormsApp3
{
    partial class Form_Mechanic_Main
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
            dataGridView1 = new DataGridView();
            txtBoxName = new TextBox();
            dateTimePickerDeliver = new DateTimePicker();
            dateTimePickerArrival = new DateTimePicker();
            btnCompleteJob = new FontAwesome.Sharp.IconButton();
            btnChangeDate = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label6 = new Label();
            textBoxFixCost = new TextBox();
            label5 = new Label();
            txtBoxPlate = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtBoxDesc = new TextBox();
            label3 = new Label();
            txtBoxSurname = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            txtBoxMailDesc = new TextBox();
            txtBoxRMail = new TextBox();
            txtBoxMail = new TextBox();
            txtBoxDate = new TextBox();
            btnSendMessage = new FontAwesome.Sharp.IconButton();
            flowLayoutPanelMessages = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lavender;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1148, 232);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dtgMechanicJobs_CellClick;
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxName.Enabled = false;
            txtBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtBoxName.ForeColor = SystemColors.ButtonHighlight;
            txtBoxName.Location = new Point(12, 57);
            txtBoxName.Multiline = true;
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(216, 39);
            txtBoxName.TabIndex = 2;
            txtBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePickerDeliver
            // 
            dateTimePickerDeliver.CalendarForeColor = SystemColors.ButtonHighlight;
            dateTimePickerDeliver.CalendarMonthBackground = Color.FromArgb(57, 20, 94);
            dateTimePickerDeliver.CalendarTitleBackColor = SystemColors.Control;
            dateTimePickerDeliver.CalendarTitleForeColor = Color.FromArgb(57, 20, 94);
            dateTimePickerDeliver.CalendarTrailingForeColor = SystemColors.ButtonHighlight;
            dateTimePickerDeliver.Location = new Point(241, 219);
            dateTimePickerDeliver.Name = "dateTimePickerDeliver";
            dateTimePickerDeliver.Size = new Size(219, 27);
            dateTimePickerDeliver.TabIndex = 13;
            // 
            // dateTimePickerArrival
            // 
            dateTimePickerArrival.CalendarForeColor = SystemColors.ButtonHighlight;
            dateTimePickerArrival.CalendarMonthBackground = Color.FromArgb(57, 20, 94);
            dateTimePickerArrival.CalendarTitleBackColor = SystemColors.Control;
            dateTimePickerArrival.CalendarTitleForeColor = Color.FromArgb(57, 20, 94);
            dateTimePickerArrival.CalendarTrailingForeColor = SystemColors.ControlDark;
            dateTimePickerArrival.Enabled = false;
            dateTimePickerArrival.Location = new Point(3, 219);
            dateTimePickerArrival.Name = "dateTimePickerArrival";
            dateTimePickerArrival.Size = new Size(219, 27);
            dateTimePickerArrival.TabIndex = 14;
            // 
            // btnCompleteJob
            // 
            btnCompleteJob.FlatAppearance.MouseDownBackColor = Color.White;
            btnCompleteJob.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnCompleteJob.FlatStyle = FlatStyle.Flat;
            btnCompleteJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnCompleteJob.ForeColor = Color.GreenYellow;
            btnCompleteJob.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            btnCompleteJob.IconColor = Color.DarkSeaGreen;
            btnCompleteJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompleteJob.Location = new Point(117, 340);
            btnCompleteJob.Name = "btnCompleteJob";
            btnCompleteJob.Size = new Size(209, 92);
            btnCompleteJob.TabIndex = 15;
            btnCompleteJob.Text = "İŞİ TAMAMLA";
            btnCompleteJob.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompleteJob.UseVisualStyleBackColor = true;
            btnCompleteJob.Click += btnCompleteJob_Click;
            // 
            // btnChangeDate
            // 
            btnChangeDate.FlatAppearance.MouseDownBackColor = Color.White;
            btnChangeDate.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnChangeDate.FlatStyle = FlatStyle.Flat;
            btnChangeDate.Font = new Font("Segoe UI", 10F);
            btnChangeDate.ForeColor = SystemColors.HighlightText;
            btnChangeDate.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            btnChangeDate.IconColor = Color.LightSkyBlue;
            btnChangeDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangeDate.IconSize = 22;
            btnChangeDate.Location = new Point(245, 333);
            btnChangeDate.Name = "btnChangeDate";
            btnChangeDate.Size = new Size(219, 0);
            btnChangeDate.TabIndex = 16;
            btnChangeDate.Text = "Teslim Tarihi Değiştir";
            btnChangeDate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangeDate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxFixCost);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxPlate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxDesc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxSurname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBoxName);
            panel1.Controls.Add(btnChangeDate);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnCompleteJob);
            panel1.Controls.Add(dateTimePickerArrival);
            panel1.Controls.Add(dateTimePickerDeliver);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 444);
            panel1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 17F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(41, 292);
            label6.Name = "label6";
            label6.Size = new Size(133, 29);
            label6.TabIndex = 28;
            label6.Text = "Fix Cost";
            // 
            // textBoxFixCost
            // 
            textBoxFixCost.BackColor = Color.FromArgb(57, 20, 94);
            textBoxFixCost.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            textBoxFixCost.ForeColor = SystemColors.ButtonHighlight;
            textBoxFixCost.Location = new Point(190, 285);
            textBoxFixCost.Name = "textBoxFixCost";
            textBoxFixCost.PlaceholderText = "100";
            textBoxFixCost.Size = new Size(197, 34);
            textBoxFixCost.TabIndex = 27;
            textBoxFixCost.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(263, 124);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 26;
            label5.Text = "Plate";
            // 
            // txtBoxPlate
            // 
            txtBoxPlate.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxPlate.Enabled = false;
            txtBoxPlate.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtBoxPlate.ForeColor = SystemColors.ButtonHighlight;
            txtBoxPlate.Location = new Point(263, 165);
            txtBoxPlate.Multiline = true;
            txtBoxPlate.Name = "txtBoxPlate";
            txtBoxPlate.Size = new Size(197, 42);
            txtBoxPlate.TabIndex = 25;
            txtBoxPlate.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(57, 20, 94);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 20;
            label1.Text = "Jobs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 24;
            label4.Text = "Description";
            // 
            // txtBoxDesc
            // 
            txtBoxDesc.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxDesc.Enabled = false;
            txtBoxDesc.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtBoxDesc.ForeColor = SystemColors.ButtonHighlight;
            txtBoxDesc.Location = new Point(12, 142);
            txtBoxDesc.Multiline = true;
            txtBoxDesc.Name = "txtBoxDesc";
            txtBoxDesc.Size = new Size(219, 60);
            txtBoxDesc.TabIndex = 23;
            txtBoxDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(263, 36);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 22;
            label3.Text = "Surname";
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxSurname.Enabled = false;
            txtBoxSurname.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtBoxSurname.ForeColor = SystemColors.ButtonHighlight;
            txtBoxSurname.Location = new Point(263, 57);
            txtBoxSurname.Multiline = true;
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(197, 39);
            txtBoxSurname.TabIndex = 21;
            txtBoxSurname.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(476, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 444);
            panel3.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtBoxMailDesc);
            panel2.Controls.Add(txtBoxRMail);
            panel2.Controls.Add(txtBoxMail);
            panel2.Controls.Add(txtBoxDate);
            panel2.Controls.Add(btnSendMessage);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(486, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 444);
            panel2.TabIndex = 18;
            // 
            // txtBoxMailDesc
            // 
            txtBoxMailDesc.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxMailDesc.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtBoxMailDesc.ForeColor = SystemColors.ButtonHighlight;
            txtBoxMailDesc.Location = new Point(19, 165);
            txtBoxMailDesc.Multiline = true;
            txtBoxMailDesc.Name = "txtBoxMailDesc";
            txtBoxMailDesc.Size = new Size(316, 129);
            txtBoxMailDesc.TabIndex = 30;
            // 
            // txtBoxRMail
            // 
            txtBoxRMail.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxRMail.Enabled = false;
            txtBoxRMail.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txtBoxRMail.ForeColor = SystemColors.ButtonHighlight;
            txtBoxRMail.Location = new Point(19, 43);
            txtBoxRMail.Multiline = true;
            txtBoxRMail.Name = "txtBoxRMail";
            txtBoxRMail.Size = new Size(316, 82);
            txtBoxRMail.TabIndex = 29;
            // 
            // txtBoxMail
            // 
            txtBoxMail.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxMail.Enabled = false;
            txtBoxMail.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            txtBoxMail.ForeColor = SystemColors.ButtonHighlight;
            txtBoxMail.Location = new Point(19, 12);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.Size = new Size(237, 25);
            txtBoxMail.TabIndex = 28;
            txtBoxMail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxDate
            // 
            txtBoxDate.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxDate.Enabled = false;
            txtBoxDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            txtBoxDate.Location = new Point(171, 124);
            txtBoxDate.Name = "txtBoxDate";
            txtBoxDate.Size = new Size(164, 27);
            txtBoxDate.TabIndex = 27;
            // 
            // btnSendMessage
            // 
            btnSendMessage.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            btnSendMessage.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnSendMessage.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnSendMessage.FlatStyle = FlatStyle.Flat;
            btnSendMessage.Font = new Font("Segoe UI", 12F);
            btnSendMessage.ForeColor = Color.DarkSeaGreen;
            btnSendMessage.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnSendMessage.IconColor = SystemColors.ControlDark;
            btnSendMessage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSendMessage.Location = new Point(67, 347);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(216, 85);
            btnSendMessage.TabIndex = 12;
            btnSendMessage.Text = "Send Message";
            btnSendMessage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // flowLayoutPanelMessages
            // 
            flowLayoutPanelMessages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelMessages.AutoScroll = true;
            flowLayoutPanelMessages.Location = new Point(843, 232);
            flowLayoutPanelMessages.Margin = new Padding(10);
            flowLayoutPanelMessages.Name = "flowLayoutPanelMessages";
            flowLayoutPanelMessages.Size = new Size(305, 444);
            flowLayoutPanelMessages.TabIndex = 13;
            // 
            // Form_Mechanic_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1148, 676);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanelMessages);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form_Mechanic_Main";
            Text = "Form_Mechanic_Main";
            Load += Form_Mechanic_Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBoxName;
        private Button btnChangeDatea;
        private DateTimePicker dateTimePickerDeliver;
        private DateTimePicker dateTimePickerArrival;
        private FontAwesome.Sharp.IconButton btnCompleteJob;
        private FontAwesome.Sharp.IconButton btnChangeDate;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSendMessage;
        private Panel panel3;
        private Label label1;
        private Label label5;
        private TextBox txtBoxPlate;
        private Label label4;
        private TextBox txtBoxDesc;
        private Label label3;
        private TextBox txtBoxSurname;
        private Label label2;
        private TextBox txtBoxDate;
        private TextBox txtBoxMail;
        private TextBox textBox1;
        private TextBox txtBoxRMail;
        private TextBox txtBoxMailDesc;
        private FlowLayoutPanel flowLayoutPanelMessages;
        private Label label6;
        private TextBox textBoxFixCost;
    }
}