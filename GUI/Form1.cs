using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace project_computer_graphics_2301321066
{
    public partial class Form1 : Form
    {


        private DialogProcessor dialogProcessor = new DialogProcessor();
        public Form1()
        {

            InitializeComponent();
            this.Width = 1366;
            this.Height = 700;





        }




        Point px, py;
        Pen p = new Pen(Color.Black, 1);

        int index;


        ColorDialog cd = new ColorDialog();



        Color new_color;













        private void btn_ellipse_Click(object sender, EventArgs e)
        {


            dialogProcessor.AddRandomEllipse();
            pic.Invalidate();
        }



        private void btn_rect_Click(object sender, EventArgs e)
        {

            dialogProcessor.AddRandomRectangle();
            pic.Invalidate();
        }


        private void btn_line_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomLine();
            pic.Invalidate();
        }



        private void btn_triangle_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTriangle();
            pic.Invalidate();
        }



        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            g.Clear(Color.White);


            foreach (var shape in dialogProcessor.ShapeList)
            {
                shape.DrawSelf(g);
            }



        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            dialogProcessor.ShapeList.Clear();
            pic.Invalidate();
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                new_color = cd.Color;
                pic_color.BackColor = new_color;
                p.Color = new_color;


                foreach (var shape in dialogProcessor.Selection)
                {
                    shape.FillColor = new_color;
                }

                pic.Invalidate();
            }


        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (Select_mode.Checked)
            {
                Shape sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel != null)
                {

                    if ((ModifierKeys & Keys.Control) == Keys.Control)
                    {
                        if (dialogProcessor.Selection.Contains(sel))
                        {
                            dialogProcessor.Selection.Remove(sel);
                        }
                        else
                        {
                            dialogProcessor.Selection.Add(sel);
                        }
                    }
                    else
                    {
                        dialogProcessor.Selection.Clear();
                        dialogProcessor.Selection.Add(sel);
                    }
                    if (dialogProcessor.Selection.Count == 1)
                    {
                        new_color = dialogProcessor.Selection[0].FillColor;
                        pic_color.BackColor = new_color;
                        p.Color = new_color;
                    }
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    pic.Invalidate();
                }
                else
                {
                    dialogProcessor.Selection.Clear();
                    pic.Invalidate();
                }
            }
        }


        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {

                dialogProcessor.Translate(e.Location);
                pic.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;


        }



        private void transparencySlider_Scroll(object sender, EventArgs e)
        {
            int alpha = transparencySlider.Value;


            Color baseColor = new_color;
            new_color = Color.FromArgb(alpha, baseColor.R, baseColor.G, baseColor.B);

            pic_color.BackColor = new_color;
            p.Color = new_color;

            foreach (var shape in dialogProcessor.Selection)
            {
                shape.FillColor = new_color;
            }

            pic.Invalidate();
        }


        private void borderSlider_Scroll(object sender, EventArgs e)
        {
            float newWidth = borderSlider.Value;

            foreach (var shape in dialogProcessor.Selection)
            {
                shape.BorderWidth = newWidth;
            }

            pic.Invalidate(); // Refresh canvas
        }



        private void rotationSlider_Scroll(object sender, EventArgs e)
        {
            float angle = rotationSlider.Value;

            foreach (var shape in dialogProcessor.Selection)
            {
                shape.Rotate(angle);
            }

            pic.Invalidate();
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (var shape in dialogProcessor.Selection.ToList())
            {
                dialogProcessor.ShapeList.Remove(shape);
            }
            dialogProcessor.Selection.Clear();
            pic.Invalidate();
        }



        private void copy_btn_Click(object sender, EventArgs e)
        {
            dialogProcessor.CopySelection();
            pic.Invalidate();
        }



        private void btn_enlarge_Click(object sender, EventArgs e)
        {
            foreach (var shape in dialogProcessor.Selection)
            {
                shape.ScaleX *= 1.25f;
                shape.ScaleY *= 1.25f;
            }
            pic.Invalidate();
        }



        private void btn_shrink_Click(object sender, EventArgs e)
        {
            foreach (var shape in dialogProcessor.Selection)
            {
                shape.ScaleX *= 0.75f;
                shape.ScaleY *= 0.75f;
            }
            pic.Invalidate();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Shape files (*.shp)|*.shp";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SaveShapes(saveFileDialog.FileName);
            }
        }



        private void load_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Shape files (*.shp)|*.shp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.LoadShapes(openFileDialog.FileName);
                pic.Invalidate();
            }
        }



        private void btn_group_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count > 1)
            {

                RectangleF groupBounds = dialogProcessor.CalculateGroupBounds(dialogProcessor.Selection);


                GroupShape group = new GroupShape(groupBounds);


                foreach (var shape in dialogProcessor.Selection)
                {
                    group.SubShape.Add(shape);
                    dialogProcessor.ShapeList.Remove(shape);
                }


                dialogProcessor.ShapeList.Add(group);

                dialogProcessor.Selection.Clear();
                dialogProcessor.Selection.Add(group);

                pic.Invalidate();
            }
        }

       

        private void btn_ungroup_Click(object sender, EventArgs e)
        {
            var groupsToUngroup = dialogProcessor.Selection
        .OfType<GroupShape>()
        .ToList();

            foreach (var group in groupsToUngroup)
            {

                foreach (var shape in group.SubShape)
                {
                    dialogProcessor.ShapeList.Add(shape);
                }


                dialogProcessor.ShapeList.Remove(group);
            }


            dialogProcessor.Selection.Clear();

            pic.Invalidate();
        }

        private void btn_newshape_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddDiamond();
            pic.Invalidate();
        }


    }



}
