﻿namespace SymmetryScreensaver
{
    partial class SymmetryScr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymmetryScr));
            this.SuspendLayout();
            // 
            // SymmetryScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SymmetryScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Symmetry Screensaver";
            this.Load += new System.EventHandler(this.SymmetryScr_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymmetryScr_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SymmetryScr_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SymmetryScr_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
    }
}

