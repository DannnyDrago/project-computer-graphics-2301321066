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

namespace project_computer_graphics_2301321066
{
    public partial class Form1 : Form
    {


        private DialogProcessor dialogProcessor=new DialogProcessor();
        public Form1()
        {

            InitializeComponent();
            this.Width = 1300;
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
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor=cd.Color;
            p.Color=cd.Color;
            

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (Select_mode.Checked)
            {
                Shape sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel != null)
                {
                    if (dialogProcessor.Selection.Contains(sel))
                        dialogProcessor.Selection.Remove(sel);
                    else
                        dialogProcessor.Selection.Add(sel);







                }
                dialogProcessor.IsDragging = true;
                dialogProcessor.LastLocation = e.Location;
                pic.Invalidate();


            };
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                
                dialogProcessor.TranslateTo(e.Location);
                pic.Invalidate();
            }
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            dialogProcessor.IsDragging=false;
        }
    }
}
