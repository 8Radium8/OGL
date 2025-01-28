using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static PR03.OpenGL;


namespace PR03
{
    public partial class MainForm : Form
    {
        float x1, x2, y1 = -2.5f, y2 = 3.0f, points;

        public MainForm()
        {

            InitializeComponent();
            points = (float)numericUpDown3.Value;
            x1 = (float)numericUpDown1.Value;
            x2 = (float)numericUpDown2.Value;
        }

        private void render(object sender, System.EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, rendere.Width, rendere.Height);
            glOrtho(x1, x2, y1, y2, 0.0, 1.0);
            drawCoordinates();
            drawLines();

            DrawLabels();
            DrawGraph();

            rendere.Refresh();
        }

        private void DrawLabels()
        {

            glColor3f(0.0f, 0.0f, 0.0f);
            glColor3f(1.0f, 1.0f, 1.0f);
            for (float i = x1; i <= x2; i += 0.2f)
            {
                DrawText(i.ToString("0.0"), i, -.2f);
            }

            for (float i = y1; i <= y2; i += 0.5f)
            {
                DrawText(i.ToString("0.0"), -0.1f, i);
            }
            glColor3f(1.0f, 1.0f, 1.0f);
        }

        private void DrawText(string text, float x, float y)
        {
            Bitmap bitmap = new Bitmap(1, 1);

            Font font = new Font("Segoe UI", 10);
            Graphics g = Graphics.FromImage(bitmap);
            SizeF size = g.MeasureString(text, font);

            bitmap = new Bitmap(bitmap, (int)size.Width, (int)size.Height);

            g = Graphics.FromImage(bitmap);

            g.Clear(Color.Transparent);
            g.DrawString(text, font, Brushes.White, 0, 0);
            bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            glRasterPos2f(x, y);

            glDrawPixels(bitmap.Width, bitmap.Height, GL_RGBA, GL_UNSIGNED_BYTE, bitmapData.Scan0);

            bitmap.UnlockBits(bitmapData);
        }

        private void drawCoordinates()
        {


            glBegin(GL_LINES);

            for (float i = y1; i <= y2; i += .5f)
            {
                glVertex2f(x1, i);
                glVertex2f(x2, i);



                for (float j = x1; j <= x2; j += .2f)
                {
                    glVertex2f(j, y1);
                    glVertex2f(j, y2);
                }
            }

            glEnd();
        }
        private void drawLines()
        {
            glLineWidth(3);
            glBegin(GL_LINES);
            glVertex2d(x1, 0);
            glVertex2d(x2, 0);
            glEnd();
            glBegin(GL_LINES);
            glVertex2d(0, y1);
            glVertex2d(0, y2);
            glEnd();
            glLineWidth(1);
        }

        private void DrawGraph()
        {
            float h = (x2 - x1) / (points - 1);

            for (int i = 0; i < points - 1; i++)
            {
                double x = x1 + i * h;
                double y = 1 / Math.Tan(1.25 * Math.Sin(2 * x + Math.Cos(4 * x)) + Math.PI / 2);

                double x_next = x1 + (i + 1) * h;
                double y_next = 1 / Math.Tan(1.25 * Math.Sin(2 * x_next + Math.Cos(4 * x_next)) + Math.PI / 2);

                if (y * y_next > 0)
                {
                    glBegin(GL_POINTS);
                    glVertex2d(x, y);
                    glEnd();
                }
                else
                {
                    glPointSize(10);
                    glColor3f(1.0f, 0.0f, 0.0f);
                    glBegin(GL_POINTS);
                    glVertex2d(x, y);
                    glEnd();
                    glColor3f(1.0f, 1.0f, 1.0f);
                    glPointSize(1);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            x1 = (float)numericUpDown1.Value;
            Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            x2 = (float)numericUpDown2.Value;
            Refresh();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            points = (float)numericUpDown3.Value;
            Refresh();
        }
    }
}
