
namespace TravkerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeTextValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeambutton = new System.Windows.Forms.Button();
            this.CreatePrizebutton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayerLabel = new System.Windows.Forms.Label();
            this.DeleteselectedPlayerbutton = new System.Windows.Forms.Button();
            this.DeleteselectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizeslistBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(334, 50);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameValue.Location = new System.Drawing.Point(33, 140);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(373, 35);
            this.TournamentNameValue.TabIndex = 9;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(26, 81);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.TournamentNameLabel.TabIndex = 8;
            this.TournamentNameLabel.Text = "Tournament Name";
            this.TournamentNameLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // EntryFeeTextValue
            // 
            this.EntryFeeTextValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeTextValue.Location = new System.Drawing.Point(147, 201);
            this.EntryFeeTextValue.Name = "EntryFeeTextValue";
            this.EntryFeeTextValue.Size = new System.Drawing.Size(127, 35);
            this.EntryFeeTextValue.TabIndex = 11;
            this.EntryFeeTextValue.Text = "0";
            this.EntryFeeTextValue.TextChanged += new System.EventHandler(this.TeamOneScoreText_TextChanged);
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(26, 201);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.EntryFeeLabel.TabIndex = 10;
            this.EntryFeeLabel.Text = "Entry Fee";
            this.EntryFeeLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click_1);
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(33, 311);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(373, 38);
            this.SelectTeamDropDown.TabIndex = 13;
            this.SelectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.RoundDropDown_SelectedIndexChanged);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(26, 262);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamLabel.TabIndex = 12;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewTeamLink.Location = new System.Drawing.Point(285, 268);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(121, 30);
            this.CreateNewTeamLink.TabIndex = 14;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            // 
            // AddTeambutton
            // 
            this.AddTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeambutton.Location = new System.Drawing.Point(147, 394);
            this.AddTeambutton.Name = "AddTeambutton";
            this.AddTeambutton.Size = new System.Drawing.Size(127, 44);
            this.AddTeambutton.TabIndex = 15;
            this.AddTeambutton.Text = "Add Team";
            this.AddTeambutton.UseVisualStyleBackColor = true;
            this.AddTeambutton.Click += new System.EventHandler(this.Scorebutton_Click);
            // 
            // CreatePrizebutton
            // 
            this.CreatePrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizebutton.Location = new System.Drawing.Point(118, 470);
            this.CreatePrizebutton.Name = "CreatePrizebutton";
            this.CreatePrizebutton.Size = new System.Drawing.Size(182, 49);
            this.CreatePrizebutton.TabIndex = 16;
            this.CreatePrizebutton.Text = "Create Prize";
            this.CreatePrizebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 30;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(467, 140);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(348, 182);
            this.TournamentPlayersListBox.TabIndex = 17;
            // 
            // TournamentPlayerLabel
            // 
            this.TournamentPlayerLabel.AutoSize = true;
            this.TournamentPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentPlayerLabel.Location = new System.Drawing.Point(460, 81);
            this.TournamentPlayerLabel.Name = "TournamentPlayerLabel";
            this.TournamentPlayerLabel.Size = new System.Drawing.Size(173, 37);
            this.TournamentPlayerLabel.TabIndex = 18;
            this.TournamentPlayerLabel.Text = "Team/Players";
            // 
            // DeleteselectedPlayerbutton
            // 
            this.DeleteselectedPlayerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteselectedPlayerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteselectedPlayerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteselectedPlayerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteselectedPlayerbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteselectedPlayerbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteselectedPlayerbutton.Location = new System.Drawing.Point(842, 191);
            this.DeleteselectedPlayerbutton.Name = "DeleteselectedPlayerbutton";
            this.DeleteselectedPlayerbutton.Size = new System.Drawing.Size(121, 87);
            this.DeleteselectedPlayerbutton.TabIndex = 19;
            this.DeleteselectedPlayerbutton.Text = "Delete Selected";
            this.DeleteselectedPlayerbutton.UseVisualStyleBackColor = true;
            // 
            // DeleteselectedPrizeButton
            // 
            this.DeleteselectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteselectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteselectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteselectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteselectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteselectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteselectedPrizeButton.Location = new System.Drawing.Point(842, 470);
            this.DeleteselectedPrizeButton.Name = "DeleteselectedPrizeButton";
            this.DeleteselectedPrizeButton.Size = new System.Drawing.Size(121, 84);
            this.DeleteselectedPrizeButton.TabIndex = 22;
            this.DeleteselectedPrizeButton.Text = "Delete Selected";
            this.DeleteselectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizesLabel.Location = new System.Drawing.Point(460, 368);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(173, 37);
            this.PrizesLabel.TabIndex = 21;
            this.PrizesLabel.Text = "Team/Players";
            // 
            // PrizeslistBox
            // 
            this.PrizeslistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeslistBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeslistBox.FormattingEnabled = true;
            this.PrizeslistBox.ItemHeight = 30;
            this.PrizeslistBox.Location = new System.Drawing.Point(467, 427);
            this.PrizeslistBox.Name = "PrizeslistBox";
            this.PrizeslistBox.Size = new System.Drawing.Size(348, 182);
            this.PrizeslistBox.TabIndex = 20;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(362, 639);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(271, 71);
            this.CreateTournamentButton.TabIndex = 23;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 732);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteselectedPrizeButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizeslistBox);
            this.Controls.Add(this.DeleteselectedPlayerbutton);
            this.Controls.Add(this.TournamentPlayerLabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizebutton);
            this.Controls.Add(this.AddTeambutton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeTextValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeTextValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button AddTeambutton;
        private System.Windows.Forms.Button CreatePrizebutton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayerLabel;
        private System.Windows.Forms.Button DeleteselectedPlayerbutton;
        private System.Windows.Forms.Button DeleteselectedPrizeButton;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.ListBox PrizeslistBox;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}