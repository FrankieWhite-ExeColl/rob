using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rob
{
    public partial class Form2 : Form
    {
        int val = 0;
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int a = val++;
            textBox1.Text = a.ToString();
            lblTimer.Text = a.ToString();
            if (a == 5)
            {
                MessageBox.Show("You loose!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("testing");
        }
    }
}
