using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaaAAAAAAsaasaaas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matrix = new int[20, 20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Name = $"{j}_{i}",
                        Size = new Size(40, 40),
                        Location = new Point(40 * i, 40 * j),
                        BackColor = Color.Black,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                };
                    panel1.Controls.Add(pic);
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i == 1 && (j < 2 || j == 4 || j == 7 || j == 8 || (j > 10 && j < 16) || j == 18 || j == 19))
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    switch (matrix[i, j])
                    {
                        case 0:
                            PictureBox pic = panel1.Controls[$"{i}_{j}"] as PictureBox;

                            pic.Image = Image.FromFile(@"C:\Users\aafedotov\source\repos\aaaAAAAAAsaasaaas\aaaAAAAAAsaasaaas\car.png");
                            break;
                        case 1:
                            PictureBox pic1 = panel1.Controls[$"{i}_{j}"] as PictureBox;
                            pic1.Image = Image.FromFile(@"C:\Users\aafedotov\Desktop\АИСУ\Resources\RSvertical3.png");
                            break;

                    }
                }
            }
            
        }
    }
}
