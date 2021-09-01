
namespace TravkerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamMembersDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMembersLabel = new System.Windows.Forms.Label();
            this.AddTeambutton = new System.Windows.Forms.Button();
            this.AddnewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellPhoneValue = new System.Windows.Forms.TextBox();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.EmailAddressValue = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FristNameValue = new System.Windows.Forms.TextBox();
            this.FristNameLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteselectedMemberbutton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddnewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameValue.Location = new System.Drawing.Point(24, 119);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(390, 35);
            this.TeamNameValue.TabIndex = 11;
            this.TeamNameValue.TextChanged += new System.EventHandler(this.TournamentNameValue_TextChanged);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(17, 64);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLabel.TabIndex = 10;
            this.TeamNameLabel.Text = "Team Name";
            this.TeamNameLabel.Click += new System.EventHandler(this.TournamentNameLabel_Click);
            // 
            // SelectTeamMembersDropDown
            // 
            this.SelectTeamMembersDropDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMembersDropDown.FormattingEnabled = true;
            this.SelectTeamMembersDropDown.Location = new System.Drawing.Point(24, 230);
            this.SelectTeamMembersDropDown.Name = "SelectTeamMembersDropDown";
            this.SelectTeamMembersDropDown.Size = new System.Drawing.Size(390, 38);
            this.SelectTeamMembersDropDown.TabIndex = 13;
            // 
            // SelectTeamMembersLabel
            // 
            this.SelectTeamMembersLabel.AutoSize = true;
            this.SelectTeamMembersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMembersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamMembersLabel.Location = new System.Drawing.Point(17, 168);
            this.SelectTeamMembersLabel.Name = "SelectTeamMembersLabel";
            this.SelectTeamMembersLabel.Size = new System.Drawing.Size(263, 37);
            this.SelectTeamMembersLabel.TabIndex = 12;
            this.SelectTeamMembersLabel.Text = "Select Team Member";
            // 
            // AddTeambutton
            // 
            this.AddTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeambutton.Location = new System.Drawing.Point(67, 298);
            this.AddTeambutton.Name = "AddTeambutton";
            this.AddTeambutton.Size = new System.Drawing.Size(156, 44);
            this.AddTeambutton.TabIndex = 16;
            this.AddTeambutton.Text = "Add Member";
            this.AddTeambutton.UseVisualStyleBackColor = true;
            // 
            // AddnewMemberGroupBox
            // 
            this.AddnewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.AddnewMemberGroupBox.Controls.Add(this.CellPhoneValue);
            this.AddnewMemberGroupBox.Controls.Add(this.CellPhoneLabel);
            this.AddnewMemberGroupBox.Controls.Add(this.EmailAddressValue);
            this.AddnewMemberGroupBox.Controls.Add(this.EmailAddressLabel);
            this.AddnewMemberGroupBox.Controls.Add(this.LastNameValue);
            this.AddnewMemberGroupBox.Controls.Add(this.LastNameLabel);
            this.AddnewMemberGroupBox.Controls.Add(this.FristNameValue);
            this.AddnewMemberGroupBox.Controls.Add(this.FristNameLabel);
            this.AddnewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddnewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddnewMemberGroupBox.Location = new System.Drawing.Point(12, 369);
            this.AddnewMemberGroupBox.Name = "AddnewMemberGroupBox";
            this.AddnewMemberGroupBox.Size = new System.Drawing.Size(395, 335);
            this.AddnewMemberGroupBox.TabIndex = 17;
            this.AddnewMemberGroupBox.TabStop = false;
            this.AddnewMemberGroupBox.Text = "Add New Member";
            this.AddnewMemberGroupBox.Enter += new System.EventHandler(this.AddnewMemberBox_Enter);
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(50, 273);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(206, 44);
            this.CreateMemberButton.TabIndex = 18;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // CellPhoneValue
            // 
            this.CellPhoneValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellPhoneValue.Location = new System.Drawing.Point(175, 216);
            this.CellPhoneValue.Name = "CellPhoneValue";
            this.CellPhoneValue.Size = new System.Drawing.Size(215, 33);
            this.CellPhoneValue.TabIndex = 24;
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CellPhoneLabel.Location = new System.Drawing.Point(6, 216);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(130, 32);
            this.CellPhoneLabel.TabIndex = 23;
            this.CellPhoneLabel.Text = "Cell Phone";
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressValue.Location = new System.Drawing.Point(175, 160);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.Size = new System.Drawing.Size(215, 33);
            this.EmailAddressValue.TabIndex = 22;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailAddressLabel.Location = new System.Drawing.Point(6, 160);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(163, 32);
            this.EmailAddressLabel.TabIndex = 21;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValue.Location = new System.Drawing.Point(175, 103);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(215, 33);
            this.LastNameValue.TabIndex = 20;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LastNameLabel.Location = new System.Drawing.Point(6, 104);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(127, 32);
            this.LastNameLabel.TabIndex = 19;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FristNameValue
            // 
            this.FristNameValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FristNameValue.Location = new System.Drawing.Point(175, 51);
            this.FristNameValue.Name = "FristNameValue";
            this.FristNameValue.Size = new System.Drawing.Size(215, 33);
            this.FristNameValue.TabIndex = 18;
            // 
            // FristNameLabel
            // 
            this.FristNameLabel.AutoSize = true;
            this.FristNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FristNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FristNameLabel.Location = new System.Drawing.Point(6, 51);
            this.FristNameLabel.Name = "FristNameLabel";
            this.FristNameLabel.Size = new System.Drawing.Size(130, 32);
            this.FristNameLabel.TabIndex = 3;
            this.FristNameLabel.Text = "Frist Name";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(223, 50);
            this.HeaderLabel.TabIndex = 18;
            this.HeaderLabel.Text = "Create Team";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(450, 119);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(348, 512);
            this.TeamMembersListBox.TabIndex = 19;
            // 
            // DeleteselectedMemberbutton
            // 
            this.DeleteselectedMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteselectedMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteselectedMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteselectedMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteselectedMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteselectedMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteselectedMemberbutton.Location = new System.Drawing.Point(868, 338);
            this.DeleteselectedMemberbutton.Name = "DeleteselectedMemberbutton";
            this.DeleteselectedMemberbutton.Size = new System.Drawing.Size(121, 87);
            this.DeleteselectedMemberbutton.TabIndex = 20;
            this.DeleteselectedMemberbutton.Text = "Delete Selected";
            this.DeleteselectedMemberbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(350, 739);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(229, 74);
            this.CreateTeamButton.TabIndex = 25;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 825);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteselectedMemberbutton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.AddnewMemberGroupBox);
            this.Controls.Add(this.AddTeambutton);
            this.Controls.Add(this.SelectTeamMembersDropDown);
            this.Controls.Add(this.SelectTeamMembersLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddnewMemberGroupBox.ResumeLayout(false);
            this.AddnewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.ComboBox SelectTeamMembersDropDown;
        private System.Windows.Forms.Label SelectTeamMembersLabel;
        private System.Windows.Forms.Button AddTeambutton;
        private System.Windows.Forms.GroupBox AddnewMemberGroupBox;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.TextBox CellPhoneValue;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.TextBox EmailAddressValue;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FristNameValue;
        private System.Windows.Forms.Label FristNameLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button DeleteselectedMemberbutton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}