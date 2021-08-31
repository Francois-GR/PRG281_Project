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
            this.components = new System.ComponentModel.Container();
            this.grpGenres = new System.Windows.Forms.GroupBox();
            this.GenresListBox = new System.Windows.Forms.CheckedListBox();
            this.ArtistGroupBox = new System.Windows.Forms.GroupBox();
            this.lblArtsistName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblPlayerNameLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpGenres.SuspendLayout();
            this.ArtistGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGenres
            // 
            this.grpGenres.Controls.Add(this.GenresListBox);
            this.grpGenres.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGenres.ForeColor = System.Drawing.Color.White;
            this.grpGenres.Location = new System.Drawing.Point(380, 48);
            this.grpGenres.Margin = new System.Windows.Forms.Padding(2);
            this.grpGenres.Name = "grpGenres";
            this.grpGenres.Padding = new System.Windows.Forms.Padding(2);
            this.grpGenres.Size = new System.Drawing.Size(211, 192);
            this.grpGenres.TabIndex = 16;
            this.grpGenres.TabStop = false;
            this.grpGenres.Text = "Genres";
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
            this.GenresListBox.Location = new System.Drawing.Point(2, 21);
            this.GenresListBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenresListBox.Name = "GenresListBox";
            this.GenresListBox.Size = new System.Drawing.Size(207, 169);
            this.GenresListBox.TabIndex = 5;
            // 
            // ArtistGroupBox
            // 
            this.ArtistGroupBox.Controls.Add(this.lblArtsistName);
            this.ArtistGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistGroupBox.ForeColor = System.Drawing.Color.White;
            this.ArtistGroupBox.Location = new System.Drawing.Point(150, 105);
            this.ArtistGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ArtistGroupBox.Name = "ArtistGroupBox";
            this.ArtistGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ArtistGroupBox.Size = new System.Drawing.Size(168, 59);
            this.ArtistGroupBox.TabIndex = 15;
            this.ArtistGroupBox.TabStop = false;
            this.ArtistGroupBox.Text = "Artist Name";
            // 
            // lblArtsistName
            // 
            this.lblArtsistName.AutoSize = true;
            this.lblArtsistName.Location = new System.Drawing.Point(15, 21);
            this.lblArtsistName.Name = "lblArtsistName";
            this.lblArtsistName.Size = new System.Drawing.Size(27, 19);
            this.lblArtsistName.TabIndex = 0;
            this.lblArtsistName.Text = "\" \"";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Lime;
            this.lblScore.Location = new System.Drawing.Point(453, 315);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(132, 45);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(382, 245);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(206, 68);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AccessibleName = "timerForGenreFrom";
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeLabel.Location = new System.Drawing.Point(406, 8);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(167, 25);
            this.TimeLabel.TabIndex = 12;
            this.TimeLabel.Text = "Time Remaining: 60";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(10, 25);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(308, 19);
            this.lblInstruction.TabIndex = 11;
            this.lblInstruction.Text = "Instructional text on what the player must do";
            // 
            // lblPlayerNameLabel
            // 
            this.lblPlayerNameLabel.AutoSize = true;
            this.lblPlayerNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameLabel.ForeColor = System.Drawing.Color.White;
            this.lblPlayerNameLabel.Location = new System.Drawing.Point(10, 6);
            this.lblPlayerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerNameLabel.Name = "lblPlayerNameLabel";
            this.lblPlayerNameLabel.Size = new System.Drawing.Size(88, 19);
            this.lblPlayerNameLabel.TabIndex = 10;
            this.lblPlayerNameLabel.Text = "Player Name";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(172, 210);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 43);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpGenres);
            this.Controls.Add(this.ArtistGroupBox);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblPlayerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenreForm";
            this.Text = "Match the artist to their genres";
            this.Load += new System.EventHandler(this.GenreForm_Load);
            this.grpGenres.ResumeLayout(false);
            this.ArtistGroupBox.ResumeLayout(false);
            this.ArtistGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenres;
        private System.Windows.Forms.CheckedListBox GenresListBox;
        private System.Windows.Forms.GroupBox ArtistGroupBox;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblPlayerNameLabel;
        private System.Windows.Forms.Label lblArtsistName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}