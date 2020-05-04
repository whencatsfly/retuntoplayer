using ConsoleApp1.Interface;
using ConsoleApp1.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConsoleApp1.Utils.Enums;

namespace ConsoleApp1
{
    public partial class CoinDenomination : Form, ProgressForm
    {
        public CoinDenomination()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {

            progressBar1.Maximum = Convert.ToInt32(RunTimesValue.Text);
            progressBar1.Step = 1;
            progressBar1.Update();

            var spinRequest = new SpinRequest(this);
            spinRequest.Method = Verbs.GET;
            var pdata = spinRequest.PostData;

            var betReq = new BetRequest();

            var config = new Configurations
            {
                Export = export.Checked,
                gameName = GameValue.Text,
                TokenKey = KeyValue.Text,
                TimeStamp = TsValue.Text,
                currency = currency.Text,
                multiplier = "1",
                GameType = comboBox1.SelectedIndex.ToString()
            };
            var betRes = betReq.GetBetsRequest(config);
            config.RunTimes = Int32.Parse(RunTimesValue.Text);

            foreach (var bet in betRes)
            {
                config.Bet = bet;
                Console.WriteLine(config.Bet);
                spinRequest.SRequest(config);
            }

            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }

        }
        public void UpdateProgress(Configurations config,int progress)
        {

            //int prog = (progress / Convert.ToInt32(RunTimesValue.Text)) * 100;
            this.progressBar1.Value = progress;
            progressBar1.Update();
            this.label3.Text = $"Current bet: {config.Bet}, Count: {progress.ToString()}";
            label3.Update();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
