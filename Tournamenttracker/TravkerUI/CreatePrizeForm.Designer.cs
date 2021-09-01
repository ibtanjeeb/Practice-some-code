
using System;

namespace TravkerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PlaceNamevalue = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizeAmountValue = new System.Windows.Forms.TextBox();
            this.PrizeAmountlabel = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(9, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(217, 50);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Create Prize";
            // 
            // PlaceNumberValue
            // 
            this.PlaceNumberValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceNumberValue.Location = new System.Drawing.Point(201, 96);
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.Size = new System.Drawing.Size(215, 33);
            this.PlaceNumberValue.TabIndex = 20;
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PlaceNumberLabel.Location = new System.Drawing.Point(15, 96);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(165, 32);
            this.PlaceNumberLabel.TabIndex = 19;
            this.PlaceNumberLabel.Text = "Place Number";
            // 
            // PlaceNamevalue
            // 
            this.PlaceNamevalue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceNamevalue.Location = new System.Drawing.Point(201, 157);
            this.PlaceNamevalue.Name = "PlaceNamevalue";
            this.PlaceNamevalue.Size = new System.Drawing.Size(215, 33);
            this.PlaceNamevalue.TabIndex = 22;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PlaceNameLabel.Location = new System.Drawing.Point(15, 157);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(141, 32);
            this.PlaceNameLabel.TabIndex = 21;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PrizeAmountValue
            // 
            this.PrizeAmountValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeAmountValue.Location = new System.Drawing.Point(201, 218);
            this.PrizeAmountValue.Name = "PrizeAmountValue";
            this.PrizeAmountValue.Size = new System.Drawing.Size(215, 33);
            this.PrizeAmountValue.TabIndex = 24;
            this.PrizeAmountValue.Text = "0";
            this.PrizeAmountValue.TextChanged += new System.EventHandler(this.PrizeAmountValue_TextChanged);
            // 
            // PrizeAmountlabel
            // 
            this.PrizeAmountlabel.AutoSize = true;
            this.PrizeAmountlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeAmountlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizeAmountlabel.Location = new System.Drawing.Point(15, 218);
            this.PrizeAmountlabel.Name = "PrizeAmountlabel";
            this.PrizeAmountlabel.Size = new System.Drawing.Size(159, 32);
            this.PrizeAmountlabel.TabIndex = 23;
            this.PrizeAmountlabel.Text = "Prize Amount";
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizePercentageValue.Location = new System.Drawing.Point(201, 346);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(215, 33);
            this.PrizePercentageValue.TabIndex = 26;
            this.PrizePercentageValue.Text = "0";
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizePercentageLabel.Location = new System.Drawing.Point(12, 346);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(191, 32);
            this.PrizePercentageLabel.TabIndex = 25;
            this.PrizePercentageLabel.Text = "Prize Percentage";
            this.PrizePercentageLabel.Click += new System.EventHandler(this.PrizePercentageLabel_Click);
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.OrLabel.Location = new System.Drawing.Point(178, 279);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(57, 32);
            this.OrLabel.TabIndex = 27;
            this.OrLabel.Text = "-or-";
            this.OrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(137, 423);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(229, 71);
            this.CreatePrizeButton.TabIndex = 28;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 516);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PrizeAmountValue);
            this.Controls.Add(this.PrizeAmountlabel);
            this.Controls.Add(this.PlaceNamevalue);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void PrizePercentageLabel_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox PlaceNumberValue;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.TextBox PlaceNamevalue;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.TextBox PrizeAmountValue;
        private System.Windows.Forms.Label PrizeAmountlabel;
        private System.Windows.Forms.TextBox PrizePercentageValue;
        private System.Windows.Forms.Label PrizePercentageLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}