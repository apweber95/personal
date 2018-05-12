namespace Ksu.Cis300.MapViewer
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.uxOpen = new System.Windows.Forms.ToolStripButton();
            this.uxZoomIn = new System.Windows.Forms.ToolStripButton();
            this.uxZoomOut = new System.Windows.Forms.ToolStripButton();
            this.uxPanel = new System.Windows.Forms.Panel();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxZoomIn,
            this.uxZoomOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(390, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // uxOpen
            // 
            this.uxOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOpen.Image = ((System.Drawing.Image)(resources.GetObject("uxOpen.Image")));
            this.uxOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(67, 22);
            this.uxOpen.Text = "Open Map";
            this.uxOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxZoomIn
            // 
            this.uxZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("uxZoomIn.Image")));
            this.uxZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxZoomIn.Name = "uxZoomIn";
            this.uxZoomIn.Size = new System.Drawing.Size(56, 22);
            this.uxZoomIn.Text = "Zoom In";
            this.uxZoomIn.Click += new System.EventHandler(this.uxZoomIn_Click);
            // 
            // uxZoomOut
            // 
            this.uxZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("uxZoomOut.Image")));
            this.uxZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxZoomOut.Name = "uxZoomOut";
            this.uxZoomOut.Size = new System.Drawing.Size(66, 22);
            this.uxZoomOut.Text = "Zoom Out";
            this.uxZoomOut.Click += new System.EventHandler(this.uxZoomOut_Click);
            // 
            // uxPanel
            // 
            this.uxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPanel.AutoScroll = true;
            this.uxPanel.Location = new System.Drawing.Point(12, 28);
            this.uxPanel.Name = "uxPanel";
            this.uxPanel.Size = new System.Drawing.Size(366, 281);
            this.uxPanel.TabIndex = 1;
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 321);
            this.Controls.Add(this.uxPanel);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(242, 145);
            this.Name = "UserInterface";
            this.Text = "Map Viewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton uxOpen;
        private System.Windows.Forms.ToolStripButton uxZoomIn;
        private System.Windows.Forms.ToolStripButton uxZoomOut;
        private System.Windows.Forms.Panel uxPanel;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
    }
}

