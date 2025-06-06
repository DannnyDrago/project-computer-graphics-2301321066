namespace project_computer_graphics_2301321066
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ungroup = new System.Windows.Forms.Button();
            this.btn_group = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_shrink = new System.Windows.Forms.Button();
            this.btn_enlarge = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.rotationSlider = new System.Windows.Forms.TrackBar();
            this.borderSlider = new System.Windows.Forms.TrackBar();
            this.transparencySlider = new System.Windows.Forms.TrackBar();
            this.Select_mode = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_newshape = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencySlider)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_ungroup);
            this.panel1.Controls.Add(this.btn_group);
            this.panel1.Controls.Add(this.load_btn);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_shrink);
            this.panel1.Controls.Add(this.btn_enlarge);
            this.panel1.Controls.Add(this.copy_btn);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.rotationSlider);
            this.panel1.Controls.Add(this.borderSlider);
            this.panel1.Controls.Add(this.transparencySlider);
            this.panel1.Controls.Add(this.Select_mode);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 107);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_ungroup
            // 
            this.btn_ungroup.Location = new System.Drawing.Point(1189, 67);
            this.btn_ungroup.Name = "btn_ungroup";
            this.btn_ungroup.Size = new System.Drawing.Size(75, 23);
            this.btn_ungroup.TabIndex = 19;
            this.btn_ungroup.Text = "Ungroup";
            this.btn_ungroup.UseVisualStyleBackColor = true;
            this.btn_ungroup.Click += new System.EventHandler(this.btn_ungroup_Click);
            // 
            // btn_group
            // 
            this.btn_group.Location = new System.Drawing.Point(1090, 67);
            this.btn_group.Name = "btn_group";
            this.btn_group.Size = new System.Drawing.Size(75, 23);
            this.btn_group.TabIndex = 18;
            this.btn_group.Text = "Group";
            this.btn_group.UseVisualStyleBackColor = true;
            this.btn_group.Click += new System.EventHandler(this.btn_group_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(117, 67);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 17;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(23, 67);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_shrink
            // 
            this.btn_shrink.Location = new System.Drawing.Point(996, 67);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Size = new System.Drawing.Size(72, 23);
            this.btn_shrink.TabIndex = 15;
            this.btn_shrink.Text = "Shrink";
            this.btn_shrink.UseVisualStyleBackColor = true;
            this.btn_shrink.Click += new System.EventHandler(this.btn_shrink_Click);
            // 
            // btn_enlarge
            // 
            this.btn_enlarge.Location = new System.Drawing.Point(900, 67);
            this.btn_enlarge.Name = "btn_enlarge";
            this.btn_enlarge.Size = new System.Drawing.Size(75, 23);
            this.btn_enlarge.TabIndex = 14;
            this.btn_enlarge.Text = "Enlarge";
            this.btn_enlarge.UseVisualStyleBackColor = true;
            this.btn_enlarge.Click += new System.EventHandler(this.btn_enlarge_Click);
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(117, 27);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(75, 23);
            this.copy_btn.TabIndex = 9;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(23, 27);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // rotationSlider
            // 
            this.rotationSlider.Location = new System.Drawing.Point(1233, 28);
            this.rotationSlider.Maximum = 360;
            this.rotationSlider.Name = "rotationSlider";
            this.rotationSlider.Size = new System.Drawing.Size(68, 45);
            this.rotationSlider.TabIndex = 12;
            this.rotationSlider.Scroll += new System.EventHandler(this.rotationSlider_Scroll);
            // 
            // borderSlider
            // 
            this.borderSlider.LargeChange = 1;
            this.borderSlider.Location = new System.Drawing.Point(1142, 28);
            this.borderSlider.Maximum = 15;
            this.borderSlider.Minimum = 1;
            this.borderSlider.Name = "borderSlider";
            this.borderSlider.Size = new System.Drawing.Size(72, 45);
            this.borderSlider.TabIndex = 11;
            this.borderSlider.Value = 1;
            this.borderSlider.Scroll += new System.EventHandler(this.borderSlider_Scroll);
            // 
            // transparencySlider
            // 
            this.transparencySlider.Location = new System.Drawing.Point(1058, 28);
            this.transparencySlider.Maximum = 255;
            this.transparencySlider.Name = "transparencySlider";
            this.transparencySlider.Size = new System.Drawing.Size(78, 45);
            this.transparencySlider.TabIndex = 10;
            this.transparencySlider.Value = 255;
            this.transparencySlider.Scroll += new System.EventHandler(this.transparencySlider_Scroll);
            // 
            // Select_mode
            // 
            this.Select_mode.AutoSize = true;
            this.Select_mode.BackColor = System.Drawing.Color.White;
            this.Select_mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Select_mode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Select_mode.Location = new System.Drawing.Point(996, 33);
            this.Select_mode.Name = "Select_mode";
            this.Select_mode.Size = new System.Drawing.Size(56, 17);
            this.Select_mode.TabIndex = 9;
            this.Select_mode.Text = "Select";
            this.Select_mode.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(899, 28);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 24);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(232, 38);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(42, 38);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_newshape);
            this.panel3.Controls.Add(this.btn_triangle);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Location = new System.Drawing.Point(280, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 92);
            this.panel3.TabIndex = 3;
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_triangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.ForeColor = System.Drawing.Color.White;
            this.btn_triangle.Image = global::project_computer_graphics_2301321066.Properties.Resources.triangle;
            this.btn_triangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_triangle.Location = new System.Drawing.Point(421, 16);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(68, 58);
            this.btn_triangle.TabIndex = 8;
            this.btn_triangle.Text = "Triangle";
            this.btn_triangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_triangle.UseVisualStyleBackColor = false;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::project_computer_graphics_2301321066.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(347, 16);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(68, 58);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::project_computer_graphics_2301321066.Properties.Resources.color;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_color.Location = new System.Drawing.Point(125, 16);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(68, 58);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::project_computer_graphics_2301321066.Properties.Resources.circle;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(199, 16);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(68, 58);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::project_computer_graphics_2301321066.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(273, 16);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(68, 58);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 645);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 16);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 107);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1350, 538);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btn_newshape
            // 
            this.btn_newshape.Location = new System.Drawing.Point(496, 37);
            this.btn_newshape.Name = "btn_newshape";
            this.btn_newshape.Size = new System.Drawing.Size(75, 23);
            this.btn_newshape.TabIndex = 9;
            this.btn_newshape.Text = "new shape";
            this.btn_newshape.UseVisualStyleBackColor = true;
            this.btn_newshape.Click += new System.EventHandler(this.btn_newshape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "\\";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencySlider)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.CheckBox Select_mode;
        private System.Windows.Forms.TrackBar transparencySlider;
        private System.Windows.Forms.TrackBar borderSlider;
        private System.Windows.Forms.TrackBar rotationSlider;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Button btn_shrink;
        private System.Windows.Forms.Button btn_enlarge;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_group;
        private System.Windows.Forms.Button btn_ungroup;
        private System.Windows.Forms.Button btn_newshape;
    }
}

