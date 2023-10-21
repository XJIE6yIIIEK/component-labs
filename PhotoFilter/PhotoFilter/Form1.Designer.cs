namespace PhotoFilter {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			menuStrip1 = new MenuStrip();
			filtersToolStripMenuItem = new ToolStripMenuItem();
			pictureBox = new PictureBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { filtersToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(702, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// filtersToolStripMenuItem
			// 
			filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
			filtersToolStripMenuItem.Size = new Size(50, 20);
			filtersToolStripMenuItem.Text = "Filters";
			// 
			// pictureBox
			// 
			pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
			pictureBox.Location = new Point(0, 27);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(705, 462);
			pictureBox.TabIndex = 1;
			pictureBox.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(702, 487);
			Controls.Add(pictureBox);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem filtersToolStripMenuItem;
		private PictureBox pictureBox;
	}
}