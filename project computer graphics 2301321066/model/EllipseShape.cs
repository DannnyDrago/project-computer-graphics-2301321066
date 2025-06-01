using project_computer_graphics_2301321066;
using System;
using System.Drawing;

namespace project_computer_graphics_2301321066
{
    [Serializable]
    public class EllipseShape : Shape
    {
        #region Constructor

        public EllipseShape(RectangleF rect) : base(rect)
        {
        }

        public EllipseShape(RectangleShape rectangle) : base(rectangle)
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

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

        }
    }
}

