using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Newrep neww = new Newrep();
            neww.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            holzak cold = new holzak();
            cold.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hot hot = new hot();
            hot.Show();
            Hide();
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dessert des = new dessert();
            des.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
