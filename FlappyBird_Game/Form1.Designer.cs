
namespace FlappyBird_Game
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
            this.picturebox_top = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_top
            // 
            this.picturebox_top.Image = global::FlappyBird_Game.Properties.Resources.pipedown;
            this.picturebox_top.Location = new System.Drawing.Point(459, -5);
            this.picturebox_top.Name = "picturebox_top";
            this.picturebox_top.Size = new System.Drawing.Size(127, 189);
            this.picturebox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_top.TabIndex = 0;
            this.picturebox_top.TabStop = false;
            // 
            // pictureBox_Bird
            // 
            this.pictureBox_Bird.Image = global::FlappyBird_Game.Properties.Resources.bird;
            this.pictureBox_Bird.Location = new System.Drawing.Point(38, 187);
            this.pictureBox_Bird.Name = "pictureBox_Bird";
            this.pictureBox_Bird.Size = new System.Drawing.Size(71, 53);
            this.pictureBox_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bird.TabIndex = 1;
            this.pictureBox_Bird.TabStop = false;
            // 
            // pictureBox_Bottom
            // 
            this.pictureBox_Bottom.Image = global::FlappyBird_Game.Properties.Resources.pipe;
            this.pictureBox_Bottom.Location = new System.Drawing.Point(269, 358);
            this.pictureBox_Bottom.Name = "pictureBox_Bottom";
            this.pictureBox_Bottom.Size = new System.Drawing.Size(127, 225);
            this.pictureBox_Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom.TabIndex = 2;
            this.pictureBox_Bottom.TabStop = false;
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = global::FlappyBird_Game.Properties.Resources.ground;
            this.pictureBox_Ground.Location = new System.Drawing.Point(-15, 536);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(650, 131);
            this.pictureBox_Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ground.TabIndex = 3;
            this.pictureBox_Ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // timer_GameControl
            // 
            this.timer_GameControl.Interval = 20;
            this.timer_GameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlamak İçin Enter\'a Tıklayın";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(598, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.pictureBox_Bottom);
            this.Controls.Add(this.pictureBox_Bird);
            this.Controls.Add(this.picturebox_top);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_top;
        private System.Windows.Forms.PictureBox pictureBox_Bird;
        private System.Windows.Forms.PictureBox pictureBox_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_GameControl;
        private System.Windows.Forms.Label label2;
    }
}

