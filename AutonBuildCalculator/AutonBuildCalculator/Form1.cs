using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutonBuildCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            Int32 build = ((dateTime.Year - 2013) * 12 + dateTime.Month) * 100 + dateTime.Day;

            textBox1.Text = build.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Int32 build = Convert.ToInt32(textBox1.Text);
        }
    }
}
