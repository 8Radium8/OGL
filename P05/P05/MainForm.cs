using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static P05.OpenGL;


namespace P05
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("gdi32.dll")]
        static extern int ChoosePixelFormat(IntPtr hdc, ref PIXELFORMATDESCRIPTOR pfd);
        [DllImport("gdi32.dll")]
        static extern int SetPixelFormat(IntPtr hdc, int format, ref PIXELFORMATDESCRIPTOR pfd);

        private IntPtr hglrc;
        private IntPtr hdc;
        private float rotationX = 0;
        private float rotationY = 0;
        private Point lastMousePos;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            hdc = GetDC(this.Handle);
            SetPixelFormat();
            hglrc = wglCreateContext(hdc);
            wglMakeCurrent(hdc, hglrc);
            InitOpenGL();
        }

        private void InitOpenGL()
        {
            glEnable(GL_DEPTH_TEST);
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);
            glEnable(GL_COLOR_MATERIAL);
            glColorMaterial(GL_FRONT, GL_AMBIENT_AND_DIFFUSE);
        }

        private void render(object sender, EventArgs e)
        {
            RenderScene();
            DrawOverlay();
        }

        private void RenderScene()
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            GLU.Perspective(45.0, (double)renderControl.Width / renderControl.Height, 1.0, 100.0);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glTranslated(0.0, 0.0, -10.0);
            glRotatef(rotationX, 1, 0, 0);
            glRotatef(rotationY, 0, 1, 0);
            DrawAxes();
            DrawGrid();
            DrawShapes();
            wglSwapBuffers(hdc);
        }

        private void DrawAxes()
        {
            glColor3d(1.0, 0.0, 0.0);
            glBegin(GL_LINES);
            glVertex3d(-5, 0, 0);
            glVertex3d(5, 0, 0);
            glVertex3d(0, -5, 0);
            glVertex3d(0, 5, 0);
            glVertex3d(0, 0, -5);
            glVertex3d(0, 0, 5);
            glEnd();
        }

        private void DrawGrid()
        {
            glColor3d(.5, .5, .5);
            glBegin(GL_LINES);
            for (int i = -5; i <= 5; i++)
            {
                glVertex3d(i, -5, 0);
                glVertex3d(i, 5, 0);
                glVertex3d(-5, i, 0);
                glVertex3d(5, i, 0);
            }
            glEnd();
        }

        private void DrawShapes()
        {
            glColor3d(0, 0, 1);
            glPushMatrix();
            glTranslatef(2, 2, -1);
            GLU.Sphere(1, 20, 20);
            glPopMatrix();

            glColor3d(0, 1, 0);
            glPushMatrix();
            glTranslatef(-2, 2, 0);
            GLU.Cylinder(1, 1, 2, 20, 20);
            glPopMatrix();

            glColor3d(1, 1, 0);
            glPushMatrix();
            glTranslatef(0, -2, 0);
            GLU.Disk(1);
            glPopMatrix();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            lastMousePos = e.Location;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rotationX += (e.Y - lastMousePos.Y) * 0.5f;
                rotationY += (e.X - lastMousePos.X) * 0.5f;
                lastMousePos = e.Location;
                Refresh();
            }
        }

        private void DrawOverlay()
        {
            glMatrixMode(GL_PROJECTION);
            glPushMatrix();
            glLoadIdentity();
            glOrtho(0, renderControl.Width, renderControl.Height, 0, -1, 1);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();

            glDisable(GL_LIGHTING);
            glDisable(GL_DEPTH_TEST);
            glColor3d(1, 1, 1);
            glBegin(GL_LINES);
            for (int i = -5; i <= 5; i++)
            {
                glVertex2d(TransformX(i), TransformY(-5));
                glVertex2d(TransformX(i), TransformY(5));
                glVertex2d(TransformX(-5), TransformY(i));
                glVertex2d(TransformX(5), TransformY(i));
            }
            glEnd();
            
            glEnable(GL_LIGHTING);
            glEnable(GL_DEPTH_TEST);
            glMatrixMode(GL_PROJECTION);
            glPopMatrix();
        }

        private double TransformX(double x) => (x + 5) * (renderControl.Width / 10.0);
        private double TransformY(double y) => (y + 5) * (renderControl.Height / 10.0);

        struct PIXELFORMATDESCRIPTOR
        {
            public ushort nSize;
            public ushort nVersion;
            public uint dwFlags;
            public byte iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public byte iLayerType;
            public byte bReserved;
            public uint dwLayerMask;
            public uint dwVisibleMask;
            public uint dwDamageMask;
        }

        private void SetPixelFormat()
        {
            PIXELFORMATDESCRIPTOR pfd = new PIXELFORMATDESCRIPTOR();
            pfd.nSize = (ushort)Marshal.SizeOf(typeof(PIXELFORMATDESCRIPTOR));
            pfd.nVersion = 1;
            pfd.dwFlags = 0x00000004 | 0x00000020; // PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL
            pfd.iPixelType = 0; // PFD_TYPE_RGBA
            pfd.cColorBits = 32;
            pfd.cDepthBits = 24;
            pfd.iLayerType = 0; // PFD_MAIN_PLANE

            int pixelFormat = ChoosePixelFormat(hdc, ref pfd);
            SetPixelFormat(hdc, pixelFormat, ref pfd);
        }

    }

    public class GLU
    {
        public static void Sphere(double radius, int slices, int stacks)
        {
            for (int i = 0; i <= stacks; ++i)
            {
                float lat0 = (float)Math.PI * (-0.5f + (float)(i - 1) / stacks);
                float z0 = (float)radius * (float)Math.Sin(lat0);
                float zr0 = (float)radius * (float)Math.Cos(lat0);

                float lat1 = (float)Math.PI * (-0.5f + (float)i / stacks);
                float z1 = (float)radius * (float)Math.Sin(lat1);
                float zr1 = (float)radius * (float)Math.Cos(lat1);

                glBegin(GL_LINE_LOOP);
                for (int j = 0; j <= slices; ++j)
                {
                    float lng = 2 * (float)Math.PI * (float)(j - 1) / slices;
                    float x = (float)Math.Cos(lng);
                    float y = (float)Math.Sin(lng);

                    glVertex3f(x * zr0, y * zr0, z0);
                    glVertex3f(x * zr1, y * zr1, z1);
                }
                glEnd();
            }
        }

        public static void Cylinder(double baseRadius, double topRadius, double height, int slices, int stacks)
        {
            float deltaAngle = 2.0f * (float)Math.PI / slices;
            for (int i = 0; i < slices; ++i)
            {
                float angle = i * deltaAngle;
                float nextAngle = (i + 1) * deltaAngle;

                glBegin(GL_QUADS);
                for (int j = 0; j <= stacks; ++j)
                {
                    float z = (float)height * j / stacks;
                    glVertex3f((float)baseRadius * (float)Math.Cos(angle), (float)baseRadius * (float)Math.Sin(angle), z);
                    glVertex3f((float)baseRadius * (float)Math.Cos(nextAngle), (float)baseRadius * (float)Math.Sin(nextAngle), z);
                }
                glEnd();
            }
        }

        public static void Disk(double radius)
        {
            glBegin(GL_LINE_LOOP);
            for (int i = 0; i < 360; i += 10)
            {
                double angle = Math.PI * i / 180.0;
                glVertex3d(radius * Math.Cos(angle), radius * Math.Sin(angle), 0);
            }
            glEnd();
        }

        public static void Perspective(double fovY, double aspect, double zNear, double zFar)
        {
            double fH = Math.Tan(fovY / 360 * Math.PI) * zNear;
            double fW = fH * aspect;
            glFrustum(-fW, fW, -fH, fH, zNear, zFar);
        }
    }
}
