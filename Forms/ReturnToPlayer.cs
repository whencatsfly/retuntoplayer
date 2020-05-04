using ConsoleApp1.Interface;
using ConsoleApp1.Requests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConsoleApp1.Utils.Enums;

namespace ConsoleApp1
{
    public partial class CD : Form, ProgressForm
    {

        [JsonProperty(PropertyName = "accessToken")]
        public string accessToken { get; set; }


        public CD()
        {
            InitializeComponent();
        }


        private void RunButton_Click(object sender, EventArgs e)
        {

            progressBar1.Maximum = Convert.ToInt32(RunTimesValue.Text);
            progressBar1.Step = 1;
            progressBar1.Update();


            var config1 = new Configurations();
            var spinRequest = new SpinRequest(this);
            var authToken = new AuthenticateToken();
            spinRequest.Method = Verbs.GET;
            var pdata = spinRequest.PostData;

            var betReq = new BetRequest();

            String keysValue= KeyValue.Text;
            config1.TokenNames = KeyValue.Text.Split(',');
            string gamesType = comboBox1.SelectedIndex.ToString();

            var configs = authToken.AuthTokens(config1).Select(t => {
                var result = new Configurations();
                result.TokenKey = t;
                result.gameName = GameValue.Text;
                result.TimeStamp = TsValue.Text;
                result.multiplier = multiplier.Text;
                result.Bet = BetValue.Text;
                result.GameType = gamesType;
                result.RunTimes = Int32.Parse(RunTimesValue.Text);

                return result;
            });

            Parallel.ForEach(configs, (conf, state) => { 
                spinRequest.SRequest(conf);
                System.Threading.Thread.Sleep(3000);
            }
            );

        }

        private void CD_Load(object sender, EventArgs e)
        {
            //GameValue.Text = Configurations.gameName;
        }

        private void TimestampLabel_Click(object sender, EventArgs e)
        {

        }

        private void Duplicate_Click(object sender, EventArgs e)
        {
            //GameValue.Text = Configurations.gameName;
            CD rtp = new CD();
            rtp.Show();


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


        public void UpdateProgress(Configurations config, int progress)
        {

            if (this.progressBar1.InvokeRequired)
            {
                this.progressBar1.BeginInvoke((MethodInvoker)delegate () { this.progressBar1.Value = progress; });
                //label3.Update();
            }
            else
            {
                this.progressBar1.Value = progress;
                progressBar1.PerformStep();
            }
            if (this.label3.InvokeRequired)
            {
                this.label3.BeginInvoke((MethodInvoker)delegate () { this.label3.Text = progress.ToString(); ; });
                //label3.Update();
            }
            else
            {
                this.label3.Text = progress.ToString();
                label3.Update();
            }

        }
        private void AggiornaContatore()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.KeyValue.Text = string.Empty;
            try
            {

                using (FileStream fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                using (var file = new StreamReader(this.openFileDialog1.FileName))
                {
                    while (!file.EndOfStream)
                    {
                        var line = file.ReadLine();
                        // Add values into dictionary with data type is DataGridview row                    
                        this.KeyValue.Text += line;
                    }
                    //this.KeyValue.Text = this.KeyValue.Text.Trim(',');
                    file.Close();
                    file.Dispose();
                    fs.Flush();
                    this.openFileDialog1.Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Token Already Expired!");
            }

        }

        private void GameType_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
