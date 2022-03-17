﻿namespace Stepflow.Gui
{
    partial class GuiSlider
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Nuppsi = new System.Windows.Forms.PictureBox();
            this.mnu_context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_markerAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_markerCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_markerBelow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Nuppsi)).BeginInit();
            this.mnu_context.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nuppsi
            // 
            this.Nuppsi.AccessibleName = "FaderNuppsi";
            this.Nuppsi.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.Nuppsi.BackColor = System.Drawing.Color.Transparent;
            this.Nuppsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuppsi.ContextMenuStrip = this.mnu_context;
            this.Nuppsi.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.Nuppsi.ErrorImage = null;
            this.Nuppsi.InitialImage = null;
            this.Nuppsi.Location = new System.Drawing.Point(118, 0);
            this.Nuppsi.Margin = new System.Windows.Forms.Padding(0);
            this.Nuppsi.Name = "Nuppsi";
            this.Nuppsi.Size = new System.Drawing.Size(20, 32);
            this.Nuppsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nuppsi.TabIndex = 0;
            this.Nuppsi.TabStop = false;
            // 
            // mnu_context
            // 
            this.mnu_context.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnu_context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_markerAbove,
            this.mnu_markerCenter,
            this.mnu_markerBelow});
            this.mnu_context.Name = "contextMenuStrip1";
            this.mnu_context.Size = new System.Drawing.Size(137, 70);
            // 
            // mnu_markerAbove
            // 
            this.mnu_markerAbove.Name = "mnu_markerAbove";
            this.mnu_markerAbove.Size = new System.Drawing.Size(136, 22);
            this.mnu_markerAbove.Tag = "2";
            this.mnu_markerAbove.Text = "Next Above";
            this.mnu_markerAbove.Click += new System.EventHandler(this.OnToolStripMenuItemClick);
            // 
            // mnu_markerCenter
            // 
            this.mnu_markerCenter.Name = "mnu_markerCenter";
            this.mnu_markerCenter.Size = new System.Drawing.Size(136, 22);
            this.mnu_markerCenter.Tag = "1";
            this.mnu_markerCenter.Text = "Center";
            this.mnu_markerCenter.Click += new System.EventHandler(this.OnToolStripMenuItemClick);
            // 
            // mnu_markerBelow
            // 
            this.mnu_markerBelow.Name = "mnu_markerBelow";
            this.mnu_markerBelow.Size = new System.Drawing.Size(136, 22);
            this.mnu_markerBelow.Tag = "0";
            this.mnu_markerBelow.Text = "Next Below";
            this.mnu_markerBelow.Click += new System.EventHandler(this.OnToolStripMenuItemClick);
            // 
            // GuiSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.mnu_context;
            this.Controls.Add(this.Nuppsi);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(3, 3);
            this.Name = "GuiSlider";
            this.Size = new System.Drawing.Size(256, 32);
            ((System.ComponentModel.ISupportInitialize)(this.Nuppsi)).EndInit();
            this.mnu_context.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnu_markerCenter;
        private System.Windows.Forms.ToolStripMenuItem mnu_markerAbove;
        private System.Windows.Forms.ToolStripMenuItem mnu_markerBelow;
        protected System.Windows.Forms.ContextMenuStrip mnu_context;
        protected System.Windows.Forms.PictureBox Nuppsi;
    }
}
