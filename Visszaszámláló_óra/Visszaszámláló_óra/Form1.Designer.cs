﻿
namespace Visszaszámláló_óra
{
    partial class Form1
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
            this.countdownLabel = new System.Windows.Forms.Label();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Random_szoveg_1 = new System.Windows.Forms.Label();
            this.Random_szoveg_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countdownLabel
            // 
            this.countdownLabel.Font = new System.Drawing.Font("Anquietas", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.White;
            this.countdownLabel.Location = new System.Drawing.Point(-17, 53);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(1126, 234);
            this.countdownLabel.TabIndex = 0;
            this.countdownLabel.Text = "00:00:00.00";
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourTextBox
            // 
            this.hourTextBox.BackColor = System.Drawing.Color.Black;
            this.hourTextBox.Font = new System.Drawing.Font("Anquietas", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourTextBox.ForeColor = System.Drawing.Color.White;
            this.hourTextBox.Location = new System.Drawing.Point(5, 50);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(206, 256);
            this.hourTextBox.TabIndex = 1;
            this.hourTextBox.Text = "00";
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.BackColor = System.Drawing.Color.Black;
            this.minuteTextBox.Font = new System.Drawing.Font("Anquietas", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteTextBox.ForeColor = System.Drawing.Color.White;
            this.minuteTextBox.Location = new System.Drawing.Point(280, 50);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(206, 256);
            this.minuteTextBox.TabIndex = 2;
            this.minuteTextBox.Text = "00";
            // 
            // secondTextBox
            // 
            this.secondTextBox.BackColor = System.Drawing.Color.Black;
            this.secondTextBox.Font = new System.Drawing.Font("Anquietas", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.ForeColor = System.Drawing.Color.White;
            this.secondTextBox.Location = new System.Drawing.Point(563, 53);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(206, 256);
            this.secondTextBox.TabIndex = 3;
            this.secondTextBox.Text = "00";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(457, 361);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(206, 88);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "🞂";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restartButton.Location = new System.Drawing.Point(457, 361);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(206, 88);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "↺";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(938, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minden ablakba írj számot!";
            // 
            // Random_szoveg_1
            // 
            this.Random_szoveg_1.AutoSize = true;
            this.Random_szoveg_1.Font = new System.Drawing.Font("Anquietas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Random_szoveg_1.ForeColor = System.Drawing.Color.White;
            this.Random_szoveg_1.Location = new System.Drawing.Point(-1, 12);
            this.Random_szoveg_1.Name = "Random_szoveg_1";
            this.Random_szoveg_1.Size = new System.Drawing.Size(1084, 35);
            this.Random_szoveg_1.TabIndex = 7;
            this.Random_szoveg_1.Text = "ajhdailjfkhjdhhfjhgajhdjhdfiutewzbgjvsjdkfhauwghzmhgvdhrhdrzjeaogwifdjhdvbsaa";
            this.Random_szoveg_1.Visible = false;
            // 
            // Random_szoveg_2
            // 
            this.Random_szoveg_2.AutoSize = true;
            this.Random_szoveg_2.Font = new System.Drawing.Font("Anquietas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Random_szoveg_2.ForeColor = System.Drawing.Color.White;
            this.Random_szoveg_2.Location = new System.Drawing.Point(-1, 252);
            this.Random_szoveg_2.Name = "Random_szoveg_2";
            this.Random_szoveg_2.Size = new System.Drawing.Size(1084, 35);
            this.Random_szoveg_2.TabIndex = 8;
            this.Random_szoveg_2.Text = "ajhdailjfkhjdhhfjhgajhdjhdfiutewzbgjvsjdkfhauwghzmhgvdhrhdrzjeaogwifdjhdvbsaa";
            this.Random_szoveg_2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.Random_szoveg_2);
            this.Controls.Add(this.Random_szoveg_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.minuteTextBox);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.countdownLabel);
            this.MaximumSize = new System.Drawing.Size(1100, 500);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "Form1";
            this.Text = "Alterai visszaszámláló óra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Random_szoveg_1;
        private System.Windows.Forms.Label Random_szoveg_2;
    }
}

