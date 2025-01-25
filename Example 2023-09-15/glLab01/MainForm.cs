using System.Windows.Forms;
using static glLab01.OpenGL;


namespace glLab01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, System.EventArgs e)
        {
            //glClear(GL_COLOR_BUFFER_BIT);
            //glLoadIdentity();

            //glViewport(0, 0, renderer.Width, renderer.Height);
            //glOrtho(-1, +1, -1, +1, -1, +1);

            //glBegin(GL_LINES);
            //glVertex2d(-1, -1);
            //glVertex2d(+1, +1);
            //glEnd();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
