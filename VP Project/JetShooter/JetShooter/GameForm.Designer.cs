namespace JetShooter
{
    partial class GameForm
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
            this.TimerBulletMove = new System.Windows.Forms.Timer(this.components);
            this.TimerMeteorMove = new System.Windows.Forms.Timer(this.components);
            this.pointsStats = new System.Windows.Forms.ToolStripStatusLabel();
            this.lifeLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.levelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BossTimer = new System.Windows.Forms.Timer(this.components);
            this.bossHealth = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerBulletMove
            // 
            this.TimerBulletMove.Interval = 10;
            this.TimerBulletMove.Tick += new System.EventHandler(this.TimerBulletMove_Tick);
            // 
            // TimerMeteorMove
            // 
            this.TimerMeteorMove.Interval = 20;
            this.TimerMeteorMove.Tick += new System.EventHandler(this.TimerMeteorMove_Tick);
            // 
            // pointsStats
            // 
            this.pointsStats.Name = "pointsStats";
            this.pointsStats.Size = new System.Drawing.Size(83, 32);
            this.pointsStats.Text = "Points:";
            // 
            // lifeLeft
            // 
            this.lifeLeft.Name = "lifeLeft";
            this.lifeLeft.Size = new System.Drawing.Size(237, 32);
            this.lifeLeft.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsStats,
            this.lifeLeft,
            this.levelLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 837);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(774, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // levelLabel
            // 
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(237, 32);
            this.levelLabel.Text = "toolStripStatusLabel1";
            // 
            // BossTimer
            // 
            this.BossTimer.Tick += new System.EventHandler(this.BossTimer_Tick);
            // 
            // bossHealth
            // 
            this.bossHealth.Location = new System.Drawing.Point(19, 786);
            this.bossHealth.Name = "bossHealth";
            this.bossHealth.Size = new System.Drawing.Size(730, 30);
            this.bossHealth.TabIndex = 2;
            this.bossHealth.Value = 100;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 879);
            this.Controls.Add(this.bossHealth);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JetShooter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerBulletMove;
        private System.Windows.Forms.Timer TimerMeteorMove;
        private System.Windows.Forms.ToolStripStatusLabel pointsStats;
        private System.Windows.Forms.ToolStripStatusLabel lifeLeft;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer BossTimer;
        private System.Windows.Forms.ToolStripStatusLabel levelLabel;
        private System.Windows.Forms.ProgressBar bossHealth;
    }
}