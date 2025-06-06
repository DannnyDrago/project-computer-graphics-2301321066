using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_computer_graphics_2301321066
{
    [Serializable]
    internal class DiamondShape:Shape
    {


        public PointF Top { get; set; }
        public PointF Bottom { get; set; }
        public PointF Left { get; set; }
        public PointF Right { get; set; }

        public DiamondShape(PointF top, PointF bottom, PointF left, PointF right)
        {
            Top = top;
            Bottom = bottom;
            Left = left;
            Right = right;

            float minX = Math.Min(Math.Min(top.X, bottom.X), Math.Min(left.X, right.X));
            float minY = Math.Min(Math.Min(top.Y, bottom.Y), Math.Min(left.Y, right.Y));
            float maxX = Math.Max(Math.Max(top.X, bottom.X), Math.Max(left.X, right.X));
            float maxY = Math.Max(Math.Max(top.Y, bottom.Y), Math.Max(left.Y, right.Y));

            Rectangle = new RectangleF(minX, minY, maxX - minX, maxY - minY);
        }

        public override void DrawSelf(Graphics grfx)
        {
            GraphicsState state = grfx.Save();

            float centerX = Rectangle.X + Rectangle.Width / 2;
            float centerY = Rectangle.Y + Rectangle.Height / 2;

            grfx.TranslateTransform(centerX, centerY);
            grfx.RotateTransform(RotationAngle);
            grfx.ScaleTransform(ScaleX, ScaleY);
            grfx.TranslateTransform(-centerX, -centerY);

            
            PointF[] topTriangle = { Top, Left, Right };
            grfx.FillPolygon(new SolidBrush(FillColor), topTriangle);
            grfx.DrawPolygon(new Pen(Color.Black, BorderWidth), topTriangle);

            
            PointF[] bottomTriangle = { Bottom, Left, Right };
            grfx.FillPolygon(new SolidBrush(FillColor), bottomTriangle);
            grfx.DrawPolygon(new Pen(Color.Black, BorderWidth), bottomTriangle);

              PointF horizontalMid = new PointF(
               (Left.X + Right.X) / 2f,
               (Left.Y + Right.Y) / 2f

               );
            grfx.DrawLine(new Pen(Color.Black, 1), Bottom, horizontalMid);

            grfx.DrawLine(new Pen(Color.Black,1),Left, Right);  
            

            grfx.Restore(state);
        }

        public override bool Contains(PointF point)
        {
            using (var path = new GraphicsPath())
            {
                path.AddPolygon(new PointF[] { Top, Left, Right });
                path.AddPolygon(new PointF[] { Bottom, Left, Right });
                return path.IsVisible(point);
            }
        }

        public override void Translate(float dx, float dy)
        {
            Top = new PointF(Top.X + dx, Top.Y + dy);
            Bottom = new PointF(Bottom.X + dx, Bottom.Y + dy);
            Left = new PointF(Left.X + dx, Left.Y + dy);
            Right = new PointF(Right.X + dx, Right.Y + dy);

            float minX = Math.Min(Math.Min(Top.X, Bottom.X), Math.Min(Left.X, Right.X));
            float minY = Math.Min(Math.Min(Top.Y, Bottom.Y), Math.Min(Left.Y, Right.Y));
            float maxX = Math.Max(Math.Max(Top.X, Bottom.X), Math.Max(Left.X, Right.X));
            float maxY = Math.Max(Math.Max(Top.Y, Bottom.Y), Math.Max(Left.Y, Right.Y));

            Rectangle = new RectangleF(minX, minY, maxX - minX, maxY - minY);
        }

        public override Shape Clone()
        {
            return new DiamondShape(Top, Bottom, Left, Right)
            {
                FillColor = this.FillColor,
                BorderWidth = this.BorderWidth,
                RotationAngle = this.RotationAngle,
                ScaleX = this.ScaleX,
                ScaleY = this.ScaleY
            };
        }

























    }
}
