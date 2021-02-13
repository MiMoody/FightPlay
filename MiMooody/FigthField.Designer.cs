namespace MiMooody
{
    partial class FigthField
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
            this.updateClouds = new System.Windows.Forms.Timer(this.components);
            this.leftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.upMovetimer = new System.Windows.Forms.Timer(this.components);
            this.downMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.rightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.mainHero = new System.Windows.Forms.PictureBox();
            this.bulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.collisionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainHero)).BeginInit();
            this.SuspendLayout();
            // 
            // updateClouds
            // 
            this.updateClouds.Enabled = true;
            this.updateClouds.Interval = 10;
            this.updateClouds.Tick += new System.EventHandler(this.updateClouds_Tick);
            // 
            // leftMoveTimer
            // 
            this.leftMoveTimer.Interval = 10;
            this.leftMoveTimer.Tick += new System.EventHandler(this.leftMoveTimer_Tick);
            // 
            // upMovetimer
            // 
            this.upMovetimer.Interval = 10;
            this.upMovetimer.Tick += new System.EventHandler(this.upMovetimer_Tick);
            // 
            // downMoveTimer
            // 
            this.downMoveTimer.Interval = 10;
            this.downMoveTimer.Tick += new System.EventHandler(this.downMoveTimer_Tick);
            // 
            // rightMoveTimer
            // 
            this.rightMoveTimer.Interval = 10;
            this.rightMoveTimer.Tick += new System.EventHandler(this.rightMoveTimer_Tick);
            // 
            // mainHero
            // 
            this.mainHero.BackColor = System.Drawing.Color.Transparent;
            this.mainHero.Image = global::MiMooody.Properties.Resources.герой_стоит;
            this.mainHero.Location = new System.Drawing.Point(164, 524);
            this.mainHero.Name = "mainHero";
            this.mainHero.Size = new System.Drawing.Size(130, 120);
            this.mainHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainHero.TabIndex = 0;
            this.mainHero.TabStop = false;
            // 
            // bulletsTimer
            // 
            this.bulletsTimer.Enabled = true;
            this.bulletsTimer.Interval = 10;
            this.bulletsTimer.Tick += new System.EventHandler(this.bulletsTimer_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 10;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // collisionTimer
            // 
            this.collisionTimer.Enabled = true;
            this.collisionTimer.Interval = 10;
            this.collisionTimer.Tick += new System.EventHandler(this.collisionTimer_Tick);
            // 
            // FigthField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiMooody.Properties.Resources.Фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainHero);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FigthField";
            this.Text = "FigthField";
            this.Load += new System.EventHandler(this.FigthField_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FigthField_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FigthField_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainHero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateClouds;
        private System.Windows.Forms.Timer leftMoveTimer;
        private System.Windows.Forms.Timer upMovetimer;
        private System.Windows.Forms.Timer downMoveTimer;
        private System.Windows.Forms.Timer rightMoveTimer;
        private System.Windows.Forms.PictureBox mainHero;
        private System.Windows.Forms.Timer bulletsTimer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.Timer collisionTimer;
    }
}