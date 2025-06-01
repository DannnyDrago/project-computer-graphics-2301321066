using System;
using System.Drawing;

namespace project_computer_graphics_2301321066
{
    [Serializable]
    public class LineShape : Shape
    {
        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; set; }

        public LineShape(PointF start, PointF end)
        {
            StartPoint = start;
            EndPoint = end;

            Rectangle = new RectangleF(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(end.X - start.X),
                Math.Abs(end.Y - start.Y)
            );
        }

        public override void DrawSelf(Graphics grfx)
        {
            grfx.DrawLine(Pens.Black, StartPoint, EndPoint);
        }

        public override bool Contains(PointF point)
        {
            const float tolerance = 3f;
            return DistanceToLine(StartPoint, EndPoint, point) <= tolerance;
        }

        private float DistanceToLine(PointF a, PointF b, PointF p)
        {
            float A = p.X - a.X;
            float B = p.Y - a.Y;
            float C = b.X - a.X;
            float D = b.Y - a.Y;

            float dot = A * C + B * D;
            float len_sq = C * C + D * D;
            float param = len_sq != 0 ? dot / len_sq : -1;

            float xx, yy;

            if (param < 0)
            {
                xx = a.X;
                yy = a.Y;
            }
            else if (param > 1)
            {
                xx = b.X;
                yy = b.Y;
            }
            else
            {
                xx = a.X + param * C;
                yy = a.Y + param * D;
            }

            float dx = p.X - xx;
            float dy = p.Y - yy;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}

