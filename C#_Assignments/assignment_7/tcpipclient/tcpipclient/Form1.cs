using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcpserver;
using System.Runtime.Remoting.Channels;



namespace tcpipclient
{
    public partial class Form1 : Form
    {
        service remoteobj = new service();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            remoteobj = (service)Activator.GetObject(typeof(service),"tcp://localhost:8089/ourfirstremoteservice");
            int n1 = Int32.Parse(txt1.Text);
            int n2 = Int32.Parse(txt2.Text);
            result.Text=remoteobj.highestnumber(n1,n2).ToString();
        }
    }
}
