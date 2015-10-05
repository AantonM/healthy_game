namespace HealthyGame
{
    partial class Form1
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.picUnhealthy = new System.Windows.Forms.PictureBox();
            this.picHealthy = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnhealthy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealthy)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 147);
            this.panel1.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 76);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 49);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(107, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "what kind of food it is";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(13, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "timer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.picFood);
            this.panel2.Controls.Add(this.picUnhealthy);
            this.panel2.Controls.Add(this.picHealthy);
            this.panel2.Location = new System.Drawing.Point(222, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 426);
            this.panel2.TabIndex = 4;
            // 
            // picFood
            // 
            this.picFood.BackColor = System.Drawing.Color.Transparent;
            this.picFood.Location = new System.Drawing.Point(214, 16);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(84, 61);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 2;
            this.picFood.TabStop = false;
            // 
            // picUnhealthy
            // 
            this.picUnhealthy.Image = global::HealthyGame.Properties.Resources.Unhealthy;
            this.picUnhealthy.Location = new System.Drawing.Point(322, 299);
            this.picUnhealthy.Name = "picUnhealthy";
            this.picUnhealthy.Size = new System.Drawing.Size(141, 123);
            this.picUnhealthy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnhealthy.TabIndex = 1;
            this.picUnhealthy.TabStop = false;
            // 
            // picHealthy
            // 
            this.picHealthy.Image = global::HealthyGame.Properties.Resources.healthy;
            this.picHealthy.Location = new System.Drawing.Point(3, 299);
            this.picHealthy.Name = "picHealthy";
            this.picHealthy.Size = new System.Drawing.Size(141, 123);
            this.picHealthy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHealthy.TabIndex = 0;
            this.picHealthy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::HealthyGame.Properties.Resources.healthy_food;
            this.ClientSize = new System.Drawing.Size(700, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort the food";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnhealthy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHealthy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHealthy;
        private System.Windows.Forms.PictureBox picUnhealthy;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblScore;
    }
}

