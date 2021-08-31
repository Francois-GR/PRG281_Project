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
            this.InstructionalTextLabel = new System.Windows.Forms.Label();
            this.lblPlayerNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ArtistListBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(409, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 116);
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
            this.ArtistListBox.Location = new System.Drawing.Point(2, 22);
            this.ArtistListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ArtistListBox.Name = "ArtistListBox";
            this.ArtistListBox.Size = new System.Drawing.Size(178, 92);
            this.ArtistListBox.TabIndex = 7;
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
            this.ScoreLabel.Text = "Score: 3";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.BackColor = System.Drawing.Color.Lime;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(411, 166);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(180, 68);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeLabel.Location = new System.Drawing.Point(398, 5);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 25);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time Remaining: 02:21";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SongNamesGroupBox
            // 
            this.SongNamesGroupBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNamesGroupBox.ForeColor = System.Drawing.Color.White;
            this.SongNamesGroupBox.Location = new System.Drawing.Point(129, 81);
            this.SongNamesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SongNamesGroupBox.Name = "SongNamesGroupBox";
            this.SongNamesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SongNamesGroupBox.Size = new System.Drawing.Size(194, 54);
            this.SongNamesGroupBox.TabIndex = 13;
            this.SongNamesGroupBox.TabStop = false;
            this.SongNamesGroupBox.Text = "Song Names";
            // 
            // InstructionalTextLabel
            // 
            this.InstructionalTextLabel.AutoSize = true;
            this.InstructionalTextLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionalTextLabel.ForeColor = System.Drawing.Color.White;
            this.InstructionalTextLabel.Location = new System.Drawing.Point(10, 22);
            this.InstructionalTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InstructionalTextLabel.Name = "InstructionalTextLabel";
            this.InstructionalTextLabel.Size = new System.Drawing.Size(324, 19);
            this.InstructionalTextLabel.TabIndex = 12;
            this.InstructionalTextLabel.Text = "Intructional text that tells the player what to do";
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
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SongNamesGroupBox);
            this.Controls.Add(this.InstructionalTextLabel);
            this.Controls.Add(this.lblPlayerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ArtistForm";
            this.Text = "ArtistForm";
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label InstructionalTextLabel;
        private System.Windows.Forms.Label lblPlayerNameLabel;
    }
}