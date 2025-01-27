using System;
using System.Windows.Forms;
using static PR02.OpenGL;


namespace PR02
{
    public partial class MainForm : Form
    {
        const float TileSize = 3.0f;
        int tilesHorizontal = 1;
        int tilesVertical = 1;
        uint drawMode = GL_FILL;

        public MainForm()
        {
            InitializeComponent();
        }

        private void render2(object sender, System.EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            int zoom = 10;
            gluOrtho2D(-renderer.Width / zoom, renderer.Width / zoom, -renderer.Height / zoom, renderer.Height / zoom);
            glViewport(0, 0, renderer.Width, renderer.Height);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();


            glPolygonMode(GL_FRONT_AND_BACK, drawMode);

            DrawHexagonGrid(tilesVertical, tilesHorizontal);
        }

        private void DrawHexagonGrid(int rows, int cols)
        {
            float halfSize = TileSize / 2;
            float width = (float)Math.Sqrt(3) * halfSize;
            float height = 3.3f * halfSize;
            float xOffset = -cols * width / 2;
            float yOffset = -rows * height / 2;
            glTranslatef(xOffset, yOffset, 0);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    float x = col * width * 1.7f;
                    float y = row * height + (col % 2) * height / 2;

                    drawTile(x, y);
                }
            }
        }

        void drawTile(float centerX, float centerY)
        {
            int numSides = 6;
            double angleStep = Math.PI * 2 / numSides;
            glBegin(GL_TRIANGLE_FAN);
            glColor3f(1, 0, 0);
            glVertex2f(centerX, centerY);

            glColor3f(0, 1, 0);
            for (int i = 0; i <= numSides; i++)
            {
                double angle = i * angleStep;
                float x = (float)(centerX + (TileSize * Math.Cos(angle)));
                float y = (float)(centerY + (TileSize * Math.Sin(angle)));
                glVertex2f(x, y);
            }
            glEnd();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tilesHorizontal = Convert.ToInt32(numericUpDown1.Value);
            Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tilesVertical = Convert.ToInt32(numericUpDown2.Value);
            Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            drawMode = GL_FILL;
            Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            drawMode = GL_LINE;
            Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drawMode = GL_POINT;
            Refresh();
        }
    }
}
