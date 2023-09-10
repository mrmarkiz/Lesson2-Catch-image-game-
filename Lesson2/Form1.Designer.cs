﻿namespace Lesson2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxStatic = new PictureBox();
            pictureBoxMoving = new PictureBox();
            labelPoints = new Label();
            labelCatchPercent = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoving).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.White;
            buttonStart.Location = new Point(359, 387);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(164, 33);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            buttonStart.KeyDown += buttonStart_KeyDown;
            buttonStart.KeyPress += buttonStart_KeyPress;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxStatic
            // 
            pictureBoxStatic.Image = (Image)resources.GetObject("pictureBoxStatic.Image");
            pictureBoxStatic.InitialImage = null;
            pictureBoxStatic.Location = new Point(405, 178);
            pictureBoxStatic.Name = "pictureBoxStatic";
            pictureBoxStatic.Size = new Size(95, 110);
            pictureBoxStatic.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStatic.TabIndex = 1;
            pictureBoxStatic.TabStop = false;
            // 
            // pictureBoxMoving
            // 
            pictureBoxMoving.Image = (Image)resources.GetObject("pictureBoxMoving.Image");
            pictureBoxMoving.InitialImage = null;
            pictureBoxMoving.Location = new Point(0, 178);
            pictureBoxMoving.Name = "pictureBoxMoving";
            pictureBoxMoving.Size = new Size(95, 110);
            pictureBoxMoving.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMoving.TabIndex = 1;
            pictureBoxMoving.TabStop = false;
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(12, 9);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(63, 20);
            labelPoints.TabIndex = 2;
            labelPoints.Text = "Points: 0";
            // 
            // labelCatchPercent
            // 
            labelCatchPercent.AutoSize = true;
            labelCatchPercent.Location = new Point(789, 9);
            labelCatchPercent.Name = "labelCatchPercent";
            labelCatchPercent.Size = new Size(115, 20);
            labelCatchPercent.TabIndex = 3;
            labelCatchPercent.Text = "Catch percent: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(labelCatchPercent);
            Controls.Add(labelPoints);
            Controls.Add(pictureBoxMoving);
            Controls.Add(pictureBoxStatic);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxStatic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMoving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxStatic;
        private PictureBox pictureBoxMoving;
        private Label labelPoints;
        private Label labelCatchPercent;
    }
}