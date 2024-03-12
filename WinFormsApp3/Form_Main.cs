using System;
using MySql.Data.MySqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using FontAwesome.Sharp;
using System.Windows.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp3

{

    public partial class Form_Main : Form
    {
        private IconButton currentBtn;
        private System.Windows.Forms.Panel leftBorderBtn;
        private Form currentChildForm;

        public bool isCustomerLoggedIn = false;
        public string customerName = "";
        public string customerMail = "";
        public string customerPassword = "";

        public bool isMechanicLoggedIn = false;
        public string mechanicName = "";
        public string mechanicMail = "";
        public string mechanicPassword = "";

        public bool isBossLoggedIn = false;
        public string bossName = "";
        public string bossUsername = "";
        public string bossPassword = "";

        public bool isCollectorLoggedIn = false;
        public string collectorName = "";
        public string collectorMail = "";
        public string collectorPassword = "";


        public Form_Main()
        {

            InitializeComponent();
            this.Load += MainForm_Load;
            leftBorderBtn = new System.Windows.Forms.Panel();
            leftBorderBtn.Size = new Size(7, 78);
            panelMenu.Controls.Add(leftBorderBtn);

            // 
            this.Text = string.Empty;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Color titleBarColor = Color.Black;
            SetTitleBarColor(titleBarColor);
        }

        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        [StructLayout(LayoutKind.Sequential)]
        private struct AccentPolicy
        {
            public int nAccentState;
            public int nFlags;
            public int nColor;
            public int nAnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute nAttribute;
            public IntPtr pData;
            public int ulDataSize;
        }

        private enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }

        private const int ACCENT_ENABLE_GRADIENT =2;
        private const int ACCENT_ENABLE_TRANSPARENTGRADIENT = 2;
        private const int ACCENT_ENABLE_BLURBEHIND = 3;
        private const int ACCENT_ENABLE_ACRYLICBLURBEHIND = 4;
        private const int ACCENT_ENABLE_HOSTBACKDROP = 5;
        private const int ACCENT_ENABLE_NOSELECTION = 6;
        private const int ACCENT_ENABLE_ENABLEMENUANIMATIONS = 7;
        private const int ACCENT_ENABLE_ENABLEWINDOWANIMATIONS = 8;
        private const int ACCENT_ENABLE_DISABLETHEMES = 9;
        private const int ACCENT_ENABLE_TRANSITIONALGRADIENT = 10;
        private const int ACCENT_ENABLE_ENABLELARGEMENUS = 11;

        private void SetTitleBarColor(Color color)
        {
            IntPtr hwnd = this.Handle;

            AccentPolicy accent = new AccentPolicy();
            accent.nAccentState = ACCENT_ENABLE_GRADIENT;
            accent.nFlags = 2;
            accent.nColor = ColorToABGR(color);

            WindowCompositionAttributeData data = new WindowCompositionAttributeData();
            data.nAttribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.pData = Marshal.UnsafeAddrOfPinnedArrayElement(new AccentPolicy[] { accent }, 0);
            data.ulDataSize = Marshal.SizeOf(typeof(AccentPolicy));

            SetWindowCompositionAttribute(hwnd, ref data);
        }

        private int ColorToABGR(Color color)
        {
            return (color.B << 16) | (color.G << 8) | color.R | (color.A << 24);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(86, 11, 163);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //
                iconHome.IconChar = currentBtn.IconChar;
                iconHome.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(47, 21, 74);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (!isCustomerLoggedIn)
            {
                btnUsername.Visible = false;
                btnLogout.Visible = false;
                ActivateButton(sender, RGBColors.color3);
                Form_CustomerLogin frm = new Form_CustomerLogin();
                OpenChildForm(frm);
            }
            else
            {
                btnUsername.Visible = true;
                btnLogout.Visible = true;
                ActivateButton(sender, RGBColors.color3);
                FormCustomerMain form = new FormCustomerMain(customerMail, customerName);
                OpenChildForm(form);
            }
        }



        private void btnMechanic_Click(object sender, EventArgs e)
        {

            if (!isMechanicLoggedIn)
            {
                btnUsername.Visible = false;
                btnLogout.Visible = false;
                ActivateButton(sender, RGBColors.color2);
                FormMechanicLogin frm = new FormMechanicLogin();
                OpenChildForm(frm);
            }
            else
            {
                btnUsername.Visible = true;
                btnLogout.Visible = true;
                ActivateButton(sender, RGBColors.color2);
                Form_Mechanic_Main form = new Form_Mechanic_Main(mechanicMail, mechanicName);
                OpenChildForm(form);
            }

        }

        private void btnCollector_Click(object sender, EventArgs e)
        {
            if (!isCollectorLoggedIn)
            {
                btnUsername.Visible = false;
                btnLogout.Visible = false;
                ActivateButton(sender, RGBColors.color4);
                FormCollectorLogin frm = new FormCollectorLogin();
                OpenChildForm(frm);
            }
            else
            {
                btnUsername.Visible = true;
                btnLogout.Visible = true;
                ActivateButton(sender, RGBColors.color4);
                FormCollectorMain form = new FormCollectorMain(collectorMail, collectorName);
                OpenChildForm(form);
            }

        }

        private void btnBoss_Click(object sender, EventArgs e)
        {
            if (!isBossLoggedIn)
            {
                btnUsername.Visible = false;
                btnLogout.Visible = false;
                ActivateButton(sender, RGBColors.color1);
                FormBossLogin frm = new FormBossLogin();
                OpenChildForm(frm);
            }
            else
            {
                btnUsername.Visible = true;
                btnLogout.Visible = true;
                ActivateButton(sender, RGBColors.color1);
                FormBossMain form = new FormBossMain(bossUsername, bossName);
                OpenChildForm(form);
            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();

            pictureBox1.Visible = true;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            labeltitle.Text = "Home";
            iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void OpenChildForm(Form frm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = frm;
            frm.Owner = this;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            labeltitle.Text = (string)frm.Tag;
            if (frm.Text != "")
            {
                btnUsername.Text = frm.Text;
                btnUsername.Visible = true;
                btnLogout.Visible = true;
            }
            else
            {
                btnLogout.Visible = false;
                btnUsername.Visible = false;
            }
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (isCustomerLoggedIn)
            {
                isCustomerLoggedIn = false;
                customerName = "";
                customerMail = "";
                customerPassword = "";
                Form_CustomerLogin frm = new Form_CustomerLogin();
                OpenChildForm(frm);
            }
            if (isMechanicLoggedIn)
            {
                isMechanicLoggedIn = false;
                mechanicName = "";
                mechanicMail = "";
                mechanicPassword = "";
                FormMechanicLogin frm = new FormMechanicLogin();
                OpenChildForm(frm);
            }
            if (isBossLoggedIn)
            {
                isBossLoggedIn = false;
                bossName = "";
                bossUsername = "";
                bossPassword = "";
                FormBossLogin frm = new FormBossLogin();
                OpenChildForm(frm);
            }
            if (isCollectorLoggedIn)
            {
                isCollectorLoggedIn = false;
                collectorName = "";
                collectorMail = "";
                collectorPassword = "";
                FormCollectorLogin frm = new FormCollectorLogin();
                OpenChildForm(frm);
            }
        }

    }
}

