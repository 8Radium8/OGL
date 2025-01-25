
namespace glLab01
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderer = new RenderControl();
            SuspendLayout();
            // 
            // renderer
            // 
            renderer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderer.BackColor = System.Drawing.Color.SlateGray;
            renderer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            renderer.ForeColor = System.Drawing.Color.White;
            renderer.Location = new System.Drawing.Point(12, 12);
            renderer.Name = "renderer";
            renderer.Size = new System.Drawing.Size(484, 361);
            renderer.TabIndex = 0;
            renderer.TextAlignment = OpenGL.Vertical.Middle;
            renderer.TextCodePage = 1251;
            renderer.TextJustification = OpenGL.Horizontal.Centered;
            renderer.Render += OnRender;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(628, 385);
            Controls.Add(renderer);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderer;
    }
}

