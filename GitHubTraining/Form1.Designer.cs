﻿namespace GitHubTraining
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
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonAlexey = new System.Windows.Forms.Button();
            this.buttonGintaras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(28, 22);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonAlexey
            // 
            this.buttonAlexey.Location = new System.Drawing.Point(28, 105);
            this.buttonAlexey.Name = "buttonAlexey";
            this.buttonAlexey.Size = new System.Drawing.Size(75, 26);
            this.buttonAlexey.TabIndex = 1;
            this.buttonAlexey.Text = "Alexey";
            this.buttonAlexey.UseVisualStyleBackColor = true;
            this.buttonAlexey.Click += new System.EventHandler(this.buttonAlexey_Click);
            // 
            // buttonGintaras
            // 
            this.buttonGintaras.Location = new System.Drawing.Point(28, 63);
            this.buttonGintaras.Name = "buttonGintaras";
            this.buttonGintaras.Size = new System.Drawing.Size(75, 23);
            this.buttonGintaras.TabIndex = 1;
            this.buttonGintaras.Text = "Gintaras";
            this.buttonGintaras.UseVisualStyleBackColor = true;
            this.buttonGintaras.Click += new System.EventHandler(this.buttonGintaras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 262);
            this.Controls.Add(this.buttonAlexey);
            this.Controls.Add(this.buttonGintaras);
            this.Controls.Add(this.buttonTest);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTest;

        private System.Windows.Forms.Button buttonAlexey;

        private System.Windows.Forms.Button buttonGintaras;

    }
}

