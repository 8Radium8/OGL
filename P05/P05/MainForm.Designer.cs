
using System.Windows.Forms;

namespace P05
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
            renderControl = new RenderControl();
            checkBox1 = new CheckBox();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            labelD = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl
            // 
            renderControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            renderControl.BackColor = System.Drawing.Color.SlateGray;
            renderControl.ForeColor = System.Drawing.Color.White;
            renderControl.Location = new System.Drawing.Point(-5, 1);
            renderControl.Margin = new Padding(3, 4, 3, 4);
            renderControl.Name = "renderControl";
            renderControl.Size = new System.Drawing.Size(614, 525);
            renderControl.TabIndex = 0;
            renderControl.TextCodePage = 1251;
            renderControl.Render += render;
            //renderControl.MouseDown += OnMouseDown;
            renderControl.MouseMove += OnMouseMove;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(648, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(143, 36);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Clip plane";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelA
            // 
            labelA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelA.AutoSize = true;
            labelA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelA.Location = new System.Drawing.Point(662, 57);
            labelA.Name = "labelA";
            labelA.Size = new System.Drawing.Size(29, 32);
            labelA.TabIndex = 2;
            labelA.Text = "A";
            // 
            // labelB
            // 
            labelB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelB.AutoSize = true;
            labelB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelB.Location = new System.Drawing.Point(662, 104);
            labelB.Name = "labelB";
            labelB.Size = new System.Drawing.Size(28, 32);
            labelB.TabIndex = 3;
            labelB.Text = "B";
            // 
            // labelC
            // 
            labelC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelC.AutoSize = true;
            labelC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelC.Location = new System.Drawing.Point(662, 151);
            labelC.Name = "labelC";
            labelC.Size = new System.Drawing.Size(29, 32);
            labelC.TabIndex = 4;
            labelC.Text = "C";
            // 
            // labelD
            // 
            labelD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelD.AutoSize = true;
            labelD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelD.Location = new System.Drawing.Point(662, 198);
            labelD.Name = "labelD";
            labelD.Size = new System.Drawing.Size(31, 32);
            labelD.TabIndex = 5;
            labelD.Text = "D";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.Location = new System.Drawing.Point(724, 55);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(67, 39);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown2.Location = new System.Drawing.Point(724, 102);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(67, 39);
            numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown3.Location = new System.Drawing.Point(724, 149);
            numericUpDown3.Margin = new Padding(3, 4, 3, 4);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(67, 39);
            numericUpDown3.TabIndex = 8;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown4.Location = new System.Drawing.Point(724, 196);
            numericUpDown4.Margin = new Padding(3, 4, 3, 4);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(67, 39);
            numericUpDown4.TabIndex = 9;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton2.Location = new System.Drawing.Point(14, 55);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(155, 36);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Perspective";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton1.Location = new System.Drawing.Point(14, 13);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(97, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ortho";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new System.Drawing.Point(648, 255);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(199, 108);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Location = new System.Drawing.Point(648, 389);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(199, 125);
            panel2.TabIndex = 11;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton4.Location = new System.Drawing.Point(14, 57);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(148, 36);
            radioButton4.TabIndex = 1;
            radioButton4.Text = "Line mode";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton3.Location = new System.Drawing.Point(14, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(134, 36);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Fill mode";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(881, 526);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(checkBox1);
            Controls.Add(renderControl);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(899, 573);
            Name = "MainForm";
            Text = "Main Form";
            Load += OnLoad;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

