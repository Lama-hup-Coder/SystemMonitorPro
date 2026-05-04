using System;
using System.Drawing;
using System.Windows.Forms;
using SystemMonitorPro.Global;

namespace SystemMonitorPro.UserControls
{
    public partial class UC_Overview : UserControl
    {
        private System.Windows.Forms.Timer _dataTimer;

        public UC_Overview()
        {
            InitializeComponent();
            SetupOverviewLayout();

            // 2. إعداد المؤقت ليبدأ العمل
            _dataTimer = new System.Windows.Forms.Timer();
            _dataTimer.Interval = 1000; // 1000 ميلي ثانية = 1 ثانية
            _dataTimer.Tick += _dataTimer_Tick; // ربطه بدالة التحديث
            _dataTimer.Start(); // ابدأ العمل
        }

        private void _dataTimer_Tick(object sender, EventArgs e)
        {
            // 1. جلب القيمة الحالية من المعالج عبر كلاس البزنس
            float cpuUsage = SystemMonitor_Business.clsCPUPerformance.GetCPULoad();

            // 2. البحث عن الليبل (lblCpuValue) الذي أنشأناه في كود التنسيق وتحديث نصّه
            // نستخدم Find لأن الليبل تم إنشاؤه برمجياً وليس سحباً وإفلاتاً
            Control[] controls = this.Controls.Find("lblCpuValue", true);

            if (controls.Length > 0 && controls[0] is Label lbl)
            {
                lbl.Text = cpuUsage.ToString() + "%";

                // لمسة جمالية: تغيير اللون إذا زاد الاستهلاك عن 80%
                lbl.ForeColor = (cpuUsage > 80) ? Color.Red : Color.White;
            }
        }
        private void SetupOverviewLayout()
        {
            // 1. إعدادات الحاوية
            this.BackColor = UIHelper.Background;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true; // للسماح بالتمرير إذا كانت الشاشة صغيرة

            // 2. العنوان الرئيسي
            Label lblMainTitle = new Label
            {
                Text = "System Health Overview",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = UIHelper.TextPrimary,
                Location = new Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(lblMainTitle);

            // --- توزيع الكروت (Layout Grid) ---

            // كرت CPU Usage (يسار أعلى)
            CreateCard("CPU USAGE", "lblCpuValue", new Point(25, 75), new Size(240, 160));

            // كرت RAM Usage (بجانب الـ CPU)
            CreateCard("RAM MEMORY", "lblRamValue", new Point(280, 75), new Size(240, 160));

            // كرت الـ CPU Trend (الرسم البياني الكبير في المنتصف)
            CreateCard("CPU USAGE TREND", "pnlCpuChart", new Point(25, 250), new Size(495, 250));

            // كرت الـ Alert Log (القائمة الطويلة على اليمين)
            CreateCard("ALERT LOG", "pnlAlerts", new Point(535, 75), new Size(280, 425));

            // كرت الـ Top Processes (أسفل اليسار)
            CreateCard("TOP PROCESSES", "pnlProcesses", new Point(25, 515), new Size(790, 200));
        }

        // دالة موحدة لإنشاء الكروت لتقليل تكرار الكود
        private void CreateCard(string title, string controlName, Point location, Size size)
        {
            Panel pnlCard = new Panel
            {
                Size = size,
                Location = location,
                Name = "pnl_" + controlName
            };
            UIHelper.StyleCardPanel(pnlCard);

            Label lblTitle = new Label
            {
                Text = title,
                Location = new Point(15, 15)
            };
            UIHelper.StyleHeaderLabel(lblTitle);

            // إضافة ليبل للقيمة (Value) أو حاوية للرسم البياني
            if (controlName.Contains("Value"))
            {
                Label lblValue = new Label
                {
                    Text = "0%",
                    Name = controlName,
                    Location = new Point(15, 55)
                };
                UIHelper.StyleValueLabel(lblValue);
                pnlCard.Controls.Add(lblValue);
            }

            pnlCard.Controls.Add(lblTitle);
            this.Controls.Add(pnlCard);
        }

        private void UC_Overview_Load(object sender, EventArgs e) { }
    }
}