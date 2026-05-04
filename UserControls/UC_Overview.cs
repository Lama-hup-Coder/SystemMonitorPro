using System;
using System.Drawing;
using System.Windows.Forms;

namespace SystemMonitorPro.UserControls
{
    public partial class UC_Overview : UserControl
    {
        // تعريف التايمر في أعلى الكلاس
        private System.Windows.Forms.Timer _dataTimer;

        public UC_Overview()
        {
            InitializeComponent();

            // إعداد التايمر برمجياً ليعمل في الخلفية
            _dataTimer = new System.Windows.Forms.Timer();
            _dataTimer.Interval = 1000; // تحديث كل ثانية
            _dataTimer.Tick += _dataTimer_Tick;
            _dataTimer.Start();
        }

        private void _dataTimer_Tick(object sender, EventArgs e)
        {
            // جلب القيمة من كلاس البزنس (تأكد من وجود هذا الكلاس في مشروعك)
            try
            {
                float cpuUsage = SystemMonitor_Business.clsCPUPerformance.GetCPULoad();

                // تحديث الواجهة: سنضع شرطاً لكي لا ينهار البرنامج إذا لم تكن قد وضعت الليبل بعد
                UpdateUI(cpuUsage);
            }
            catch { /* تجاهل الخطأ مؤقتاً لضمان استمرار البرنامج */ }
        }

        private void UpdateUI(float cpuValue)
        {
            // ملاحظة: بمجرد أن تسحب Label للمصمم وتسميه 'lblCpuValue' 
            // الكود بالأسفل سيبدأ بالعمل تلقائياً

            if (this.Controls.ContainsKey("lblCpuValue"))
            {
                Control lbl = this.Controls["lblCpuValue"];
                lbl.Text = cpuValue.ToString("0.0") + "%";
                lbl.ForeColor = (cpuValue > 80) ? Color.Red : Color.White;
            }
        }

        private void UC_Overview_Load(object sender, EventArgs e)
        {
            // اتركها فارغة، التنسيق سيكون يدوياً من الـ Designer
        }
    }
}