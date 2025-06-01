using System;
using System.Collections.Generic;
using System.Drawing;
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
            foreach (Shape shape in SubShape)
            {
                shape.DrawSelf(grfx);
            }
        }
    }
}

