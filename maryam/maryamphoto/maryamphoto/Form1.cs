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
    public partial class Form1 : Form
    {

        public static string l1;
        public static string l2;
        public static string l3;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }











        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            l1 = textBox1.Text;
            l2 = textBox2.Text;
            l3 = textBox3.Text;
            Form2 frm2 = new Form2(pictureBox1.Image);

            frm2.Show();





        }
    }
}
