namespace Project_PRG
{
    partial class GenreForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenresListBox = new System.Windows.Forms.CheckedListBox();
            this.ArtistGroupBox = new System.Windows.Forms.GroupBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.InstructionalTextLabel = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.ArtistImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.ArtistGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenresListBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(507, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 236);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genres";
            // 
            // GenresListBox
            // 
            this.GenresListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenresListBox.CheckOnClick = true;
            this.GenresListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenresListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenresListBox.ForeColor = System.Drawing.Color.White;
            this.GenresListBox.FormattingEnabled = true;
            this.GenresListBox.Items.AddRange(new object[] {
            "Rock",
            "Pop",
            "Jazz",
            "Country",
            "Reggae",
            "Heavy Metal",
            "Gospel",
            "Dubstep"});
            this.GenresListBox.Location = new System.Drawing.Point(3, 26);
            this.GenresListBox.Name = "GenresListBox";
            this.GenresListBox.Size = new System.Drawing.Size(275, 207);
            this.GenresListBox.TabIndex = 5;
            // 
            // ArtistGroupBox
            // 
            this.ArtistGroupBox.Controls.Add(this.ArtistImage);
            this.ArtistGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistGroupBox.ForeColor = System.Drawing.Color.White;
            this.ArtistGroupBox.Location = new System.Drawing.Point(16, 59);
            this.ArtistGroupBox.Name = "ArtistGroupBox";
            this.ArtistGroupBox.Size = new System.Drawing.Size(250, 250);
            this.ArtistGroupBox.TabIndex = 15;
            this.ArtistGroupBox.TabStop = false;
            this.ArtistGroupBox.Text = "Artist Name";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Lime;
            this.ScoreLabel.Location = new System.Drawing.Point(604, 388);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(184, 54);
            this.ScoreLabel.TabIndex = 14;
            this.ScoreLabel.Text = "Score: 10";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.BackColor = System.Drawing.Color.Lime;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(510, 301);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(275, 84);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeLabel.Location = new System.Drawing.Point(542, 10);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(232, 30);
            this.TimeLabel.TabIndex = 12;
            this.TimeLabel.Text = "Time Remaining: 01:25";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InstructionalTextLabel
            // 
            this.InstructionalTextLabel.AutoSize = true;
            this.InstructionalTextLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionalTextLabel.ForeColor = System.Drawing.Color.White;
            this.InstructionalTextLabel.Location = new System.Drawing.Point(13, 31);
            this.InstructionalTextLabel.Name = "InstructionalTextLabel";
            this.InstructionalTextLabel.Size = new System.Drawing.Size(374, 23);
            this.InstructionalTextLabel.TabIndex = 11;
            this.InstructionalTextLabel.Text = "Instructional text on what the player must do";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerNameLabel.Location = new System.Drawing.Point(13, 8);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(108, 23);
            this.PlayerNameLabel.TabIndex = 10;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // ArtistImage
            // 
            this.ArtistImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ArtistImage.Location = new System.Drawing.Point(6, 21);
            this.ArtistImage.Name = "ArtistImage";
            this.ArtistImage.Size = new System.Drawing.Size(238, 223);
            this.ArtistImage.TabIndex = 0;
            this.ArtistImage.TabStop = false;
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ArtistGroupBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.InstructionalTextLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Name = "GenreForm";
            this.Text = "GenreForm";
            this.Load += new System.EventHandler(this.GenreForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ArtistGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArtistImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox GenresListBox;
        private System.Windows.Forms.GroupBox ArtistGroupBox;
        private System.Windows.Forms.PictureBox ArtistImage;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label InstructionalTextLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
    }
}