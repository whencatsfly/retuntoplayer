namespace ConsoleApp1
{
    partial class CoinDenomination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinDenomination));
            this.RunTimesValue = new System.Windows.Forms.TextBox();
            this.runTimesLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.TsValue = new System.Windows.Forms.TextBox();
            this.KeyValue = new System.Windows.Forms.TextBox();
            this.GameValue = new System.Windows.Forms.TextBox();
            this.TimestampLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.TextBox();
            this.export = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RunTimesValue
            // 
            this.RunTimesValue.Location = new System.Drawing.Point(71, 139);
            this.RunTimesValue.Name = "RunTimesValue";
            this.RunTimesValue.Size = new System.Drawing.Size(131, 20);
            this.RunTimesValue.TabIndex = 19;
            // 
            // runTimesLabel
            // 
            this.runTimesLabel.AutoSize = true;
            this.runTimesLabel.BackColor = System.Drawing.Color.Transparent;
            this.runTimesLabel.Location = new System.Drawing.Point(7, 146);
            this.runTimesLabel.Name = "runTimesLabel";
            this.runTimesLabel.Size = new System.Drawing.Size(58, 13);
            this.runTimesLabel.TabIndex = 18;
            this.runTimesLabel.Text = "Run Times";
            // 
            // RunButton
            // 
            this.RunButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RunButton.Location = new System.Drawing.Point(126, 213);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(80, 23);
            this.RunButton.TabIndex = 17;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // TsValue
            // 
            this.TsValue.Location = new System.Drawing.Point(71, 64);
            this.TsValue.Name = "TsValue";
            this.TsValue.Size = new System.Drawing.Size(131, 20);
            this.TsValue.TabIndex = 16;
            // 
            // KeyValue
            // 
            this.KeyValue.Location = new System.Drawing.Point(50, 38);
            this.KeyValue.Name = "KeyValue";
            this.KeyValue.Size = new System.Drawing.Size(152, 20);
            this.KeyValue.TabIndex = 15;
            // 
            // GameValue
            // 
            this.GameValue.Location = new System.Drawing.Point(50, 12);
            this.GameValue.Name = "GameValue";
            this.GameValue.Size = new System.Drawing.Size(152, 20);
            this.GameValue.TabIndex = 14;
            // 
            // TimestampLabel
            // 
            this.TimestampLabel.AutoSize = true;
            this.TimestampLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimestampLabel.Location = new System.Drawing.Point(7, 71);
            this.TimestampLabel.Name = "TimestampLabel";
            this.TimestampLabel.Size = new System.Drawing.Size(58, 13);
            this.TimestampLabel.TabIndex = 13;
            this.TimestampLabel.Text = "Timestamp";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyLabel.Location = new System.Drawing.Point(8, 41);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 12;
            this.keyLabel.Text = "Key";
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.Location = new System.Drawing.Point(8, 12);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(35, 13);
            this.gameNameLabel.TabIndex = 11;
            this.gameNameLabel.Text = "Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Currency";
            // 
            // currency
            // 
            this.currency.Location = new System.Drawing.Point(71, 99);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(131, 20);
            this.currency.TabIndex = 21;
            // 
            // export
            // 
            this.export.AutoSize = true;
            this.export.BackColor = System.Drawing.Color.Transparent;
            this.export.Checked = true;
            this.export.CheckState = System.Windows.Forms.CheckState.Checked;
            this.export.Location = new System.Drawing.Point(10, 219);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(97, 17);
            this.export.TabIndex = 22;
            this.export.Text = "Export to Excel";
            this.export.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(73, 256);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 24;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Location = new System.Drawing.Point(7, 292);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 25;
            this.status.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Game Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cascading",
            "Freespin w/ Bonus",
            "Freespin Only"});
            this.comboBox1.Location = new System.Drawing.Point(73, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // CoinDenomination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(246, 327);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.export);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunTimesValue);
            this.Controls.Add(this.runTimesLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.TsValue);
            this.Controls.Add(this.KeyValue);
            this.Controls.Add(this.GameValue);
            this.Controls.Add(this.TimestampLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.gameNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoinDenomination";
            this.Text = "CoinDenomination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RunTimesValue;
        private System.Windows.Forms.Label runTimesLabel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox TsValue;
        private System.Windows.Forms.TextBox KeyValue;
        private System.Windows.Forms.TextBox GameValue;
        private System.Windows.Forms.Label TimestampLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currency;
        private System.Windows.Forms.CheckBox export;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label status;
        public System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}