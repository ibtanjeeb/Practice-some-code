using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadString("http//fiverr.com");
        }
        public void DownloadString(string url)
        {
            var webclient = new WebClient();
            var html = webclient.DownloadString(url);
            using (var streamwriter = new StreamWriter("@E:Result.html"))
            {
                streamwriter.Write(html);

            }

        }
    }
}
