using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SystemMonitor_Business;

namespace SystemMonitorPro.UserControls
{
    public partial class UC_Overview : UserControl
    {
        // تعريف الحساس
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public UC_Overview()
        {
            InitializeComponent();
        }

        private void UC_Overview_Load(object sender, EventArgs e)
        {
            // تأكدي من الخطوة رقم 1 (إضافة التايمر للتصميم) لكي لا يظهر خطأ هنا
            timer1.Start();

            LoadCPUChart();
        }

        private int _secondsCounter = 0; // عداد لحساب الثواني خارج الدالة

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                LoadCPUChart();
                // 1. جلب القراءة الحقيقية للعرض (تحدث كل ثانية)
                float cpuUsage = SystemMonitor_Business.clsCPUPerformance.GetCPULoad();
                lblCpuValue.Text = cpuUsage.ToString("0.0") + "%";

                // التنسيق البصري (UX)
                lblCpuValue.ForeColor = (cpuUsage > 80) ? Color.Red : Color.White;

                // 2. منطق الحفظ التلقائي (كل 60 ثانية)
                _secondsCounter++;

                if (_secondsCounter >= 60)
                {
                   // هذا الجزء معلق للحفاظ على موارد جهازك، احذفي التعليق لتفعيله ---

                    //clsSystemMonitorTable liveRecord = new clsSystemMonitorTable();
                    //liveRecord.CPUUsage = (decimal)cpuUsage;
                    //liveRecord.RecordTime = DateTime.Now;
                    //liveRecord.Save(); 

                   // ------------------------------------------------------------------- */

                    _secondsCounter = 0; // تصوير العداد للبدء بدقيقة جديدة
                }
            }
            catch (Exception ex)
            {
                // لماذا نكتب كود هنا؟
                // 1. لتسجيل الخطأ (Logging) دون إزعاج المستخدم.
                // 2. لتجنب الـ Crash إذا فقد البرنامج الاتصال بقاعدة البيانات فجأة.

                Console.WriteLine("Error in Timer: " + ex.Message);
                // أو يمكنك كتابة lblStatus.Text = "Monitor Error...";
            }
        }


        private void LoadCPUChart()
        {
            // 1. جلب البيانات من الداتا لير
            DataTable dt = clsCPUPerformance.GetAll();

            // 2. إعدادات المظهر العام (توضع هنا لضمان تطبيقها في كل تحديث)
            chartCPU.BackColor = Color.FromArgb(24, 30, 54);

            if (chartCPU.ChartAreas.Count == 0) chartCPU.ChartAreas.Add("MainArea");
            var area = chartCPU.ChartAreas[0];

            // تلوين منطقة الرسم والشبكة
            area.BackColor = Color.FromArgb(37, 42, 64);
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(45, 50, 80);
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(45, 50, 80);
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash; // خطوط منقطة لجمالية أكثر

            // إخفاء الـ Legend (المربع الجانبي) كما في الصورة h4tis0h4tis0h4ti_5.png
            if (chartCPU.Legends.Count > 0) chartCPU.Legends[0].Enabled = false;

            // 3. إعداد السلسلة (Series)
            Series series = chartCPU.Series.FindByName("CPU Usage (%)");
            if (series == null)
            {
                series = new Series("CPU Usage (%)");
                series.ChartType = SeriesChartType.SplineArea; // منحنٍ وممتلئ من الأسفل
                series.Color = Color.FromArgb(0, 126, 249);
                series.BackGradientStyle = GradientStyle.TopBottom;
                series.BackSecondaryColor = Color.FromArgb(50, 0, 126, 249);
                series.BorderWidth = 3;
                chartCPU.Series.Add(series);
            }

            // 4. تحديث النقاط (الحركة)
            series.Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                // عرض الوقت فقط بدون التاريخ لمنع الزحام أسفل التشارت
                DateTime time = Convert.ToDateTime(row["RecordTime"]);
                series.Points.AddXY(time.ToString("HH:mm:ss"), row["CPUUsage"]);
            }

            // 5. ضبط الحدود النهائية
            area.AxisY.Maximum = 100;
            area.AxisY.Minimum = 0;
            area.AxisX.LabelStyle.ForeColor = Color.Silver;
            area.AxisY.LabelStyle.ForeColor = Color.Silver;

            chartCPU.ResetAutoValues(); // لإجبار التشارت على تحديث الحركة فوراً
        }
    }
}