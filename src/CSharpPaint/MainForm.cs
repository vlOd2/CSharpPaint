using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpPaint
{
    /// <summary>
    /// The main form
    /// </summary>
    public partial class MainForm : Form
    {
        private bool useBrush = false;
        private Color drawColor = Color.Black;
        private int brushSize = 5;

        /// <summary>
        /// The main form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pcCanvas.PaintFrame.MouseMove += pcCanvas_MouseMove;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pcCanvas.ClearFrame();
            Console.WriteLine($"FORM_EVENT: BUTTON_CLICK");
        }

        private void btnChgColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            Console.WriteLine($"EVENT: COLORDIALOG_SHOW");
            cd.ShowDialog();
            drawColor = cd.Color;
            Console.WriteLine($"EVENT: COLORDIALOG_DISPOSE");
            cd.Dispose();
            cd = null;

            Console.WriteLine($"FORM_EVENT: BUTTON_CLICK");
        }

        private void cbUseBrush_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbUseBrush.Checked)
            {
                case true:
                    useBrush = true;
                    break;
                case false:
                    useBrush = false;
                    break;
            }

            Console.WriteLine($"FORM_EVENT: CHECKBOX_CHANGE ({cbUseBrush.Checked})");
        }

        private void nudBrushSize_ValueChanged(object sender, EventArgs e)
        {
            brushSize = (int) nudBrushSize.Value;
            Console.WriteLine($"FORM_EVENT: NUMERICUPDOWN_VALUE_CHANGE ({(int)nudBrushSize.Value})");
        }

        private void pcCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                int mouseX = e.X;
                int mouseY = e.Y;

                if (useBrush)
                    pcCanvas.DrawArea(mouseX, mouseY, drawColor, brushSize);
                else
                    pcCanvas.SetPixel(mouseX, mouseY, drawColor);

                Console.WriteLine($"MOUSE_EVENT: MOUSE_MOVE (X:{mouseX}, Y:{mouseY})");
            }
        }
    }
}
