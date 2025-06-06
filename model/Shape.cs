using System;
using System.Drawing;

namespace project_computer_graphics_2301321066
{
    [Serializable]
    public abstract class Shape
    {
        #region Constructors

        public Shape()
        {
        }

        public Shape(RectangleF rect)
        {
            rectangle = rect;
        }

        public Shape(Shape shape)
        {
            this.Height = shape.Height;
            this.Width = shape.Width;
            this.Location = shape.Location;
            this.rectangle = shape.rectangle;

            this.FillColor = shape.FillColor;
        }
        #endregion

        #region Properties


        private RectangleF rectangle;
        public virtual RectangleF Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }


        public virtual float Width
        {
            get { return Rectangle.Width; }
            set { rectangle.Width = value; }
        }

        public virtual float Height
        {
            get { return Rectangle.Height; }
            set { rectangle.Height = value; }
        }


        public virtual PointF Location
        {
            get { return Rectangle.Location; }
            set { rectangle.Location = value; }
        }

        private Color fillColor;
        public virtual Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }


        private float borderWidth = 1.0f;
        public virtual float BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; }
        }
        #endregion


        public virtual bool Contains(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }


        public virtual void DrawSelf(Graphics grfx)
        {
            // shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
        }
        public virtual void Translate(float dx, float dy)
        {

            Rectangle = new RectangleF(Rectangle.X + dx, Rectangle.Y + dy, Rectangle.Width, Rectangle.Height);
        }


        public virtual float RotationAngle { get; set; } = 0f;


        public virtual void Rotate(float angleInDegrees)
        {
            RotationAngle = angleInDegrees;
        }


        protected PointF RotatePoint(PointF point, PointF center, float angle)
        {
            float radians = angle * (float)Math.PI / 180f;
            float cos = (float)Math.Cos(radians);
            float sin = (float)Math.Sin(radians);

            float dx = point.X - center.X;
            float dy = point.Y - center.Y;

            return new PointF(
                cos * dx - sin * dy + center.X,
                sin * dx + cos * dy + center.Y
            );
        }

        public float ScaleX { get; set; } = 1f;
        public float ScaleY { get; set; } = 1f;

        public abstract Shape Clone();


    }
}