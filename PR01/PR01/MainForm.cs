using System.Windows.Forms;
using static PR01.OpenGL;


namespace PR01
{
    public partial class rendere : Form
    {
        double x1 = -8.5, x2 = 2.5, y1 = -4.5, y2 = 1.5;

        public rendere()
        {
            InitializeComponent();
        }

        private void R1(object sender, System.EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glMatrixMode(GL_VIEWPORT);
            glLoadIdentity();
            glViewport(0, 0,  renderer.Width, renderer.Height);
            glOrtho(x1, x2, y1, y2, 0.0, 1.0);

            drawCoordinates();

            double[] vertices = { -5.5, -3.5, -7.5, -2.5, -6.5, .5, -5.5, .5, -4.5, -1.5, -5.5, -3.5 };

            glLineWidth(8);

            glBegin(GL_LINE_STRIP);

            draw(vertices);

            glEnd();

            glEnable(GL_POINT_SMOOTH);
            glEnable(GL_BLEND);
            glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
            glPointSize(13);
            glBegin(GL_POINTS);
            draw(vertices, 5);
            glEnd();
        }

        private void drawCoordinates()
        {
            glLineWidth(3);
            glLineStipple(1,0xFF00);
            glEnable(GL_LINE_STIPPLE);
            glBegin(GL_LINES);

           

            for (double i = y1; i <= y2; i++)
            {
                glVertex2d(x1, i);
                glVertex2d(x2, i);

                for (double j = x1; j <= x2; j++)
                {
                    glVertex2d(j, y1);
                    glVertex2d(j, y2);
                }
            }


            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }

        private void draw(double[] vertices, int modifier = 0)
        {
            for (int i = 0, j = 1; i < vertices.Length; i += 2, j += 2)
            {
                glVertex2d(vertices[i] + modifier, vertices[j]);
            }
        }
    }
}
