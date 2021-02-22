using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateMethods();
        }

        private void GenerateMethods()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 55;
                    buttons[i, j].Height = 55;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 55;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Aqua;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Azure;
                    }

                    this.Controls.Add(buttons[i, j]);
                }

                top += 55;
                left = 0;
            }
        }
    }
}
