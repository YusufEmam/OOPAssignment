using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
            textBox3.ForeColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Blue;
            textBox4.ForeColor = Color.DeepPink;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Magneto", 10, FontStyle.Regular);
            textBox3.Font = new Font("Magneto", 10, FontStyle.Regular);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Font = new Font("Felix Titling", 10, FontStyle.Regular);
            textBox4.Font = new Font("Felix Titling", 10, FontStyle.Regular);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
