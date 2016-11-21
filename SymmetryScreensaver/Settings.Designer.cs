namespace SymmetryScreensaver
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.colourDropdown = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.thicknessBar = new System.Windows.Forms.TrackBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ScreenSaverLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.websiteLabel = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.thicknessLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colourDropdown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.thicknessBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Location = new System.Drawing.Point(43, 22);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(56, 13);
            this.thicknessLabel.TabIndex = 1;
            this.thicknessLabel.Text = "Thickness";
            // 
            // colourDropdown
            // 
            this.colourDropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colourDropdown.FormattingEnabled = true;
            this.colourDropdown.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow",
            "Purple",
            "Cyan",
            "Rainbow"});
            this.colourDropdown.Location = new System.Drawing.Point(152, 38);
            this.colourDropdown.Name = "colourDropdown";
            this.colourDropdown.Size = new System.Drawing.Size(121, 21);
            this.colourDropdown.TabIndex = 2;
            this.colourDropdown.Text = "Select colour";
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(33, 103);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // thicknessBar
            // 
            this.thicknessBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.thicknessBar.Location = new System.Drawing.Point(19, 38);
            this.thicknessBar.Minimum = 1;
            this.thicknessBar.Name = "thicknessBar";
            this.thicknessBar.Size = new System.Drawing.Size(104, 45);
            this.thicknessBar.TabIndex = 0;
            this.thicknessBar.Value = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(175, 103);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ScreenSaverLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.authorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.websiteLabel, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.15702F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.84298F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 121);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ScreenSaverLabel
            // 
            this.ScreenSaverLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScreenSaverLabel.AutoSize = true;
            this.ScreenSaverLabel.Font = new System.Drawing.Font("Quartz", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenSaverLabel.Location = new System.Drawing.Point(5, 15);
            this.ScreenSaverLabel.Name = "ScreenSaverLabel";
            this.ScreenSaverLabel.Size = new System.Drawing.Size(273, 30);
            this.ScreenSaverLabel.TabIndex = 0;
            this.ScreenSaverLabel.Text = "Symmetry Screensaver";
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(87, 74);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(110, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "By Pontus Stjernström";
            // 
            // websiteLabel
            // 
            this.websiteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(101, 104);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(81, 13);
            this.websiteLabel.TabIndex = 2;
            this.websiteLabel.TabStop = true;
            this.websiteLabel.Text = "www.pontek.se";
            this.websiteLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLabel_LinkClicked);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessBar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ScreenSaverLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.LinkLabel websiteLabel;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.ComboBox colourDropdown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TrackBar thicknessBar;
        private System.Windows.Forms.Button cancelButton;
    }
}