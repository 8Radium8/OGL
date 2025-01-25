using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static glLab01.OpenGL;

namespace glLab01
{
    internal class Line 
    {
        double x1, x2, y1, y2;
        public Line(double x1, double y1, double x2, double y2) 
        { 
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Draw()
        {
            glBegin(GL_LINES);
            glVertex2d(-1, -1);
            glVertex2d(+1, +1);
            glEnd();
        }
    }
}
