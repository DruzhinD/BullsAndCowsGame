using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BullsAndCows
{
    public class RoundedButton : Button
    {
        //поля
        private int borderSize = 0;
        [Category("Мои свойства")]
        public int BorderSize 
        { 
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            } 
        }

        private int borderRadius = 40;
        [Category("Мои свойства")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value <= Height)
                    borderRadius = value;
                else
                    borderRadius = Height;
                this.Invalidate();
            }
        }

        private Color borderColor = Color.FromArgb(162, 94, 66);
        [Category("Мои свойства")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Мои свойства")]
        public Color BackgroundColor { get => BackColor; set => BackColor = value; }
        [Category("Мои свойства")]
        public Color TextColor { get => ForeColor; set => ForeColor = value; }


        //конструктор
        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.FromArgb(203, 126, 90);
            ForeColor = Color.FromArgb(144, 77, 60);
            this.Resize += new EventHandler(Button_Resize);
        }

        //методы
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(0.001f, 0.001f, this.Width - 0.2f, this.Height - 0.2f);

            //закругленная кнопка
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 1))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //поверхность кнопки
                    this.Region = new Region(pathSurface);
                    //рисуем поверхность границы в HD качестве
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //граница кнопки
                    if (borderSize >= 1)
                        //draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            //обычная кнопка
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                BorderRadius = Height;
        }
    }
}
