using project_computer_graphics_2301321066;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace project_computer_graphics_2301321066
{
    [Serializable]
    public class RectangleShape : Shape
    {
        #region Constructor

        public RectangleShape(RectangleF rect) : base(rect)
        {
        }

        public RectangleShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))

                return true;
            else

                return false;
        }


        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            GraphicsState state = grfx.Save();

            float centerX = Rectangle.X + Rectangle.Width / 2;
            float centerY = Rectangle.Y + Rectangle.Height / 2;


            grfx.TranslateTransform(centerX, centerY);
            grfx.RotateTransform(RotationAngle);
            grfx.ScaleTransform(ScaleX, ScaleY);
            grfx.TranslateTransform(-centerX, -centerY);

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            using (Pen pen = new Pen(Color.Black, BorderWidth))
            {
                grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            }

            grfx.Restore(state);
        }
        public override Shape Clone()
        {
            RectangleShape copy = new RectangleShape(this.Rectangle)
            {
                FillColor = this.FillColor,
                BorderWidth = this.BorderWidth,
                RotationAngle = this.RotationAngle,
                ScaleX = this.ScaleX,
                ScaleY = this.ScaleY,

            };
            return copy;
        }

    }
}
