using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maryamphoto
{
    public partial class Form2 : Form
    {
        public Form2(Image pic1)
        {
            InitializeComponent();


            pictureBox1.Image = pic1;





        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            label1.Text = Form1.l1;
            label2.Text = Form1.l2;
            label3.Text = Form1.l3;
            label8.Text = Form1.l4;
        }
    }
}
