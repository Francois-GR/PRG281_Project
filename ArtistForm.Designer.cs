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
            this.components = new System.ComponentModel.Container();
            this.grpArtist = new System.Windows.Forms.GroupBox();
            this.ArtistListBox = new System.Windows.Forms.CheckedListBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpSongName = new System.Windows.Forms.GroupBox();
            this.SongListRichTextbox = new System.Windows.Forms.RichTextBox();
            this.InstructionalTextLabel = new System.Windows.Forms.Label();
            this.lblPlayerNameLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpArtist.SuspendLayout();
            this.grpSongName.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArtist
            // 
            this.grpArtist.Controls.Add(this.ArtistListBox);
            this.grpArtist.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpArtist.ForeColor = System.Drawing.Color.White;
            this.grpArtist.Location = new System.Drawing.Point(409, 45);
            this.grpArtist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpArtist.Name = "grpArtist";
            this.grpArtist.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpArtist.Size = new System.Drawing.Size(182, 168);
            this.grpArtist.TabIndex = 17;
            this.grpArtist.TabStop = false;
            this.grpArtist.Text = "Artists";
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
            this.ArtistListBox.Location = new System.Drawing.Point(2, 22);
            this.ArtistListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArtistListBox.Name = "ArtistListBox";
            this.ArtistListBox.Size = new System.Drawing.Size(178, 144);
            this.ArtistListBox.TabIndex = 7;
            this.ArtistListBox.SelectedIndexChanged += new System.EventHandler(this.ArtistListBox_SelectedIndexChanged);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Lime;
            this.ScoreLabel.Location = new System.Drawing.Point(464, 318);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(132, 45);
            this.ScoreLabel.TabIndex = 16;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(411, 227);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 68);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(398, 5);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(176, 25);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time Remaining: 60";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpSongName
            // 
            this.grpSongName.Controls.Add(this.SongListRichTextbox);
            this.grpSongName.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSongName.ForeColor = System.Drawing.Color.White;
            this.grpSongName.Location = new System.Drawing.Point(14, 66);
            this.grpSongName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSongName.Name = "grpSongName";
            this.grpSongName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSongName.Size = new System.Drawing.Size(197, 115);
            this.grpSongName.TabIndex = 13;
            this.grpSongName.TabStop = false;
            this.grpSongName.Text = "Song Names";
            // 
            // SongListRichTextbox
            // 
            this.SongListRichTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SongListRichTextbox.Enabled = false;
            this.SongListRichTextbox.Location = new System.Drawing.Point(5, 24);
            this.SongListRichTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SongListRichTextbox.Name = "SongListRichTextbox";
            this.SongListRichTextbox.ReadOnly = true;
            this.SongListRichTextbox.Size = new System.Drawing.Size(188, 88);
            this.SongListRichTextbox.TabIndex = 0;
            this.SongListRichTextbox.Text = "";
            // 
            // InstructionalTextLabel
            // 
            this.InstructionalTextLabel.AutoSize = true;
            this.InstructionalTextLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionalTextLabel.ForeColor = System.Drawing.Color.White;
            this.InstructionalTextLabel.Location = new System.Drawing.Point(10, 22);
            this.InstructionalTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionalTextLabel.Name = "InstructionalTextLabel";
            this.InstructionalTextLabel.Size = new System.Drawing.Size(269, 19);
            this.InstructionalTextLabel.TabIndex = 12;
            this.InstructionalTextLabel.Text = "Select all the correct songs of the artist";
            // 
            // lblPlayerNameLabel
            // 
            this.lblPlayerNameLabel.AutoSize = true;
            this.lblPlayerNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameLabel.ForeColor = System.Drawing.Color.White;
            this.lblPlayerNameLabel.Location = new System.Drawing.Point(10, 3);
            this.lblPlayerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerNameLabel.Name = "lblPlayerNameLabel";
            this.lblPlayerNameLabel.Size = new System.Drawing.Size(88, 19);
            this.lblPlayerNameLabel.TabIndex = 11;
            this.lblPlayerNameLabel.Text = "Player Name";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(14, 298);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 57);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(14, 227);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 68);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpArtist);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.grpSongName);
            this.Controls.Add(this.InstructionalTextLabel);
            this.Controls.Add(this.lblPlayerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArtistForm";
            this.Text = "Match Artists to their music";
            this.Load += new System.EventHandler(this.ArtistForm_Load);
            this.grpArtist.ResumeLayout(false);
            this.grpSongName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArtist;
        private System.Windows.Forms.CheckedListBox ArtistListBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpSongName;
        private System.Windows.Forms.Label InstructionalTextLabel;
        private System.Windows.Forms.Label lblPlayerNameLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox SongListRichTextbox;
    }
}