using System;
using System.Drawing;

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
            PointF[] points = { Point1, Point2, Point3 };
            grfx.FillPolygon(new SolidBrush(FillColor), points);
            grfx.DrawPolygon(Pens.Black, points);
        }

        public override bool Contains(PointF point)
        {
            PointF[] triangle = { Point1, Point2, Point3 };
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddPolygon(triangle);
                return path.IsVisible(point);
            }
        }
    }
}