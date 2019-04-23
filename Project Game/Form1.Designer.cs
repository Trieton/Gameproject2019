namespace Project_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.Character = new System.Windows.Forms.PictureBox();
            this.MoveLeft = new System.Windows.Forms.Timer(this.components);
            this.MoveRight = new System.Windows.Forms.Timer(this.components);
            this.MoveDown = new System.Windows.Forms.Timer(this.components);
            this.MoveUp = new System.Windows.Forms.Timer(this.components);
            this.LazerMove = new System.Windows.Forms.Timer(this.components);
            this.EnemyMove = new System.Windows.Forms.Timer(this.components);
            this.EnemyAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundTimer
            // 
            this.backgroundTimer.Enabled = true;
            this.backgroundTimer.Interval = 10;
            this.backgroundTimer.Tick += new System.EventHandler(this.BackgroundTimer_Tick);
            // 
            // Character
            // 
            this.Character.Image = ((System.Drawing.Image)(resources.GetObject("Character.Image")));
            this.Character.Location = new System.Drawing.Point(268, 399);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(50, 50);
            this.Character.TabIndex = 0;
            this.Character.TabStop = false;
            // 
            // MoveLeft
            // 
            this.MoveLeft.Interval = 5;
            this.MoveLeft.Tick += new System.EventHandler(this.MoveLeft_Tick);
            // 
            // MoveRight
            // 
            this.MoveRight.Interval = 5;
            this.MoveRight.Tick += new System.EventHandler(this.MoveRight_Tick);
            // 
            // MoveDown
            // 
            this.MoveDown.Interval = 5;
            this.MoveDown.Tick += new System.EventHandler(this.MoveDown_Tick);
            // 
            // MoveUp
            // 
            this.MoveUp.Interval = 5;
            this.MoveUp.Tick += new System.EventHandler(this.MoveUp_Tick);
            // 
            // LazerMove
            // 
            this.LazerMove.Enabled = true;
            this.LazerMove.Interval = 20;
            this.LazerMove.Tick += new System.EventHandler(this.LazerMove_Tick);
            // 
            // EnemyMove
            // 
            this.EnemyMove.Enabled = true;
            this.EnemyMove.Tick += new System.EventHandler(this.EnemyMove_Tick);
            // 
            // EnemyAttackTimer
            // 
            this.EnemyAttackTimer.Enabled = true;
            this.EnemyAttackTimer.Interval = 20;
            this.EnemyAttackTimer.Tick += new System.EventHandler(this.EnemyAttackTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Power Green", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(207, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 77);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // ReplayButton
            // 
            this.ReplayButton.Font = new System.Drawing.Font("Power Green", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayButton.Location = new System.Drawing.Point(177, 263);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(234, 56);
            this.ReplayButton.TabIndex = 2;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Visible = false;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Power Green", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(177, 336);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(234, 57);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Visible = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Power Green", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreLabel.Location = new System.Drawing.Point(540, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(32, 25);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "00";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Power Green", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LevelLabel.Location = new System.Drawing.Point(88, 9);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(22, 25);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Power Green", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(457, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Power Green", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Level :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Character);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer backgroundTimer;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.Timer MoveLeft;
        private System.Windows.Forms.Timer MoveRight;
        private System.Windows.Forms.Timer MoveDown;
        private System.Windows.Forms.Timer MoveUp;
        private System.Windows.Forms.Timer LazerMove;
        private System.Windows.Forms.Timer EnemyMove;
        private System.Windows.Forms.Timer EnemyAttackTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

