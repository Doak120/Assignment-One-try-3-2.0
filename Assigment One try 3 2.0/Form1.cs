using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_One_try_3_2._0
{
    public partial class Form1 : Form
    {
        int num1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Dogs Rock");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result;
            string str = textBox1.Text;
            if(int.TryParse(textBox1.Text,out num1))
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Incorrect Entry");
            }
            try
            {
                result = int.Parse(str);
            }
            catch
            {
                MessageBox.Show("Catch- Not a valid int")
            }
        }
    }
}
