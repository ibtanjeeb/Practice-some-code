
namespace TravkerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreText = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreText = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.Scorebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 25);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(226, 50);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentName.Location = new System.Drawing.Point(229, 25);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(155, 50);
            this.TournamentName.TabIndex = 0;
            this.TournamentName.Text = "<none>";
            this.TournamentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(16, 88);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(94, 37);
            this.RoundLabel.TabIndex = 1;
            this.RoundLabel.Text = "Round";
            this.RoundLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(116, 87);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(255, 38);
            this.RoundDropDown.TabIndex = 2;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(116, 131);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(209, 41);
            this.UnplayedOnlyCheckBox.TabIndex = 3;
            this.UnplayedOnlyCheckBox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(23, 178);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(348, 272);
            this.matchupListBox.TabIndex = 4;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneName.Location = new System.Drawing.Point(400, 178);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(169, 37);
            this.TeamOneName.TabIndex = 1;
            this.TeamOneName.Text = "<team One>";
            this.TeamOneName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(400, 239);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.TeamOneScoreLabel.TabIndex = 5;
            this.TeamOneScoreLabel.Text = "Score";
            this.TeamOneScoreLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // TeamOneScoreText
            // 
            this.TeamOneScoreText.Location = new System.Drawing.Point(500, 239);
            this.TeamOneScoreText.Name = "TeamOneScoreText";
            this.TeamOneScoreText.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreText.TabIndex = 6;
            this.TeamOneScoreText.TextChanged += new System.EventHandler(this.TeamOneScoreText_TextChanged);
            // 
            // TeamTwoScoreText
            // 
            this.TeamTwoScoreText.Location = new System.Drawing.Point(500, 413);
            this.TeamTwoScoreText.Name = "TeamTwoScoreText";
            this.TeamTwoScoreText.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreText.TabIndex = 9;
            this.TeamTwoScoreText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(400, 413);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.TeamTwoScoreLabel.TabIndex = 8;
            this.TeamTwoScoreLabel.Text = "Score";
            this.TeamTwoScoreLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoName.Location = new System.Drawing.Point(400, 352);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(169, 37);
            this.TeamTwoName.TabIndex = 7;
            this.TeamTwoName.Text = "<team Two>";
            this.TeamTwoName.Click += new System.EventHandler(this.label2_Click);
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.VersusLabel.Location = new System.Drawing.Point(471, 301);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(70, 37);
            this.VersusLabel.TabIndex = 10;
            this.VersusLabel.Text = "-VS-";
            this.VersusLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Scorebutton
            // 
            this.Scorebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Scorebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Scorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Scorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scorebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Scorebutton.Location = new System.Drawing.Point(641, 301);
            this.Scorebutton.Name = "Scorebutton";
            this.Scorebutton.Size = new System.Drawing.Size(121, 46);
            this.Scorebutton.TabIndex = 11;
            this.Scorebutton.Text = "Score";
            this.Scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 523);
            this.Controls.Add(this.Scorebutton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.TeamTwoScoreText);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreText);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreText;
        private System.Windows.Forms.TextBox TeamTwoScoreText;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button Scorebutton;
    }
}

