using project_computer_graphics_2301321066;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace project_computer_graphics_2301321066
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor

        public DialogProcessor()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
        public bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }

        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private PointF lastLocation;
        public PointF LastLocation
        {
            get { return lastLocation; }
            set { lastLocation = value; }
        }

        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));


            ShapeList.Add(rect);
        }
        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new RectangleF(x, y, 100, 200));



            ShapeList.Add(ellipse);


        }




        public void AddRandomLine()
        {
            Random rnd = new Random();
            float startX = rnd.Next(100, 800);
            float startY = rnd.Next(100, 600);

            float length = 150;

            PointF start = new PointF(startX, startY);
            PointF end = new PointF(startX + length, startY);

            LineShape line = new LineShape(start, end);
            ShapeList.Add(line);
        }

        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            float baseX = rnd.Next(100, 800);
            float baseY = rnd.Next(100, 500);

            float width = 100;
            float height = 100;

            PointF p1 = new PointF(baseX, baseY + height);
            PointF p2 = new PointF(baseX + width, baseY + height);
            PointF p3 = new PointF(baseX + width / 2, baseY);

            TriangleShape triangle = new TriangleShape(p1, p2, p3);
            ShapeList.Add(triangle);
        }
       


        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>

        public Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--)
            {
                if (ShapeList[i].Contains(point))
                {
                    //ShapeList[i].FillColor = Color.Red;

                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>


        public void Translate(PointF p)
        {
            float dx = p.X - lastLocation.X;
            float dy = p.Y - lastLocation.Y;

            foreach (Shape item in Selection)
            {
                item.Translate(dx, dy);
            }

            lastLocation = p;
        }



        public void CopySelection()
        {
            List<Shape> newCopies = new List<Shape>();

            foreach (var shape in Selection)
            {
                Shape clone = shape.Clone();


                clone.Translate(20, 20);

                ShapeList.Add(clone);
                newCopies.Add(clone);
            }


            Selection.Clear();
            Selection.AddRange(newCopies);
        }


        public void SaveShapes(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, ShapeList);
            }
        }


        public void LoadShapes(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                ShapeList = (List<Shape>)formatter.Deserialize(stream);
            }
        }



        public RectangleF CalculateGroupBounds(List<Shape> shapes)
        {
            if (shapes == null || shapes.Count == 0)
                return RectangleF.Empty;

            float left = float.MaxValue;
            float top = float.MaxValue;
            float right = float.MinValue;
            float bottom = float.MinValue;

            foreach (var shape in shapes)
            {
                var rect = shape.Rectangle;
                if (rect.Left < left) left = rect.Left;
                if (rect.Top < top) top = rect.Top;
                if (rect.Right > right) right = rect.Right;
                if (rect.Bottom > bottom) bottom = rect.Bottom;
            }

            return new RectangleF(left, top, right - left, bottom - top);
        }



        public void AddDiamond()
        {
            float centerX = 150;   
            float centerY = 150;
            float halfBase = 100;    
            float height = 40;      

            PointF top = new PointF(centerX, centerY - height);
            PointF bottom = new PointF(centerX, centerY + height);
            PointF left = new PointF(centerX - halfBase, centerY);
            PointF right = new PointF(centerX + halfBase, centerY);

            DiamondShape diamond = new DiamondShape(top, bottom, left, right);
           

            ShapeList.Add(diamond);
        }


    }
}


