using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Numerics;

namespace glLab01
{
    public partial class RenderControl : OpenGL
    {
        public class PolyLine : List<Vector2>
        {
            public void Draw()
            {
                glLineStipple(4, 0x10FF);
                glEnable(GL_LINE_STIPPLE);
                glLineWidth(50);

                glBegin(GL_LINE_STRIP);

                foreach (Vector2 p in this)
                    glVertex2d(p.X, p.Y);

                glEnd();

                glLineWidth(1);
                glDisable(GL_LINE_STIPPLE);
            }
        }

        public RenderControl()
        {
            InitializeComponent();
            L2.Add(new Vector2(+1, -1));
            L2.Add(new Vector2(-1, +1));
            L2.Add(new Vector2(+1, +1));
        }

        Line L1 = new Line(-0.9, -0.9, +0.9, +0.9);
        PolyLine L2 = new PolyLine();
        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            double Xmin = -1;
            double Xmax = +1;

            double ds = (Xmax - Xmin) / 10;

            glViewport(0, 0, Width, Height);
            //glViewport(Width / 2, 0, Width / 2, Height / 2);
            // glOrtho(-1 - ds, +1 + ds, -1 - ds, +1 + ds, -1, +1);
            gluOrtho2D(Xmin - ds, Xmax + ds, -1 - ds, +1 + ds);

            L1.Draw();
            L2.Draw();

            glColor(Color.Red);
            DrawText("Test string", 0,0);
        }

        //private void PolyLine()
        //{
        //    glLineWidth(5);
        //    glBegin(GL_LINE_STRIP);
        //    glVertex2d(+1, -1);
        //    glVertex2d(-1, +1);
        //    glVertex2d(+1, +1);
        //    glEnd();
        //    glLineWidth(1);
        //}
    }
}

