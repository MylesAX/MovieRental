﻿namespace MovieRental
{
    partial class UC2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YourMovieTab = new System.Windows.Forms.TabControl();
            this.Features = new System.Windows.Forms.TabPage();
            this.FeaturePanel = new System.Windows.Forms.Panel();
            this.Suggestion = new System.Windows.Forms.TabPage();
            this.like = new System.Windows.Forms.Panel();
            this.youmayalsolike = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.Panel();
            this.YourMovie = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YourMoviePanel = new System.Windows.Forms.Panel();
            this.YourMovieTab.SuspendLayout();
            this.Features.SuspendLayout();
            this.Suggestion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // YourMovieTab
            // 
            this.YourMovieTab.Controls.Add(this.Features);
            this.YourMovieTab.Controls.Add(this.Suggestion);
            this.YourMovieTab.Controls.Add(this.YourMovie);
            this.YourMovieTab.Location = new System.Drawing.Point(0, 63);
            this.YourMovieTab.Margin = new System.Windows.Forms.Padding(6);
            this.YourMovieTab.Name = "YourMovieTab";
            this.YourMovieTab.SelectedIndex = 0;
            this.YourMovieTab.Size = new System.Drawing.Size(1478, 950);
            this.YourMovieTab.TabIndex = 0;
            // 
            // Features
            // 
            this.Features.AutoScroll = true;
            this.Features.Controls.Add(this.FeaturePanel);
            this.Features.Location = new System.Drawing.Point(8, 39);
            this.Features.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Features.Name = "Features";
            this.Features.Padding = new System.Windows.Forms.Padding(6);
            this.Features.Size = new System.Drawing.Size(1462, 903);
            this.Features.TabIndex = 0;
            this.Features.Text = "Feature";
            this.Features.UseVisualStyleBackColor = true;
            // 
            // FeaturePanel
            // 
            this.FeaturePanel.Location = new System.Drawing.Point(12, 8);
            this.FeaturePanel.Margin = new System.Windows.Forms.Padding(6);
            this.FeaturePanel.Name = "FeaturePanel";
            this.FeaturePanel.Size = new System.Drawing.Size(1444, 863);
            this.FeaturePanel.TabIndex = 0;
            // 
            // Suggestion
            // 
            this.Suggestion.AutoScroll = true;
            this.Suggestion.Controls.Add(this.like);
            this.Suggestion.Controls.Add(this.youmayalsolike);
            this.Suggestion.Controls.Add(this.label1);
            this.Suggestion.Controls.Add(this.rank);
            this.Suggestion.Location = new System.Drawing.Point(8, 39);
            this.Suggestion.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Suggestion.Name = "Suggestion";
            this.Suggestion.Padding = new System.Windows.Forms.Padding(6);
            this.Suggestion.Size = new System.Drawing.Size(1462, 903);
            this.Suggestion.TabIndex = 1;
            this.Suggestion.Text = "Suggestion";
            this.Suggestion.UseVisualStyleBackColor = true;
            this.Suggestion.Click += new System.EventHandler(this.Suggestion_Click);
            // 
            // like
            // 
            this.like.Location = new System.Drawing.Point(22, 788);
            this.like.Margin = new System.Windows.Forms.Padding(4);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(1410, 590);
            this.like.TabIndex = 3;
            // 
            // youmayalsolike
            // 
            this.youmayalsolike.AutoSize = true;
            this.youmayalsolike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.youmayalsolike.Location = new System.Drawing.Point(18, 729);
            this.youmayalsolike.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.youmayalsolike.Name = "youmayalsolike";
            this.youmayalsolike.Size = new System.Drawing.Size(237, 31);
            this.youmayalsolike.TabIndex = 2;
            this.youmayalsolike.Text = "You May Also Like";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ranking";
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(22, 90);
            this.rank.Margin = new System.Windows.Forms.Padding(4);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(1410, 590);
            this.rank.TabIndex = 0;
            // 
            // YourMovie
            // 
            this.YourMovie.AutoScroll = true;
            this.YourMovie.Location = new System.Drawing.Point(8, 39);
            this.YourMovie.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.YourMovie.Name = "YourMovie";
            this.YourMovie.Padding = new System.Windows.Forms.Padding(6);
            this.YourMovie.Size = new System.Drawing.Size(1462, 884);
            this.YourMovie.TabIndex = 0;
            this.YourMovie.Text = "Your Movie";
            this.YourMovie.UseVisualStyleBackColor = true;
            this.YourMovie.Click += new System.EventHandler(this.YourMovie_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(678, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 83);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wishlist";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 31);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieRental.Properties.Resources.Icons8_Ios7_Very_Basic_Search;
            this.pictureBox1.Location = new System.Drawing.Point(272, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // YourMoviePanel
            // 
            this.YourMoviePanel.Location = new System.Drawing.Point(9, 10);
            this.YourMoviePanel.Name = "YourMoviePanel";
            this.YourMoviePanel.Size = new System.Drawing.Size(862, 483);
            this.YourMoviePanel.TabIndex = 2;
            // 
            // UC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YourMovieTab);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC2";
            this.Size = new System.Drawing.Size(1504, 1019);
            this.Load += new System.EventHandler(this.UC2_Load);
            this.YourMovieTab.ResumeLayout(false);
            this.Features.ResumeLayout(false);
            this.Suggestion.ResumeLayout(false);
            this.Suggestion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl YourMovieTab;
        private System.Windows.Forms.TabPage Features;
        private System.Windows.Forms.TabPage Suggestion;
        private System.Windows.Forms.TabPage YourMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel FeaturePanel;
        private System.Windows.Forms.Panel rank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel YourMoviePanel;
        private System.Windows.Forms.Panel like;
        private System.Windows.Forms.Label youmayalsolike;
    }
}
