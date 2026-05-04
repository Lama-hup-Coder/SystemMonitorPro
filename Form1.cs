using System;
using System.Drawing;
using System.Windows.Forms;
// إضافة المسار الخاص باليوزر كنترولز لسهولة الاستخدام
using SystemMonitorPro.UserControls;

namespace SystemMonitorPro
{
    public partial class frmMainDashboard : Form
    {
        // استيراد مكتبات نظام ويندوز للسماح بسحب الفورم من الهيدر
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public frmMainDashboard()
        {
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            // --- ألوان الثيم ---
            Color headerBg = Color.FromArgb(26, 29, 40);
            Color sidebarBg = Color.FromArgb(38, 42, 57);
            Color accentColor = Color.FromArgb(52, 152, 219);

            // --- تنسيق الفورم الرئيسي ---
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(20, 22, 31);

            // --- تنسيق الهيدر ---
            PnlHeader.BackColor = headerBg;
            PnlHeader.Height = 60;
            lblLogo.ForeColor = accentColor;
            lblLogo.Text = "SYSMON PRO";
            lblLogo.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            // --- تنسيق السايد بار ---
            pnlSidebar.BackColor = sidebarBg;
            pnlSidebar.Width = 200;

            // --- تنسيق الأزرار الجانبية ---
            Button[] menuButtons = { btnDashboard, btnOverview, btnMetrics, btnSettings };
            foreach (var btn in menuButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.LightGray;
                btn.Height = 50;
                btn.Dock = DockStyle.Top;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(20, 0, 0, 0);
                btn.Font = new Font("Segoe UI", 10);
                btn.Cursor = Cursors.Hand;
            }
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            // 1. ترتيب الأدوات (Docking) لضمان ملء المساحات بشكل ديناميكي
            PnlHeader.Dock = DockStyle.Top;
            pnlSidebar.Dock = DockStyle.Left;
            PnlMainWorkspace.Dock = DockStyle.Fill;

            // 2. إدارة الطبقات (Z-Order)
            pnlSidebar.BringToFront();
            PnlHeader.BringToFront();
            PnlMainWorkspace.SendToBack();

            // 3. تنسيق اللوجو والأزرار العلوية
            lblLogo.Location = new Point(20, 18);

            // إعداد زر الإغلاق
            btnClose.Size = new Size(35, 35);
            btnClose.Location = new Point(PnlHeader.Width - 45, 12);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Text = "✕";

            // إعداد زر التصغير
            btnMinimize.Size = new Size(35, 35);
            btnMinimize.Location = new Point(btnClose.Left - 40, 12);
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Text = "—";

            // 4. عرض شاشة الـ Overview تلقائياً عند التشغيل (استدعاء واحد فقط)
            ShowUserControl(new UC_Overview());
        }

        // دالة عرض الـ UserControl داخل مساحة العمل
        private void ShowUserControl(UserControl control)
        {
            if (control == null) return;

            PnlMainWorkspace.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PnlMainWorkspace.Controls.Add(control);

            control.Show();
            control.BringToFront();
        }

        // حدث الضغط على زر Overview في القائمة الجانبية
        private void btnOverview_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Overview());
        }

        // حدث إغلاق البرنامج
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // حدث تصغير البرنامج
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // حدث سحب الفورم من الهيدر
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}