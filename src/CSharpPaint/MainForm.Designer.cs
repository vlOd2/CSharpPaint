
namespace CSharpPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.btnChgColor = new System.Windows.Forms.Button();
            this.cbUseBrush = new System.Windows.Forms.CheckBox();
            this.lBrushSize = new System.Windows.Forms.Label();
            this.nudBrushSize = new System.Windows.Forms.NumericUpDown();
            this.pcCanvas = new CSharpPaint.PaintCanvas();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(221, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnChgColor
            // 
            this.btnChgColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChgColor.Location = new System.Drawing.Point(200, 275);
            this.btnChgColor.Name = "btnChgColor";
            this.btnChgColor.Size = new System.Drawing.Size(96, 23);
            this.btnChgColor.TabIndex = 2;
            this.btnChgColor.Text = "Change color";
            this.btnChgColor.UseVisualStyleBackColor = true;
            this.btnChgColor.Click += new System.EventHandler(this.btnChgColor_Click);
            // 
            // cbUseBrush
            // 
            this.cbUseBrush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUseBrush.AutoSize = true;
            this.cbUseBrush.Location = new System.Drawing.Point(12, 246);
            this.cbUseBrush.Name = "cbUseBrush";
            this.cbUseBrush.Size = new System.Drawing.Size(80, 17);
            this.cbUseBrush.TabIndex = 3;
            this.cbUseBrush.Text = "Use brush?";
            this.cbUseBrush.UseVisualStyleBackColor = true;
            this.cbUseBrush.CheckedChanged += new System.EventHandler(this.cbUseBrush_CheckedChanged);
            // 
            // lBrushSize
            // 
            this.lBrushSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lBrushSize.AutoSize = true;
            this.lBrushSize.Location = new System.Drawing.Point(9, 279);
            this.lBrushSize.Name = "lBrushSize";
            this.lBrushSize.Size = new System.Drawing.Size(58, 13);
            this.lBrushSize.TabIndex = 5;
            this.lBrushSize.Text = "Brush size:";
            // 
            // nudBrushSize
            // 
            this.nudBrushSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudBrushSize.Location = new System.Drawing.Point(66, 277);
            this.nudBrushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrushSize.Name = "nudBrushSize";
            this.nudBrushSize.Size = new System.Drawing.Size(55, 20);
            this.nudBrushSize.TabIndex = 7;
            this.nudBrushSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBrushSize.ValueChanged += new System.EventHandler(this.nudBrushSize_ValueChanged);
            // 
            // pcCanvas
            // 
            this.pcCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcCanvas.Location = new System.Drawing.Point(12, 12);
            this.pcCanvas.Name = "pcCanvas";
            this.pcCanvas.Size = new System.Drawing.Size(284, 228);
            this.pcCanvas.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 310);
            this.Controls.Add(this.nudBrushSize);
            this.Controls.Add(this.pcCanvas);
            this.Controls.Add(this.lBrushSize);
            this.Controls.Add(this.cbUseBrush);
            this.Controls.Add(this.btnChgColor);
            this.Controls.Add(this.btnReset);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "C# Paint";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrushSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnChgColor;
        private System.Windows.Forms.CheckBox cbUseBrush;
        private System.Windows.Forms.Label lBrushSize;
        private PaintCanvas pcCanvas;
        private System.Windows.Forms.NumericUpDown nudBrushSize;
    }
}

