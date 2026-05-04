using System.Drawing;
using System.Windows.Forms;

namespace SystemMonitorPro.Global
{
    public static class UIHelper
    {
        // --- الألوان الأساسية ---
        public static Color Background = Color.FromArgb(20, 22, 31);
        public static Color CardColor = Color.FromArgb(26, 29, 40);
        public static Color AccentColor = Color.FromArgb(52, 152, 219); // أزرق مريح
        public static Color TextPrimary = Color.White;
        public static Color TextSecondary = Color.FromArgb(150, 150, 150);

        // --- دوال التنسيق الموحدة ---

        // تنسيق البطاقات (التي ستحتوي على الرسوم البيانية)
        public static void StyleCardPanel(Panel pnl)
        {
            pnl.BackColor = CardColor;
            pnl.Padding = new Padding(15);
        }

        // تنسيق العناوين داخل البطاقات
        public static void StyleHeaderLabel(Label lbl)
        {
            lbl.ForeColor = TextPrimary;
            lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lbl.AutoSize = true;
        }

        // تنسيق القيم الرقمية (مثل 45%)
        public static void StyleValueLabel(Label lbl)
        {
            lbl.ForeColor = AccentColor;
            lbl.Font = new Font("Segoe UI Semibold", 14);
            lbl.AutoSize = true;
        }
    }
}