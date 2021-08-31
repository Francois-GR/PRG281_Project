
namespace Project_PRG
{
    partial class GameMode
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
            this.btnGenreToArt = new System.Windows.Forms.Button();
            this.btnArtToSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayerMode = new System.Windows.Forms.Label();
            this.txtSecondPlayer = new System.Windows.Forms.TextBox();
            this.lblPromtName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenreToArt
            // 
            this.btnGenreToArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnGenreToArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenreToArt.Location = new System.Drawing.Point(512, 177);
            this.btnGenreToArt.Name = "btnGenreToArt";
            this.btnGenreToArt.Size = new System.Drawing.Size(260, 52);
            this.btnGenreToArt.TabIndex = 0;
            this.btnGenreToArt.Text = "Match Genre to Artist";
            this.btnGenreToArt.UseVisualStyleBackColor = false;
            this.btnGenreToArt.Click += new System.EventHandler(this.btnGenreToArt_Click);
            // 
            // btnArtToSong
            // 
            this.btnArtToSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnArtToSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtToSong.Location = new System.Drawing.Point(512, 286);
            this.btnArtToSong.Name = "btnArtToSong";
            this.btnArtToSong.Size = new System.Drawing.Size(260, 52);
            this.btnArtToSong.TabIndex = 1;
            this.btnArtToSong.Text = "Match Artist to Song";
            this.btnArtToSong.UseVisualStyleBackColor = false;
            this.btnArtToSong.Click += new System.EventHandler(this.btnArtToSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(544, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Modes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(512, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayerMode
            // 
            this.lblPlayerMode.AutoSize = true;
            this.lblPlayerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPlayerMode.Location = new System.Drawing.Point(559, 124);
            this.lblPlayerMode.Name = "lblPlayerMode";
            this.lblPlayerMode.Size = new System.Drawing.Size(175, 31);
            this.lblPlayerMode.TabIndex = 5;
            this.lblPlayerMode.Text = "Game Modes";
            // 
            // txtSecondPlayer
            // 
            this.txtSecondPlayer.Location = new System.Drawing.Point(1115, 136);
            this.txtSecondPlayer.Name = "txtSecondPlayer";
            this.txtSecondPlayer.Size = new System.Drawing.Size(176, 20);
            this.txtSecondPlayer.TabIndex = 6;
            // 
            // lblPromtName
            // 
            this.lblPromtName.AutoSize = true;
            this.lblPromtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPromtName.Location = new System.Drawing.Point(778, 127);
            this.lblPromtName.Name = "lblPromtName";
            this.lblPromtName.Size = new System.Drawing.Size(315, 29);
            this.lblPromtName.TabIndex = 7;
            this.lblPromtName.Text = "Enter Second players name:";
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1357, 634);
            this.Controls.Add(this.lblPromtName);
            this.Controls.Add(this.txtSecondPlayer);
            this.Controls.Add(this.lblPlayerMode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArtToSong);
            this.Controls.Add(this.btnGenreToArt);
            this.Name = "GameMode";
            this.Text = "GameMode";
            this.Load += new System.EventHandler(this.GameMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenreToArt;
        private System.Windows.Forms.Button btnArtToSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayerMode;
        private System.Windows.Forms.TextBox txtSecondPlayer;
        private System.Windows.Forms.Label lblPromtName;
    }
}