
namespace PR03
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
            rendere = new RenderControl();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // rendere
            // 
            rendere.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rendere.BackColor = System.Drawing.Color.SlateGray;
            rendere.ForeColor = System.Drawing.Color.White;
            rendere.Location = new System.Drawing.Point(12, 12);
            rendere.Name = "rendere";
            rendere.Size = new System.Drawing.Size(481, 417);
            rendere.TabIndex = 0;
            rendere.TextCodePage = 1251;
            rendere.Render += render;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(560, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "Xmin";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(560, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Xmax";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(560, 189);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 25);
            label3.TabIndex = 3;
            label3.Text = "Points";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 65536 });
            numericUpDown1.Location = new System.Drawing.Point(638, 44);
            numericUpDown1.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            numericUpDown1.Size = new System.Drawing.Size(73, 32);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, -2147418112 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown2.Increment = new decimal(new int[] { 2, 0, 0, 65536 });
            numericUpDown2.Location = new System.Drawing.Point(638, 97);
            numericUpDown2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            numericUpDown2.Size = new System.Drawing.Size(73, 32);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 8, 0, 0, 65536 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            numericUpDown3.Location = new System.Drawing.Point(638, 187);
            numericUpDown3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(73, 32);
            numericUpDown3.TabIndex = 6;
            numericUpDown3.Value = new decimal(new int[] { 481, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(770, 449);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rendere);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Chart Y = f(x)";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl rendere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

