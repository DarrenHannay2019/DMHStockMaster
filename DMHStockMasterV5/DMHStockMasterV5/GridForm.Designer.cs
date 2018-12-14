namespace DMHStockMasterV5
{
	partial class GridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RecordToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FindToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StockLevelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FunctionCheckToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CloseToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 421);
            this.splitContainer2.SplitterDistance = 89;
            this.splitContainer2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.RecordToolStripButton2,
            this.DeleteToolStripButton,
            this.RefreshToolStripButton,
            this.PrintToolStripButton,
            this.FindToolStripButton,
            this.StockLevelToolStripButton,
            this.FunctionCheckToolStripButton,
            this.CloseToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // RecordToolStripButton2
            // 
            this.RecordToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RecordToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("RecordToolStripButton2.Image")));
            this.RecordToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RecordToolStripButton2.Name = "RecordToolStripButton2";
            this.RecordToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.RecordToolStripButton2.Text = "Record";
            this.RecordToolStripButton2.Click += new System.EventHandler(this.RecordToolStripButton2_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteToolStripButton.Text = "Delete";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // RefreshToolStripButton
            // 
            this.RefreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshToolStripButton.Image")));
            this.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolStripButton.Name = "RefreshToolStripButton";
            this.RefreshToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshToolStripButton.Text = "Refresh";
            this.RefreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // PrintToolStripButton
            // 
            this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripButton.Image")));
            this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripButton.Name = "PrintToolStripButton";
            this.PrintToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrintToolStripButton.Text = "Print";
            this.PrintToolStripButton.Click += new System.EventHandler(this.PrintToolStripButton_Click);
            // 
            // FindToolStripButton
            // 
            this.FindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FindToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FindToolStripButton.Image")));
            this.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindToolStripButton.Name = "FindToolStripButton";
            this.FindToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FindToolStripButton.Text = "Find";
            this.FindToolStripButton.Click += new System.EventHandler(this.FindToolStripButton_Click);
            // 
            // StockLevelToolStripButton
            // 
            this.StockLevelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StockLevelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("StockLevelToolStripButton.Image")));
            this.StockLevelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StockLevelToolStripButton.Name = "StockLevelToolStripButton";
            this.StockLevelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StockLevelToolStripButton.Text = "Stock Level Check";
            this.StockLevelToolStripButton.Click += new System.EventHandler(this.StockLevelToolStripButton_Click);
            // 
            // FunctionCheckToolStripButton
            // 
            this.FunctionCheckToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FunctionCheckToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FunctionCheckToolStripButton.Image")));
            this.FunctionCheckToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FunctionCheckToolStripButton.Name = "FunctionCheckToolStripButton";
            this.FunctionCheckToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FunctionCheckToolStripButton.Text = "FunctionCheck";
            this.FunctionCheckToolStripButton.Click += new System.EventHandler(this.FunctionCheckToolStripButton_Click);
            // 
            // CloseToolStripButton
            // 
            this.CloseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseToolStripButton.Image")));
            this.CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseToolStripButton.Name = "CloseToolStripButton";
            this.CloseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CloseToolStripButton.Text = "Close";
            this.CloseToolStripButton.Click += new System.EventHandler(this.CloseToolStripButton_Click);
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GridForm";
            this.Text = "GridForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton RecordToolStripButton2;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton RefreshToolStripButton;
        private System.Windows.Forms.ToolStripButton PrintToolStripButton;
        private System.Windows.Forms.ToolStripButton FindToolStripButton;
        private System.Windows.Forms.ToolStripButton StockLevelToolStripButton;
        private System.Windows.Forms.ToolStripButton FunctionCheckToolStripButton;
        private System.Windows.Forms.ToolStripButton CloseToolStripButton;
    }
}