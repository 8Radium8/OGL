using System.Windows.Forms;
using static PR01.OpenGL;


namespace PR01
{
    public partial class rendere : Form
    {
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
            glOrtho(-7.5, 1.5, -3.5, 0.5, 0.0, 1.0);


            glBegin(GL_LINES);

            for (double i = -3.5; i <= 0.5; i += 0.5)
            {
                glVertex2d(-7.5, i);
                glVertex2d(1.5, i);
            }

            for (double i = -7.5; i <= 1.5; i += 0.5)
            {
                glVertex2d(i, -3.5);
                glVertex2d(i, 0.5);
            }

            glEnd();

            //glBegin(GL_LINE_LOOP);
            //glVertex2f(0, 0);
            //glVertex2f(2.5f, 0);
            //glVertex2f(5.0f, 5.0f);
            //glEnd();

        }
    }
}
