using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace Project_Game
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer gameSound;
        WindowsMediaPlayer shootSound;
        WindowsMediaPlayer explosionSound;

        int lazerSpeed;
        int backgroundspeed;
        int playerSpeed;
        int enemySpeed;
        int enemyShootSpeed;
        int score;
        int level;
        int difficulty;
        bool pause;
        bool gameIsOver;

        PictureBox[] lazers;
        PictureBox[] stars;
        PictureBox[] enemy;
        PictureBox[] enemyShoot;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            difficulty = 9;

            backgroundspeed = 3;
            playerSpeed = 4;
            lazerSpeed = 20;
            enemySpeed = 4;
            enemyShootSpeed = 5;

            stars = new PictureBox[13];
            rnd = new Random();
            lazers = new PictureBox[3];
            enemy = new PictureBox[10];
            enemyShoot = new PictureBox[10];

            gameSound = new WindowsMediaPlayer();
            shootSound = new WindowsMediaPlayer();
            explosionSound = new WindowsMediaPlayer();

            Image lazer = Image.FromFile(@"Assets\Playerlazer.png");
            Image enemy1 = Image.FromFile(@"Assets\Enemy1.gif");
            Image enemy2 = Image.FromFile(@"Assets\Enemy2.gif");
            Image enemy3 = Image.FromFile(@"Assets\Enemy3.gif");
            Image boss = Image.FromFile(@"Assets\Boss.gif");

            for (int i = 0; i < lazers.Length; i++)
            {
                lazers[i] = new PictureBox();
                lazers[i].Size = new Size(8, 8);
                lazers[i].Image = lazer;
                lazers[i].SizeMode = PictureBoxSizeMode.Zoom;
                lazers[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(lazers[i]);
            }

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(10, 590), rnd.Next(-10, 400));

                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.WhiteSmoke;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DimGray;
                }

                this.Controls.Add(stars[i]);
            }

            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i] = new PictureBox();
                enemy[i].Size = new Size(50, 50);
                enemy[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemy[i].BorderStyle = BorderStyle.None;
                enemy[i].Visible = false;
                this.Controls.Add(enemy[i]);
                enemy[i].Location = new Point((i + 1) * 50, -50);
            }

            for (int i = 0; i < enemyShoot.Length; i++)
            {
                int x = rnd.Next(0, 10);
                enemyShoot[i] = new PictureBox
                {
                    Size = new Size(2, 25),
                    Visible = false,
                    BackColor = Color.Red,
                    Location = new Point(enemy[x].Location.X, enemy[x].Location.Y - 20)
                };
                this.Controls.Add(enemyShoot[i]);
            }

            enemy[0].Image = enemy3;
            enemy[1].Image = enemy2;
            enemy[2].Image = enemy3;
            enemy[3].Image = enemy2;
            enemy[4].Image = enemy1;
            enemy[5].Image = boss;
            enemy[6].Image = enemy2;
            enemy[7].Image = enemy3;
            enemy[8].Image = enemy1;
            enemy[9].Image = enemy2;

            gameSound.URL = "Sounds\\Background.mp3";
            shootSound.URL = "Sounds\\Shoot.mp3";
            explosionSound.URL = "Sounds\\Explosion.mp3";

            gameSound.settings.setMode("loop", true);
            gameSound.settings.volume = 2;
            shootSound.settings.volume = 5;
            explosionSound.settings.volume = 3;

            gameSound.controls.play();
        }

        private void BackgroundTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 1;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void MoveUp_Tick(object sender, EventArgs e)
        {
            if (Character.Top > 5)
            {
                Character.Top -= playerSpeed;
            }
        }

        private void MoveDown_Tick(object sender, EventArgs e)
        {
            if (Character.Top < 400)
            {
                Character.Top += playerSpeed;
            }
        }

        private void MoveLeft_Tick(object sender, EventArgs e)
        {
            if (Character.Left > 5)
            {
                Character.Left -= playerSpeed;
            }
        }

        private void MoveRight_Tick(object sender, EventArgs e)
        {
            if (Character.Left < 530)
            {
                Character.Left += playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(pause == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    MoveUp.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    MoveDown.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    MoveLeft.Start();
                }
                if (e.KeyCode == Keys.Right)
                {
                    MoveRight.Start();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MoveUp.Stop();
            MoveDown.Stop();
            MoveLeft.Stop();
            MoveRight.Stop();
            
            if(e.KeyCode == Keys.Space)
            {
                if(!gameIsOver)
                {
                    if(pause)
                    {
                        RestartTimers();
                        label2.Visible = false;
                        gameSound.controls.play();
                        pause = false;
                    }

                    else
                    {
                        label2.Location = new Point(this.Width / 2 - 170, 150);
                        label2.Text = "Game Paused";
                        label2.Visible = true;
                        gameSound.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void Collision()
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                if (lazers[0].Bounds.IntersectsWith(enemy[i].Bounds) | lazers[1].Bounds.IntersectsWith(enemy[i].Bounds) | lazers[2].Bounds.IntersectsWith(enemy[i].Bounds))
                {
                    explosionSound.controls.play();

                    score += 1;
                    ScoreLabel.Text = (score < 10) ? "0" + score.ToString() : score.ToString();

                    if (score % 30 == 0)
                    {
                        level += 1;
                        LevelLabel.Text = (level < 10) ? "0" + level.ToString() : level.ToString();

                        if (enemySpeed <= 10 && enemyShootSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemySpeed++;
                            enemyShootSpeed++;
                        }

                        if (level == 10)
                        {
                            GameOver("You Win");
                        }
                    }

                    enemy[i].Location = new Point((i + 1) * 50, -100);
                }

                if (Character.Bounds.IntersectsWith(enemy[i].Bounds))
                {
                    explosionSound.controls.play();
                    Character.Visible = false;
                    GameOver("Game Over");
                }
            }

        }

        private void LazerMove_Tick(object sender, EventArgs e)
        {
            shootSound.controls.play();
            for (int i = 0; i < lazers.Length; i++)
            {
                if (lazers[i].Top > 0)
                {
                    lazers[i].Visible = true;
                    lazers[i].Top -= lazerSpeed;
                    Collision();
                }
                else
                {
                    lazers[i].Visible = false;
                    lazers[i].Location = new Point(Character.Location.X + 20, Character.Location.Y - i * 30);
                }
            }
        }

        private void EnemyMove_Tick(object sender, EventArgs e)
        {
            Enemymove(enemy, enemySpeed);
        }

        private void Enemymove(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void EnemyAttackTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemyShoot.Length - difficulty; i++)
            {
                if (enemyShoot[i].Top < this.Height)
                {
                    enemyShoot[i].Visible = true;
                    enemyShoot[i].Top += enemyShootSpeed;

                    EnemyLazerCollision();
                }

                else
                {
                    enemyShoot[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemyShoot[i].Location = new Point(enemy[x].Location.X + 20, enemy[x].Location.Y + 30);
                }
            }
        }

        private void EnemyLazerCollision()
        {
            for (int i = 0; i < enemyShoot.Length; i++)
            {
                if (enemyShoot[i].Bounds.IntersectsWith(Character.Bounds))
                    {
                    enemyShoot[i].Visible = false;
                    explosionSound.controls.play();
                    Character.Visible = false;
                    GameOver("Game over");
                    }
            }
            
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void GameOver(String str)
        {
            label2.Text = str;
            label2.Location = new Point(160, 120);
            label2.Visible = true;
            ReplayButton.Visible = true;
            QuitButton.Visible = true;

            gameSound.controls.stop();
            StopTimers();
        }

        private void StopTimers()
        {
            MoveUp.Stop();
            MoveDown.Stop();
            MoveLeft.Stop();
            MoveRight.Stop();            
            backgroundTimer.Stop();
            EnemyMove.Stop();
            LazerMove.Stop();
            EnemyAttackTimer.Stop();
        }

        private void RestartTimers()
        {
            backgroundTimer.Start();
            EnemyMove.Start();
            LazerMove.Start();
            EnemyAttackTimer.Start();
        }

    }
}
