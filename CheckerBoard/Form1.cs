using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerBoard
{
    public partial class Form1 : Form
    {
        Graphics gfx;

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width = ClientRectangle.Width / 8;
            int height = ClientRectangle.Height / 8;

            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush black = new SolidBrush(Color.Black);

            for (int rows = 1; rows <= 8; rows++)
            {
                for (int columns = 1; columns <= 8; columns++)
                {
                    if ((rows + columns) % 2 == 0)
                        gfx.FillRectangle(red, (rows - 1) * width, (columns - 1) * height, width, height);
                    else
                        gfx.FillRectangle(black, (columns - 1) * width, (rows - 1) * height, width, height);
                }
            }

        }
    }
}
