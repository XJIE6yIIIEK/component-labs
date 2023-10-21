namespace WinFormCustomUI {
	partial class ColorPanel {
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
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			flagDec = new RadioButton();
			flagHex = new RadioButton();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBoxR = new ColorBox(components);
			textBoxG = new ColorBox(components);
			textBoxB = new ColorBox(components);
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Black;
			panel1.ForeColor = SystemColors.Control;
			panel1.Location = new Point(106, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(109, 99);
			panel1.TabIndex = 0;
			// 
			// flagDec
			// 
			flagDec.AutoSize = true;
			flagDec.Checked = true;
			flagDec.Location = new Point(8, 114);
			flagDec.Name = "flagDec";
			flagDec.Size = new Size(47, 19);
			flagDec.TabIndex = 1;
			flagDec.TabStop = true;
			flagDec.Text = "DEC";
			flagDec.UseVisualStyleBackColor = true;
			flagDec.CheckedChanged += flagDec_CheckedChanged;
			// 
			// flagHex
			// 
			flagHex.AutoSize = true;
			flagHex.Location = new Point(60, 114);
			flagHex.Name = "flagHex";
			flagHex.Size = new Size(47, 19);
			flagHex.TabIndex = 2;
			flagHex.TabStop = true;
			flagHex.Text = "HEX";
			flagHex.UseVisualStyleBackColor = true;
			flagHex.CheckedChanged += flagHex_CheckedChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(13, 8);
			label1.Name = "label1";
			label1.Size = new Size(23, 25);
			label1.TabIndex = 3;
			label1.Text = "R";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(13, 42);
			label2.Name = "label2";
			label2.Size = new Size(25, 25);
			label2.TabIndex = 4;
			label2.Text = "G";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(15, 78);
			label3.Name = "label3";
			label3.Size = new Size(23, 25);
			label3.TabIndex = 5;
			label3.Text = "B";
			// 
			// textBoxR
			// 
			textBoxR.Location = new Point(42, 10);
			textBoxR.Name = "textBoxR";
			textBoxR.Size = new Size(58, 23);
			textBoxR.TabIndex = 6;
			textBoxR.TextChanged += textBoxR_TextChanged;
			// 
			// textBoxG
			// 
			textBoxG.Location = new Point(42, 44);
			textBoxG.Name = "textBoxG";
			textBoxG.Size = new Size(58, 23);
			textBoxG.TabIndex = 7;
			textBoxG.TextChanged += textBoxG_TextChanged;
			// 
			// textBoxB
			// 
			textBoxB.Location = new Point(42, 80);
			textBoxB.Name = "textBoxB";
			textBoxB.Size = new Size(58, 23);
			textBoxB.TabIndex = 8;
			textBoxB.TextChanged += textBoxB_TextChanged;
			// 
			// ColorPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(textBoxB);
			Controls.Add(textBoxG);
			Controls.Add(textBoxR);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(flagHex);
			Controls.Add(flagDec);
			Controls.Add(panel1);
			Name = "ColorPanel";
			Size = new Size(223, 142);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private RadioButton flagDec;
		private RadioButton flagHex;
		private Label label1;
		private Label label2;
		private Label label3;
		private ColorBox textBoxR;
		private ColorBox textBoxG;
		private ColorBox textBoxB;
	}
}
