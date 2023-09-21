using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int countcharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("data file.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is somthing new");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "My Lable";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lable2.t
        }
    }
}
