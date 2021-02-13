using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMooody
{
    public partial class FigthField : Form
    {
        PictureBox[] cloud;
        PictureBox[] bullets;
        PictureBox[] enemy;
        int bulletSpeed;
        int cloudSpeed;
        int playerSpeed;
        int enemySpeed;
        bool collision_;
        Random rnd;
        
        public FigthField()
        {
            InitializeComponent();
        }

        private void FigthField_Load(object sender, EventArgs e)
        {
            cloudSpeed = 5;
            cloud = new PictureBox[20];
            bullets = new PictureBox[1];
            enemy = new PictureBox[3];
            rnd = new Random();
            playerSpeed = 2;
            bulletSpeed = 50;
            enemySpeed = 3;
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i] = new PictureBox();
                enemy[i].BorderStyle = BorderStyle.None;
                enemy[i].Size = new Size(100, 100);
                enemy[i].BackColor = Color.Transparent;
                enemy[i].SizeMode = PictureBoxSizeMode.StretchImage;
                enemy[i].Location = new Point(rnd.Next(500, 1150), rnd.Next(400, 600));
                enemy[i].Image = Properties.Resources.враг;
                this.Controls.Add(enemy[i]);
            }
            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(10, 250));
                if (i % 2 == 1)
                {
                    cloud[i].Size = new Size(rnd.Next(100, 200), rnd.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 80, 67, 104);



                }
                else
                {
                    cloud[i].Size = new Size(rnd.Next(80, 100), rnd.Next(20, 40));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 80, 67, 104);

                }
                this.Controls.Add(cloud[i]);
            }
            
            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(20, 10);
                bullets[i].BackColor = Color.White;

                this.Controls.Add(bullets[i]);
            }
        }

        private void leftMoveTimer_Tick(object sender, EventArgs e)
        {
            
            if (mainHero.Left > 10)
            {
                mainHero.Left -= playerSpeed;
            }
        }

        private void upMovetimer_Tick(object sender, EventArgs e)
        {

            if (mainHero.Top > 410)
            {
                mainHero.Top -= playerSpeed;
            }
        }

        private void downMoveTimer_Tick(object sender, EventArgs e)
        {
            
            if (mainHero.Top < 550)
            {
                mainHero.Top += playerSpeed;
            }
        }

        private void rightMoveTimer_Tick(object sender, EventArgs e)
        {
            
            if (mainHero.Left < 1150)
            {
                mainHero.Left += playerSpeed;
            }
        }

        private void FigthField_KeyDown(object sender, KeyEventArgs e)
        {

            mainHero.Image = Properties.Resources.герой_бег;

            if (e.KeyCode == Keys.Up)
            {
                upMovetimer.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                downMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                leftMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                rightMoveTimer.Start();
            }
            if (e.KeyCode== Keys.Space)
            {
               
                for (int i =0; i<bullets.Length;i++)
                {
                    bullets[i].Location = new Point(mainHero.Location.X +100+i*50,mainHero.Location.Y+55);
                }
                

            }
        }

        private void FigthField_KeyUp(object sender, KeyEventArgs e)
        {
            mainHero.Image = Properties.Resources.герой_стоит;
            rightMoveTimer.Stop();
            leftMoveTimer.Stop();
            downMoveTimer.Stop();
            upMovetimer.Stop();
            
        }

        private void updateClouds_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i].Left += cloudSpeed;
                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }
            }
            for (int i = cloud.Length; i < cloud.Length; i++)
            {
                cloud[i].Left += cloudSpeed - 10;
                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Left;
                }
            }
        }

        private void bulletsTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0;i<bullets.Length;i++)
            {
                bullets[i].Left += bulletSpeed;
            }
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i<enemy.Length;i++)
            {
                    if (enemy[i].Left >= 0)
                    {
                        enemy[i].Left -= enemySpeed;
                    }
                    if (enemy[i].Left <= 0)
                    {
                        enemy[i].Left = this.Width;
                    }

            }
        }

        private void collisionTimer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
