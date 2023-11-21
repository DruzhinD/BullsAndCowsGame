using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BullsAndCows
{
    /// <summary>
    /// пользовательский элемент, в котором изменен его цвет при раскрытии списка его элементов,
    /// т.е. обработано событие DropDown
    /// </summary>
    public class CustomToolStripMenuItem : ToolStripMenuItem
    {
        public CustomToolStripMenuItem()
        {
            this.DropDownOpening += CustomToolStripMenuItem_DropDownOpening;
        }

        private void CustomToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.DropDown.Visible)
            {
                Brush brushBack = new SolidBrush(Color.FromArgb(120, BackColor));
                e.Graphics.FillRectangle(brushBack, 0, 0, Size.Width, Size.Height);

                Brush brushFore = new SolidBrush(Color.FromArgb(255, ForeColor));
                e.Graphics.DrawString(Text, this.Font, brushFore, new PointF(7, 1.5f));
            }
        }

    }
}
