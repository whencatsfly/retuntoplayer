using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
           
        }

        private void RTPButton_Click(object sender, EventArgs e)
        {
            CD rtp = new CD();
            rtp.FormClosed += new FormClosedEventHandler(rtp_FormClosed);
            rtp.Show();
            this.Hide();
            

        }

        private void CdButton_Click(object sender, EventArgs e)
        {
            CoinDenomination cd = new CoinDenomination();
            cd.FormClosed += new FormClosedEventHandler(cd_FormClosed);
            cd.Show();
            this.Hide();

        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void rtp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void cd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
