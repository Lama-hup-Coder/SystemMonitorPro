using System;
using System.Drawing;
using System.Windows.Forms;
using SystemMonitorPro.UserControls;

namespace SystemMonitorPro
{
    public partial class frmMainDashboard : Form
    {
        // استدعاء مكتبات الويندوز للتحكم العميق بالنافذة
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // ثوابت النظام لتحريك وإغلاق وتصغير النافذة
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public frmMainDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// دالة عرض الكنترولز: مسؤولة عن تنظيف الواجهة وعرض الصفحة المطلوبة
        /// </summary>
        public void ShowUserControl(UserControl control)
        {
            if (control == null) return;

            // 1. تنظيف الحاوية من أي صفحات سابقة
            PnlMainWorkspace.Controls.Clear();

            // 2. إعداد الصفحة الجديدة لتملأ المساحة
            control.Dock = DockStyle.Fill;
            PnlMainWorkspace.Controls.Add(control);

            // 3. ترتيب الطبقات (Z-Order) لضمان ظهور الأزرار فوق المحتوى
            PnlMainWorkspace.SendToBack();
            pnlSidebar.BringToFront();
            PnlHeader.BringToFront();

            // جلب أزرار التحكم للأمام لضمان قابليتها للضغط
            btnClose.BringToFront();
            btnMinimize.BringToFront();
        }

        // زر الإغلاق الرئيسي (المعتمد في الـ Designer)
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // زر التصغير الرئيسي
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // ترتيب الطبقات عند تشغيل البرنامج لأول مرة
        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            PnlMainWorkspace.SendToBack();
            pnlSidebar.BringToFront();
            PnlHeader.BringToFront();
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSeedDatabase_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("This will generate 7 days of historical CPU data for demonstration purposes. Proceed?",
                                "Demo Mode",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // استدعاء الدالة من طبقة البزنس
                    SystemMonitor_Business.clsSystemMonitorTable.GenerateSeedData();

                    MessageBox.Show("Database seeded successfully! You can now view the history in the charts.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // اختياري: إذا كنتِ تريدين تحديث الشاشة فوراً
                    // btnOverview.PerformClick(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating data: " + ex.Message);
                }
            }
        }
    }

    }

       

        // زر إغلاق إضافي (إذا كنتِ تستخدمين زر button1 للإغلاق أيضاً)



    
    
