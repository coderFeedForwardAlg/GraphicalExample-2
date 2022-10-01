using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalExample
{
    public partial class Form1 : Form
    {
        /* shape can be 
        rectangle
        ellipse
        tryangle
        */
        String shape = "ellipse";
        int y = 100;
        int x = 100;
        int r = 200;
        int g = 200;
        int b = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = int.Parse(textBox1.Text);
            g = int.Parse(textBox2.Text);
            b = int.Parse(textBox3.Text);
                // repeat code 
            if (checkBox1.Checked)
            {
                Graphics anotherone = panel1.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.FromArgb(r, b, g));

                anotherone.FillEllipse(brush, new Rectangle(0, 0, x, y));
                if (shape == "rectangle")
                {
                    anotherone.FillRectangle(brush, new Rectangle(0, 0, x, y));
                }
                else
                {
                    anotherone.FillEllipse(brush, new Rectangle(0, 0, x, y));
                }

            }
            else
            {
                // code to get rid of circle 
                Graphics anotherone = panel1.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.White);

                anotherone.FillEllipse(brush, new Rectangle(0, 0, x, y));

                // code to replace the circle 
                makeShape(shape);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            makeShape(shape);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Graphics anotherone = panel1.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.FromArgb( r, b, g));

                anotherone.FillEllipse(brush, new Rectangle(0, 0, x, y));
                if (shape == "rectangle")
                {
                    anotherone.FillRectangle(brush, new Rectangle(0, 0, x, y));
                }
                else
                {
                    anotherone.FillEllipse(brush, new Rectangle(0, 0, x, y));
                }

            }
            else
            {
                    // code to get rid of circle 
                Graphics anotherone = panel1.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.White);

                anotherone.FillEllipse(brush, new Rectangle(0, 0, x, y));

                // code to replace the circle 
                makeShape(shape);
            }
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            shape = comboBox2.Text;

            makeShape(shape);

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            makeShape(shape);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            shape = comboBox2.Text;
            makeShape(shape);
        }

        public void makeShape(String shape)
        {
            Graphics g = panel1.CreateGraphics();

            Pen myPen = new Pen(Color.RoyalBlue);

            g.Clear(Color.White);
            if (shape == "rectangle")
            {
                g.DrawRectangle(myPen, new Rectangle(0, 0, x, y));
            }
            else
            {
                g.DrawEllipse(myPen, 0, 0, x, y);
            }
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            y = vScrollBar1.Value * 10;
            makeShape(shape);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            x = hScrollBar1.Value * 10;
            makeShape(shape);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
