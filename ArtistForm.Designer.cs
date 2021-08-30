namespace Project_PRG
{
    partial class ArtistForm
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
            this.ArtistListBox = new System.Windows.Forms.CheckedListBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SongNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.SongNamesListBox = new System.Windows.Forms.ListBox();
            this.InstructionalTextLabel = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SongNamesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ArtistListBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(545, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 143);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artists";
            // 
            // ArtistListBox
            // 
            this.ArtistListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ArtistListBox.CheckOnClick = true;
            this.ArtistListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArtistListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistListBox.ForeColor = System.Drawing.Color.White;
            this.ArtistListBox.FormattingEnabled = true;
            this.ArtistListBox.Items.AddRange(new object[] {
            "Post Malone",
            "21 Pilots",
            "Imagine Dragon",
            "Avicii"});
            this.ArtistListBox.Location = new System.Drawing.Point(3, 27);
            this.ArtistListBox.Name = "ArtistListBox";
            this.ArtistListBox.Size = new System.Drawing.Size(237, 113);
            this.ArtistListBox.TabIndex = 7;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Lime;
            this.ScoreLabel.Location = new System.Drawing.Point(618, 392);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(162, 54);
            this.ScoreLabel.TabIndex = 16;
            this.ScoreLabel.Text = "Score: 3";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.BackColor = System.Drawing.Color.Lime;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(548, 204);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(240, 84);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeLabel.Location = new System.Drawing.Point(531, 6);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(257, 32);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time Remaining: 02:21";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SongNamesGroupBox
            // 
            this.SongNamesGroupBox.Controls.Add(this.SongNamesListBox);
            this.SongNamesGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNamesGroupBox.ForeColor = System.Drawing.Color.White;
            this.SongNamesGroupBox.Location = new System.Drawing.Point(13, 55);
            this.SongNamesGroupBox.Name = "SongNamesGroupBox";
            this.SongNamesGroupBox.Size = new System.Drawing.Size(259, 179);
            this.SongNamesGroupBox.TabIndex = 13;
            this.SongNamesGroupBox.TabStop = false;
            this.SongNamesGroupBox.Text = "Song Names";
            // 
            // SongNamesListBox
            // 
            this.SongNamesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SongNamesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongNamesListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNamesListBox.ForeColor = System.Drawing.Color.White;
            this.SongNamesListBox.FormattingEnabled = true;
            this.SongNamesListBox.ItemHeight = 23;
            this.SongNamesListBox.Items.AddRange(new object[] {
            "My Blood",
            "Chlorine",
            "Shy Away",
            "Stressed Out",
            "Jumpsuit"});
            this.SongNamesListBox.Location = new System.Drawing.Point(3, 27);
            this.SongNamesListBox.Name = "SongNamesListBox";
            this.SongNamesListBox.Size = new System.Drawing.Size(253, 149);
            this.SongNamesListBox.TabIndex = 0;
            // 
            // InstructionalTextLabel
            // 
            this.InstructionalTextLabel.AutoSize = true;
            this.InstructionalTextLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionalTextLabel.ForeColor = System.Drawing.Color.White;
            this.InstructionalTextLabel.Location = new System.Drawing.Point(13, 27);
            this.InstructionalTextLabel.Name = "InstructionalTextLabel";
            this.InstructionalTextLabel.Size = new System.Drawing.Size(395, 23);
            this.InstructionalTextLabel.TabIndex = 12;
            this.InstructionalTextLabel.Text = "Intructional text that tells the player what to do";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerNameLabel.Location = new System.Drawing.Point(13, 4);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(108, 23);
            this.PlayerNameLabel.TabIndex = 11;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SongNamesGroupBox);
            this.Controls.Add(this.InstructionalTextLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Name = "ArtistForm";
            this.Text = "ArtistForm";
            this.groupBox1.ResumeLayout(false);
            this.SongNamesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox ArtistListBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox SongNamesGroupBox;
        private System.Windows.Forms.ListBox SongNamesListBox;
        private System.Windows.Forms.Label InstructionalTextLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
    }
}