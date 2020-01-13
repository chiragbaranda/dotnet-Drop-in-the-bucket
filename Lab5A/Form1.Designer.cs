namespace Lab5A
{
    partial class Lab5A_form
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
            this.components = new System.ComponentModel.Container();
            this.ColorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cdlColorChooser = new System.Windows.Forms.ColorDialog();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(46, 12);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 23);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(166, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cdlColorChooser
            // 
            this.cdlColorChooser.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(46, 82);
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(104, 45);
            this.speedTrackBar.TabIndex = 0;
            this.speedTrackBar.TickFrequency = 10;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab5A.Properties.Resources.Faucet;
            this.pictureBox1.Location = new System.Drawing.Point(41, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 69);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lab5A_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(309, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.ColorButton);
            this.Name = "Lab5A_form";
            this.Text = "A Drop In The Bucket";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paintForm);
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ColorDialog cdlColorChooser;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

