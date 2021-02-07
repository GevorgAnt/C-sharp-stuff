namespace Flappy_bird
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
            this.Score = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BirdPicture = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.PipeUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BirdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.SaddleBrown;
            this.Score.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 405);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(123, 36);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score :0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.TimerupdateEvent);
            // 
            // BirdPicture
            // 
            this.BirdPicture.BackColor = System.Drawing.Color.Transparent;
            this.BirdPicture.Image = global::Flappy_bird.Properties.Resources.clipart3466124;
            this.BirdPicture.Location = new System.Drawing.Point(64, 148);
            this.BirdPicture.Name = "BirdPicture";
            this.BirdPicture.Size = new System.Drawing.Size(62, 43);
            this.BirdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BirdPicture.TabIndex = 2;
            this.BirdPicture.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.BackColor = System.Drawing.Color.Transparent;
            this.PipeDown.Image = global::Flappy_bird.Properties.Resources.PipeDown;
            this.PipeDown.Location = new System.Drawing.Point(589, 1);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(100, 132);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 0;
            this.PipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Flappy_bird.Properties.Resources.ground1;
            this.ground.Location = new System.Drawing.Point(0, 389);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(798, 68);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // PipeUp
            // 
            this.PipeUp.BackColor = System.Drawing.Color.Transparent;
            this.PipeUp.Image = global::Flappy_bird.Properties.Resources.PipeUp;
            this.PipeUp.Location = new System.Drawing.Point(589, 258);
            this.PipeUp.Name = "PipeUp";
            this.PipeUp.Size = new System.Drawing.Size(100, 314);
            this.PipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeUp.TabIndex = 1;
            this.PipeUp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.BirdPicture);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.PipeUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.BirdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox PipeUp;
        private System.Windows.Forms.PictureBox BirdPicture;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer GameTimer;
    }
}

