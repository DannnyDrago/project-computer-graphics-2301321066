using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace project_computer_graphics_2301321066
{
    [Serializable]
    public class TriangleShape : Shape
    {
        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }
        public PointF Point3 { get; set; }

        public TriangleShape(PointF p1, PointF p2, PointF p3)
        {
            Point1 = p1;
            Point2 = p2;
            Point3 = p3;

            float minX = Math.Min(p1.X, Math.Min(p2.X, p3.X));
            float minY = Math.Min(p1.Y, Math.Min(p2.Y, p3.Y));
            float maxX = Math.Max(p1.X, Math.Max(p2.X, p3.X));
            float maxY = Math.Max(p1.Y, Math.Max(p2.Y, p3.Y));

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

            PointF[] points = { Point1, Point2, Point3 };
            grfx.FillPolygon(new SolidBrush(FillColor), points);

            using (Pen pen = new Pen(Color.Black, BorderWidth))
            {
                grfx.DrawPolygon(pen, points);
            }

            grfx.Restore(state);
        }


        public override bool Contains(PointF point)
        {
            using (var path = new GraphicsPath())
            {
                path.AddPolygon(new PointF[] { Point1, Point2, Point3 });
                return path.IsVisible(point);
            }
        }

        public override void Translate(float dx, float dy)
        {
            Point1 = new PointF(Point1.X + dx, Point1.Y + dy);
            Point2 = new PointF(Point2.X + dx, Point2.Y + dy);
            Point3 = new PointF(Point3.X + dx, Point3.Y + dy);

            float minX = Math.Min(Point1.X, Math.Min(Point2.X, Point3.X));
            float minY = Math.Min(Point1.Y, Math.Min(Point2.Y, Point3.Y));
            float maxX = Math.Max(Point1.X, Math.Max(Point2.X, Point3.X));
            float maxY = Math.Max(Point1.Y, Math.Max(Point2.Y, Point3.Y));

            Rectangle = new RectangleF(minX, minY, maxX - minX, maxY - minY);
        }

        public override Shape Clone()
        {
            TriangleShape copy = new TriangleShape(
                new PointF(Point1.X, Point1.Y),
                new PointF(Point2.X, Point2.Y),
                new PointF(Point3.X, Point3.Y))
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