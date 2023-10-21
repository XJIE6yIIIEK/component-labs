namespace WinFormCustomUI {
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
			components = new System.ComponentModel.Container();
			numberBox1 = new NumberBox(components);
			filePathSelect1 = new FilePathSelect();
			colorPanel1 = new ColorPanel();
			SuspendLayout();
			// 
			// numberBox1
			// 
			numberBox1.ForeColor = Color.Red;
			numberBox1.Location = new Point(12, 12);
			numberBox1.Name = "numberBox1";
			numberBox1.Size = new Size(296, 23);
			numberBox1.TabIndex = 0;
			// 
			// filePathSelect1
			// 
			filePathSelect1.FileName = "";
			filePathSelect1.Location = new Point(12, 41);
			filePathSelect1.Name = "filePathSelect1";
			filePathSelect1.Size = new Size(296, 30);
			filePathSelect1.TabIndex = 1;
			// 
			// colorPanel1
			// 
			colorPanel1.Location = new Point(53, 77);
			colorPanel1.Name = "colorPanel1";
			colorPanel1.Size = new Size(223, 142);
			colorPanel1.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(323, 222);
			Controls.Add(colorPanel1);
			Controls.Add(filePathSelect1);
			Controls.Add(numberBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumberBox numberBox1;
		private FilePathSelect filePathSelect1;
		private ColorPanel colorPanel1;
	}
}