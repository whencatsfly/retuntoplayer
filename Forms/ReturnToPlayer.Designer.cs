namespace ConsoleApp1
{
    partial class CD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CD));
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.TimestampLabel = new System.Windows.Forms.Label();
            this.GameValue = new System.Windows.Forms.TextBox();
            this.KeyValue = new System.Windows.Forms.TextBox();
            this.BetValue = new System.Windows.Forms.TextBox();
            this.TsValue = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.runTimesLabel = new System.Windows.Forms.Label();
            this.RunTimesValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.multiplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.Location = new System.Drawing.Point(13, 24);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(35, 13);
            this.gameNameLabel.TabIndex = 0;
            this.gameNameLabel.Text = "Game";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyLabel.Location = new System.Drawing.Point(13, 53);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(29, 13);
            this.keyLabel.TabIndex = 1;
            this.keyLabel.Text = "User";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.BackColor = System.Drawing.Color.Transparent;
            this.betLabel.Location = new System.Drawing.Point(13, 85);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(23, 13);
            this.betLabel.TabIndex = 2;
            this.betLabel.Text = "Bet";
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.Location = new System.Drawing.Point(0, 0);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(100, 23);
            this.TimestampLabel.TabIndex = 31;
            // 
            // GameValue
            // 
            this.GameValue.Location = new System.Drawing.Point(55, 24);
            this.GameValue.Name = "GameValue";
            this.GameValue.Size = new System.Drawing.Size(152, 20);
            this.GameValue.TabIndex = 4;
            // 
            // KeyValue
            // 
            this.KeyValue.Location = new System.Drawing.Point(55, 50);
            this.KeyValue.Name = "KeyValue";
            this.KeyValue.Size = new System.Drawing.Size(152, 20);
            this.KeyValue.TabIndex = 5;
            // 
            // BetValue
            // 
            this.BetValue.Location = new System.Drawing.Point(55, 82);
            this.BetValue.Name = "BetValue";
            this.BetValue.Size = new System.Drawing.Size(152, 20);
            this.BetValue.TabIndex = 6;
            // 
            // TsValue
            // 
            this.TsValue.Location = new System.Drawing.Point(76, 141);
            this.TsValue.Name = "TsValue";
            this.TsValue.Size = new System.Drawing.Size(131, 20);
            this.TsValue.TabIndex = 7;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(134, 242);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 8;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // runTimesLabel
            // 
            this.runTimesLabel.AutoSize = true;
            this.runTimesLabel.BackColor = System.Drawing.Color.Transparent;
            this.runTimesLabel.Location = new System.Drawing.Point(12, 172);
            this.runTimesLabel.Name = "runTimesLabel";
            this.runTimesLabel.Size = new System.Drawing.Size(58, 13);
            this.runTimesLabel.TabIndex = 9;
            this.runTimesLabel.Text = "Run Times";
            // 
            // RunTimesValue
            // 
            this.RunTimesValue.Location = new System.Drawing.Point(76, 169);
            this.RunTimesValue.Name = "RunTimesValue";
            this.RunTimesValue.Size = new System.Drawing.Size(131, 20);
            this.RunTimesValue.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Multiplier";
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(76, 115);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(131, 20);
            this.multiplier.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = ".";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Location = new System.Drawing.Point(12, 314);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 29;
            this.status.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "timeStamp";
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(66, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 28;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Progress";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Game Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cascading",
            "Freespin w/ Bonus",
            "Freespin Only"});
            this.comboBox1.Location = new System.Drawing.Point(76, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(262, 336);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunTimesValue);
            this.Controls.Add(this.runTimesLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.TsValue);
            this.Controls.Add(this.BetValue);
            this.Controls.Add(this.KeyValue);
            this.Controls.Add(this.GameValue);
            this.Controls.Add(this.TimestampLabel);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.gameNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CD";
            this.Text = "RTP";
            this.Load += new System.EventHandler(this.CD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label TimestampLabel;
        private System.Windows.Forms.TextBox GameValue;
        private System.Windows.Forms.TextBox KeyValue;
        private System.Windows.Forms.TextBox BetValue;
        private System.Windows.Forms.TextBox TsValue;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label runTimesLabel;
        private System.Windows.Forms.TextBox RunTimesValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox multiplier;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        public  System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}