using System;
using System.Windows.Forms;

namespace Stage_2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 


        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.RectButton = new System.Windows.Forms.Button();
            this.OvalButton = new System.Windows.Forms.Button();
            this.TriButton = new System.Windows.Forms.Button();
            this.selectTool = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(885, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shapes";
            // 
            // RectButton
            // 
            this.RectButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.RectButton.FlatAppearance.BorderSize = 3;
            this.RectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.RectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RectButton.Location = new System.Drawing.Point(885, 188);
            this.RectButton.Name = "RectButton";
            this.RectButton.Size = new System.Drawing.Size(181, 35);
            this.RectButton.TabIndex = 4;
            this.RectButton.Text = "Rectangle";
            this.RectButton.UseVisualStyleBackColor = true;
            this.RectButton.Click += new System.EventHandler(this.RectButtonClicked);
            // 
            // OvalButton
            // 
            this.OvalButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.OvalButton.FlatAppearance.BorderSize = 3;
            this.OvalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.OvalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OvalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OvalButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OvalButton.Location = new System.Drawing.Point(885, 306);
            this.OvalButton.Name = "OvalButton";
            this.OvalButton.Size = new System.Drawing.Size(181, 37);
            this.OvalButton.TabIndex = 5;
            this.OvalButton.Text = "Oval";
            this.OvalButton.UseVisualStyleBackColor = true;
            this.OvalButton.Click += new System.EventHandler(this.OvalButtonClicked);
            // 
            // TriButton
            // 
            this.TriButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.TriButton.FlatAppearance.BorderSize = 3;
            this.TriButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.TriButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TriButton.Location = new System.Drawing.Point(885, 248);
            this.TriButton.Name = "TriButton";
            this.TriButton.Size = new System.Drawing.Size(181, 37);
            this.TriButton.TabIndex = 8;
            this.TriButton.Text = "Triangle";
            this.TriButton.UseVisualStyleBackColor = true;
            this.TriButton.Click += new System.EventHandler(this.TriButtonClicked);
            // 
            // selectTool
            // 
            this.selectTool.Location = new System.Drawing.Point(885, 546);
            this.selectTool.Name = "selectTool";
            this.selectTool.Size = new System.Drawing.Size(181, 36);
            this.selectTool.TabIndex = 10;
            this.selectTool.Text = "Select";
            this.selectTool.UseVisualStyleBackColor = true;
            this.selectTool.Click += new System.EventHandler(this.SelectTool_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnUndo,
            this.btnRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1088, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnUndo
            // 
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(49, 24);
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(48, 24);
            this.btnRedo.Text = "Redo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(132, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 470);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelMousePressed);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseReleased);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(159, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Лице: ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1088, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.selectTool);
            this.Controls.Add(this.TriButton);
            this.Controls.Add(this.OvalButton);
            this.Controls.Add(this.RectButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсова работа етап 2 //недовършен";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button RectButton;
        private Button OvalButton;
        private Button TriButton;
        private Button selectTool;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnUndo;
        private ToolStripButton btnRedo;
        private ToolStripSeparator toolStripSeparator2;
        private Label label2;
    }
}

