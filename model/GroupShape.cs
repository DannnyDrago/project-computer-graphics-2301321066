using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using project_computer_graphics_2301321066;

namespace project_computer_graphics_2301321066
{
    [Serializable]
    public class GroupShape : Shape
    {
        #region Constructor

        public GroupShape(RectangleF rect) : base(rect)
        {
        }

        public GroupShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        public List<Shape> SubShape = new List<Shape>();

        #endregion
        private Color fillColor;
        public override Color FillColor
        {
            get => fillColor;
            set
            {
                fillColor = value;
                foreach (var shape in SubShape)
                {
                    shape.FillColor = value;
                }
            }
        }

        private float borderWidth;
        public override float BorderWidth
        {
            get => borderWidth;
            set
            {
                borderWidth = value;
                foreach (var shape in SubShape)
                {
                    shape.BorderWidth = value;
                }
            }
        }
        public override bool Contains(PointF point)
        {
            foreach (Shape shape in SubShape)
            {
                if (shape.Contains(point))
                {
                    return true;
                }
            }
            return false;
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




            foreach (Shape shape in SubShape)
            {
                shape.DrawSelf(grfx);
            }

            grfx.Restore(state);

        }



        public override Shape Clone()
        {
            GroupShape copy = new GroupShape(this.Rectangle)
            {
                FillColor = this.FillColor,
                BorderWidth = this.BorderWidth,
                RotationAngle = this.RotationAngle,
                ScaleX = this.ScaleX,
                ScaleY = this.ScaleY,

            };

            foreach (Shape shape in SubShape)
            {
                copy.SubShape.Add(shape.Clone());
            }

            return copy;
        }

        public override void Translate(float dx, float dy)
        {
            Rectangle = new RectangleF(Rectangle.X + dx, Rectangle.Y + dy, Rectangle.Width, Rectangle.Height);

            foreach (Shape shape in SubShape)
            {
                shape.Translate(dx, dy);
            }
        }


    }
}
