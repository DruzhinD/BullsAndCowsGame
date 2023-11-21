using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    /// <summary>
    /// собственный рендер, необходимый для изменения цвета выделения
    /// при наведении курсора мышки на элемент ToolStrip
    /// </summary>
    internal class MyRenderer : ToolStripProfessionalRenderer
    {
        private Color _backColor;

        public MyRenderer(Color backColor)
            : base()
        {
            this._backColor = backColor;
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
            else
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);

                //сохраняем цвета в виде списка чисел
                List<int> colorValues = new List<int> { _backColor.R, _backColor.G, _backColor.B };

                if (colorValues[0] <= 255 - 50)
                    colorValues[0] += 50;
                else
                    colorValues[0] = 255;

                if (colorValues[1] <= 255 - 30)
                    colorValues[1] += 30;
                else
                    colorValues[1] = 255;

                //создаем цвета на основании имеющихся чисел
                Color fillingColor = Color.FromArgb(colorValues[0], colorValues[1], colorValues[2]);
                Color borderColor = Color.FromArgb(colorValues[0], colorValues[1], 255);

                //создаем кисть и перо
                Brush brushBackColor = new SolidBrush(fillingColor);
                Pen penBorderColor = new Pen(borderColor);

                //рисуем
                e.Graphics.FillRectangle(brushBackColor, rc);
                e.Graphics.DrawRectangle(penBorderColor, 1, 0, rc.Width - 2, rc.Height - 1);
            }
        }
    }
}
