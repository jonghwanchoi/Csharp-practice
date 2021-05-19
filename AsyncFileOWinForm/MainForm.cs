using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFileOWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile(@"C:\Users\dbthw\OneDrive\바탕 화면\KOSTA\실습 관련 사진자료\4.28.PNG");
        }

        private void Page1_Button_Click(object sender, EventArgs e)
        {
            // panel1.Visible = true;
            pictureBox1.Size = new System.Drawing.Size(500, 300);
        }

        private void Page2_ButtonP_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Page2_ButtonN_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Page3_ButtonP_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World";
        }
    }
}
