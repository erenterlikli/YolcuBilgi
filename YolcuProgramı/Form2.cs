using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YolcuProgramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://mgm.gov.tr/?il=Adana");
            webBrowser2.Navigate("https://mgm.gov.tr/?il=Hatay&ilce=Iskenderun");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://46.20.3.229/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralpopwmp.radyotvonline.com:80/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shoutcast.radyogrup.com:1030/; ";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
