namespace slutprojekt
{
    partial class MyPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Black_Btn = new System.Windows.Forms.ToolStripButton();
            this.Red_Btn = new System.Windows.Forms.ToolStripButton();
            this.Gold_Btn = new System.Windows.Forms.ToolStripButton();
            this.PenSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.PrnSize_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.Board_PB = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_MenuItem,
            this.OpenMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // Save_MenuItem
            // 
            this.Save_MenuItem.Name = "Save_MenuItem";
            this.Save_MenuItem.Size = new System.Drawing.Size(270, 34);
            this.Save_MenuItem.Text = "Save";
            this.Save_MenuItem.Click += new System.EventHandler(this.Save_MenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(270, 34);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Black_Btn,
            this.Red_Btn,
            this.Gold_Btn,
            this.PenSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Black_Btn
            // 
            this.Black_Btn.AutoSize = false;
            this.Black_Btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Black_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Black_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Black_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black_Btn.Name = "Black_Btn";
            this.Black_Btn.Size = new System.Drawing.Size(50, 28);
            this.Black_Btn.Text = "Black";
            this.Black_Btn.Click += new System.EventHandler(this.Black_Btn_Click);
            // 
            // Red_Btn
            // 
            this.Red_Btn.AutoSize = false;
            this.Red_Btn.BackColor = System.Drawing.Color.Red;
            this.Red_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Red_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Red_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red_Btn.Name = "Red_Btn";
            this.Red_Btn.Size = new System.Drawing.Size(50, 28);
            this.Red_Btn.Text = "Red";
            this.Red_Btn.Click += new System.EventHandler(this.Red_Btn_Click);
            // 
            // Gold_Btn
            // 
            this.Gold_Btn.AutoSize = false;
            this.Gold_Btn.BackColor = System.Drawing.Color.Gold;
            this.Gold_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Gold_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Gold_Btn.Name = "Gold_Btn";
            this.Gold_Btn.Size = new System.Drawing.Size(50, 28);
            this.Gold_Btn.Text = "Gold";
            this.Gold_Btn.Click += new System.EventHandler(this.Gold_Btn_Click);
            // 
            // PenSize
            // 
            this.PenSize.AutoSize = false;
            this.PenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PenSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrnSize_5,
            this.PenSize_10,
            this.PenSize_15});
            this.PenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(90, 28);
            this.PenSize.Text = "PenSize";
            // 
            // PrnSize_5
            // 
            this.PrnSize_5.Name = "PrnSize_5";
            this.PrnSize_5.Size = new System.Drawing.Size(270, 34);
            this.PrnSize_5.Text = "5";
            this.PrnSize_5.Click += new System.EventHandler(this.PrnSize_5_Click);
            // 
            // PenSize_10
            // 
            this.PenSize_10.Name = "PenSize_10";
            this.PenSize_10.Size = new System.Drawing.Size(270, 34);
            this.PenSize_10.Text = "10";
            this.PenSize_10.Click += new System.EventHandler(this.PenSize_10_Click);
            // 
            // PenSize_15
            // 
            this.PenSize_15.Name = "PenSize_15";
            this.PenSize_15.Size = new System.Drawing.Size(270, 34);
            this.PenSize_15.Text = "15";
            this.PenSize_15.Click += new System.EventHandler(this.PenSize_15_Click);
            // 
            // Board_PB
            // 
            this.Board_PB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Board_PB.Location = new System.Drawing.Point(0, 77);
            this.Board_PB.Name = "Board_PB";
            this.Board_PB.Size = new System.Drawing.Size(800, 373);
            this.Board_PB.TabIndex = 2;
            this.Board_PB.TabStop = false;
            this.Board_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseDown);
            this.Board_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseMove);
            this.Board_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseDown);
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Board_PB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyPaint";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyPaint_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Save_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Black_Btn;
        private System.Windows.Forms.ToolStripButton Red_Btn;
        private System.Windows.Forms.ToolStripButton Gold_Btn;
        private System.Windows.Forms.ToolStripDropDownButton PenSize;
        private System.Windows.Forms.ToolStripMenuItem PrnSize_5;
        private System.Windows.Forms.ToolStripMenuItem PenSize_10;
        private System.Windows.Forms.ToolStripMenuItem PenSize_15;
        private System.Windows.Forms.PictureBox Board_PB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

