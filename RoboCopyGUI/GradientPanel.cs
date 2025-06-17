using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RoboCopyGUI
{
    public class GradientPanel : Panel
    {
        public Color GradientStartColor { get; set; } = Color.FromArgb(102, 126, 234);
        public Color GradientEndColor { get; set; } = Color.FromArgb(118, 75, 162);
        public float Angle { get; set; } = 90f;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (ClientRectangle.Width == 0 || ClientRectangle.Height == 0)
                return;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle,
                GradientStartColor,
                GradientEndColor,
                Angle))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }
    }
}