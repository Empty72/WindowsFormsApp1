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
    public partial class holzak : Form
    {
        public holzak()
        {
            InitializeComponent();
        }

        private void holzak_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu mene = new menu();
            mene.Show();
            Hide();
        }
    }
}
