using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe_
{
    public partial class Exe : Form
    {
        public Exe()
        {
            InitializeComponent();
            button2.BackColor = Color.MediumVioletRed;
            button3.BackColor = Color.Cyan;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляю с первым проектом на C#!");
        }

        private string b2;
        private string b3;

        private void button2_Click(object sender, EventArgs e)
        {
            b2 = button2.BackColor.Name;
            button2.BackColor = button3.BackColor;
            button3.BackColor = Color.FromName(b2);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            b3 = button3.BackColor.Name;
            button3.BackColor = button2.BackColor;
            button2.BackColor = Color.FromName(b3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
