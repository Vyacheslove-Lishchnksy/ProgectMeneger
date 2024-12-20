using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ProjectMeneger.Components
{
    public class UserButton : Control
    {
        private StringFormat stringFormat = new StringFormat();
        private bool isMouseEntered = false;

        public int ButtonRoundRadius { get; set; }

        public UserButton() { 
        SetStyle(
            ControlStyles.AllPaintingInWmPaint | 
            ControlStyles.OptimizedDoubleBuffer | 
            ControlStyles.ResizeRedraw | 
            ControlStyles.SupportsTransparentBackColor | 
            ControlStyles.UserPaint,
            true);

            DoubleBuffered = true;
            Size = new Size(100, 30);
            BackColor = Color.Beige;
            Cursor = Cursors.Hand;

            ButtonRoundRadius = 50;

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            graphics.SmoothingMode = SmoothingMode.HighQuality;

            graphics.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            if (ButtonRoundRadius != 0)
            {
                GraphicsPath path = GetRoundPath(rect, ButtonRoundRadius);

                graphics.DrawPath(new Pen(BackColor), path);

                graphics.FillPath(new SolidBrush(BackColor), path);
                if (isMouseEntered)
                {
                    graphics.DrawPath(new Pen(Color.FromArgb(60, Color.White)), path);
                    graphics.FillPath(new SolidBrush(Color.FromArgb(60, Color.White)), path);
                }
            }
            else
            {
                graphics.DrawRectangle(new Pen(BackColor), rect);
                graphics.FillRectangle(new SolidBrush(BackColor), rect);

                if (isMouseEntered)
                {
                    graphics.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
                    graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);
                }


            }

            
            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), rect, stringFormat);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isMouseEntered = true;

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isMouseEntered = false;

            Invalidate();
        }

        private GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
                float r2 = radius / 2f;
                GraphicsPath GraphPath = new GraphicsPath();

                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                    Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

                GraphPath.CloseFigure();
                return GraphPath;
        }

    }
}
