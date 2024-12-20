namespace ProjectMeneger.Components
{
    public class UserDropList : Control
    {
        private StringFormat triangle = new StringFormat();
        private List<string> elements = new List<string>();
        

        private ListBox listBox;

        public Color SawingLineColor { get; set; }

        public UserDropList()
        {
            SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw |
            ControlStyles.SupportsTransparentBackColor |
            ControlStyles.UserPaint,
            true);

            DoubleBuffered = true;
            Size = new Size(150, 40);
            BackColor = Color.Beige;
            Cursor = Cursors.Hand;

            SawingLineColor = Color.Gray;

            triangle.Alignment = StringAlignment.Center;
            triangle.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            graphics.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            graphics.DrawRectangle(new Pen(BackColor), rect);
            graphics.FillRectangle(new SolidBrush(BackColor), rect);

            Rectangle sawingLine = new Rectangle(Width - 30, 1, 2, Height - 2);

            graphics.FillRectangle(new SolidBrush(SawingLineColor), sawingLine);

            Rectangle downButton = new Rectangle(Width - 28, 1, 30, Height - 2);

            graphics.DrawString("▼", Font, new SolidBrush(SawingLineColor), downButton, triangle);

            Rectangle downList = new Rectangle(0, Height, Width - 1, 100);

            

            graphics.FillRectangle(new SolidBrush(BackColor), downList);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            

        }
    }


}
