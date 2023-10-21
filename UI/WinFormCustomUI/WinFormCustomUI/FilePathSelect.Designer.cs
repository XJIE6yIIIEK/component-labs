namespace WinFormCustomUI {
	partial class FilePathSelect {
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			txtPath = new TextBox();
			btnSelectPath = new Button();
			SuspendLayout();
			// 
			// txtPath
			// 
			txtPath.Location = new Point(3, 3);
			txtPath.Name = "txtPath";
			txtPath.Size = new Size(239, 23);
			txtPath.TabIndex = 0;
			// 
			// btnSelectPath
			// 
			btnSelectPath.Location = new Point(248, 3);
			btnSelectPath.Name = "btnSelectPath";
			btnSelectPath.Size = new Size(45, 23);
			btnSelectPath.TabIndex = 1;
			btnSelectPath.Text = "...";
			btnSelectPath.UseVisualStyleBackColor = true;
			btnSelectPath.Click += btnSelectPath_Click;
			// 
			// FilePathSelect
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnSelectPath);
			Controls.Add(txtPath);
			Name = "FilePathSelect";
			Size = new Size(296, 30);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtPath;
		private Button btnSelectPath;
	}
}
