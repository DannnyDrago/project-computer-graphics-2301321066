using project_computer_graphics_2301321066;
using System;
using System.Drawing;
using System.Collections.Generic;

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
        private List<Shape> selection =new List<Shape>();
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
                    ShapeList[i].FillColor = Color.Red;

                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public void TranslateTo(PointF p)
        {
            foreach(Shape item in  Selection)
            {
                item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
                lastLocation = p;
            }
        }
    }
}