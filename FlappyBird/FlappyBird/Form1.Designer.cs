namespace FlappyBird
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bottompipe = new System.Windows.Forms.PictureBox();
            this.toppipe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottompipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppipe)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Black;
            this.Score.Font = new System.Drawing.Font("PenultimateLight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score.Location = new System.Drawing.Point(2, 846);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(273, 75);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timerevent);
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = global::FlappyBird.Properties.Resources.owl_sprite_drop;
            this.Bird.Location = new System.Drawing.Point(106, 264);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(169, 66);
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Black;
            this.ground.Location = new System.Drawing.Point(-1, 776);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1025, 154);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // bottompipe
            // 
            this.bottompipe.BackColor = System.Drawing.Color.Transparent;
            this.bottompipe.Image = global::FlappyBird.Properties.Resources.tree_obsticles_21;
            this.bottompipe.Location = new System.Drawing.Point(860, 512);
            this.bottompipe.Name = "bottompipe";
            this.bottompipe.Size = new System.Drawing.Size(164, 480);
            this.bottompipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bottompipe.TabIndex = 2;
            this.bottompipe.TabStop = false;
            // 
            // toppipe
            // 
            this.toppipe.BackColor = System.Drawing.Color.Transparent;
            this.toppipe.Image = global::FlappyBird.Properties.Resources.tree_obsticles_12;
            this.toppipe.Location = new System.Drawing.Point(562, -170);
            this.toppipe.Name = "toppipe";
            this.toppipe.Size = new System.Drawing.Size(198, 486);
            this.toppipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.toppipe.TabIndex = 1;
            this.toppipe.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(977, 928);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottompipe);
            this.Controls.Add(this.toppipe);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottompipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toppipe;
        private System.Windows.Forms.PictureBox bottompipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Timer timer;
    }
}

