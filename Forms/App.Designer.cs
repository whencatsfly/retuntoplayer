namespace ConsoleApp1
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.RTPButton = new System.Windows.Forms.Button();
            this.CdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTPButton
            // 
            this.RTPButton.BackColor = System.Drawing.Color.Transparent;
            this.RTPButton.Location = new System.Drawing.Point(52, 26);
            this.RTPButton.Name = "RTPButton";
            this.RTPButton.Size = new System.Drawing.Size(108, 23);
            this.RTPButton.TabIndex = 0;
            this.RTPButton.Text = "RTP";
            this.RTPButton.UseVisualStyleBackColor = false;
            this.RTPButton.Click += new System.EventHandler(this.RTPButton_Click);
            // 
            // CdButton
            // 
            this.CdButton.Location = new System.Drawing.Point(52, 76);
            this.CdButton.Name = "CdButton";
            this.CdButton.Size = new System.Drawing.Size(108, 23);
            this.CdButton.TabIndex = 1;
            this.CdButton.Text = "Coin Denomination";
            this.CdButton.UseVisualStyleBackColor = true;
            this.CdButton.Click += new System.EventHandler(this.CdButton_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(220, 161);
            this.Controls.Add(this.CdButton);
            this.Controls.Add(this.RTPButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RTPButton;
        private System.Windows.Forms.Button CdButton;
    }
}