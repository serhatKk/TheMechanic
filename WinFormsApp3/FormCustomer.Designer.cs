using System.Windows.Forms;

namespace WinFormsApp3
{
    partial class FormCustomer
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
            flowLayoutPanelMessages = new FlowLayoutPanel();
            txtBoxFrom = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            btnSendMsgToMec = new FontAwesome.Sharp.IconButton();
            txtBoxRepyl = new TextBox();
            txtBoxMail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lavender;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1119, 169);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanelMessages
            // 
            flowLayoutPanelMessages.AutoScroll = true;
            flowLayoutPanelMessages.Dock = DockStyle.Left;
            flowLayoutPanelMessages.Location = new Point(0, 169);
            flowLayoutPanelMessages.Name = "flowLayoutPanelMessages";
            flowLayoutPanelMessages.Size = new Size(444, 380);
            flowLayoutPanelMessages.TabIndex = 4;
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFrom.BackColor = Color.SeaShell;
            txtBoxFrom.Enabled = false;
            txtBoxFrom.Location = new Point(52, 8);
            txtBoxFrom.Multiline = true;
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(611, 33);
            txtBoxFrom.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSendMsgToMec);
            panel1.Controls.Add(txtBoxRepyl);
            panel1.Controls.Add(txtBoxMail);
            panel1.Controls.Add(txtBoxFrom);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(444, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 380);
            panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.BackColor = Color.SeaShell;
            textBox1.Enabled = false;
            textBox1.Location = new Point(536, 126);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 380);
            panel2.TabIndex = 13;
            // 
            // btnSendMsgToMec
            // 
            btnSendMsgToMec.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSendMsgToMec.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSendMsgToMec.IconColor = Color.Black;
            btnSendMsgToMec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSendMsgToMec.Location = new Point(536, 305);
            btnSendMsgToMec.Name = "btnSendMsgToMec";
            btnSendMsgToMec.Size = new Size(127, 40);
            btnSendMsgToMec.TabIndex = 11;
            btnSendMsgToMec.Text = "Gönder";
            btnSendMsgToMec.UseVisualStyleBackColor = true;
            btnSendMsgToMec.Click += btnSendMsgToMec_Click;
            // 
            // txtBoxRepyl
            // 
            txtBoxRepyl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxRepyl.BackColor = Color.FromArgb(57, 20, 94);
            txtBoxRepyl.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            txtBoxRepyl.ForeColor = SystemColors.Window;
            txtBoxRepyl.Location = new Point(52, 161);
            txtBoxRepyl.Multiline = true;
            txtBoxRepyl.Name = "txtBoxRepyl";
            txtBoxRepyl.Size = new Size(611, 125);
            txtBoxRepyl.TabIndex = 10;
            // 
            // txtBoxMail
            // 
            txtBoxMail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxMail.BackColor = Color.SeaShell;
            txtBoxMail.Enabled = false;
            txtBoxMail.Location = new Point(52, 47);
            txtBoxMail.Multiline = true;
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.Size = new Size(611, 106);
            txtBoxMail.TabIndex = 9;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 20, 94);
            ClientSize = new Size(1119, 549);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanelMessages);
            Controls.Add(dataGridView1);
            Name = "FormCustomer";
            Tag = "Servisteki Arabalarım";
            Text = "Form1";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListView listView1;
        private FlowLayoutPanel flowLayoutPanelMessages;
        private TextBox txtBoxFrom;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnSendMsgToMec;
        private TextBox txtBoxRepyl;
        private TextBox txtBoxMail;
        private Panel panel2;
        private TextBox textBox1;
    }
}