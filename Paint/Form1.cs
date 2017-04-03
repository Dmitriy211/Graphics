using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        Point prPnt;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prPnt = e.Location;
            if (lineDraw == true)
            {
                endLine = true;                
                lineDraw = false;
            }
            else
            {                
                endLine = false;
                lineDraw = true;
            }
        }

        Graphics g;
        GraphicsPath gp;
        Point curPnt;
        bool lineDraw = false;
        bool endLine = true;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Instrument_box.Text == "Pen")
            {
                curPnt = e.Location;
                g.DrawLine(new Pen(color, width), prPnt, curPnt);                
                prPnt = curPnt;
            }

            if (Instrument_box.Text == "Line" && endLine == false)
            {
                g.DrawLine(new Pen(pictureBox1.BackColor, width), prPnt, curPnt);
                curPnt = e.Location;
                g.DrawLine(new Pen(color, width), prPnt, curPnt);               
                // lineDraw = true;
            }
        }
        Color color = Color.Red;
        float width;

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
        }

        private void Color_btn_Click(object sender, EventArgs e)
        {            
            ColorDialog cdlg = new ColorDialog();
            if (cdlg.ShowDialog() == DialogResult.OK)
                color = cdlg.Color;
            Color_btn.BackColor = color;
        }

        private void Pen_num_ValueChanged(object sender, EventArgs e)
        {
            width = (float)Pen_num.Value;            
        }
        
    }
}
