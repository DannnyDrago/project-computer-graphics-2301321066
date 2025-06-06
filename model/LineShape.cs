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

            PointF center = new PointF(
                (StartPoint.X + EndPoint.X) / 2,
                (StartPoint.Y + EndPoint.Y) / 2
            );


            PointF relStart = new PointF(StartPoint.X - center.X, StartPoint.Y - center.Y);
            PointF relEnd = new PointF(EndPoint.X - center.X, EndPoint.Y - center.Y);


            relStart = new PointF(relStart.X * ScaleX, relStart.Y * ScaleY);
            relEnd = new PointF(relEnd.X * ScaleX, relEnd.Y * ScaleY);


            PointF rotatedStart = RotatePoint(relStart, new PointF(0, 0), RotationAngle);
            PointF rotatedEnd = RotatePoint(relEnd, new PointF(0, 0), RotationAngle);


            rotatedStart = new PointF(rotatedStart.X + center.X, rotatedStart.Y + center.Y);
            rotatedEnd = new PointF(rotatedEnd.X + center.X, rotatedEnd.Y + center.Y);

            using (Pen pen = new Pen(Color.Black, BorderWidth))
            {
                grfx.DrawLine(pen, rotatedStart, rotatedEnd);
            }
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


        public override void Translate(float dx, float dy)
        {
            StartPoint = new PointF(StartPoint.X + dx, StartPoint.Y + dy);
            EndPoint = new PointF(EndPoint.X + dx, EndPoint.Y + dy);

            Rectangle = new RectangleF(
                Math.Min(StartPoint.X, EndPoint.X),
                Math.Min(StartPoint.Y, EndPoint.Y),
                Math.Abs(EndPoint.X - StartPoint.X),
                Math.Abs(EndPoint.Y - StartPoint.Y)
            );
        }

        public override Shape Clone()
        {
            LineShape copy = new LineShape(this.StartPoint, this.EndPoint)
            {
                FillColor = this.FillColor,
                BorderWidth = this.BorderWidth,
                RotationAngle = this.RotationAngle,

            };
            return copy;
        }

    }
}


