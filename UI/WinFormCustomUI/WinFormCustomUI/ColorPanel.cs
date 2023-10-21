using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCustomUI {
	public partial class ColorPanel : UserControl {
		public ColorPanel() {
			InitializeComponent();
		}

		public int R, G, B;

		private void changePanelColor() {
			if(!(textBoxR.notation == textBoxB.notation && textBoxB.notation == textBoxG.notation))
				return;

			R = 0;
			G = 0;
			B = 0;
			Color color;

			if(flagDec.Checked && textBoxR.notation == ColorBox.Notation.DEC) {
				R = Int32.Parse(textBoxR.Text);
				G = Int32.Parse(textBoxG.Text);
				B = Int32.Parse(textBoxB.Text);
			}

			if(flagHex.Checked && textBoxR.notation == ColorBox.Notation.HEX) {
				R = Convert.ToInt32("0x" + textBoxR.Text, 16);
				G = Convert.ToInt32("0x" + textBoxG.Text, 16);
				B = Convert.ToInt32("0x" + textBoxB.Text, 16);
			}

			color = Color.FromArgb(R, G, B);

			panel1.BackColor = color;

		}
		private void flagHex_CheckedChanged(object sender, EventArgs e) {
			if(textBoxR.notation != ColorBox.Notation.HEX) {
				textBoxR.notation = ColorBox.Notation.HEX;
				textBoxR.Text = Int32.Parse(textBoxR.Text).ToString("X");

				textBoxG.notation = ColorBox.Notation.HEX;
				textBoxG.Text = Int32.Parse(textBoxG.Text).ToString("X");

				textBoxB.notation = ColorBox.Notation.HEX;
				textBoxB.Text = Int32.Parse(textBoxB.Text).ToString("X");
			}
		}

		private void flagDec_CheckedChanged(object sender, EventArgs e) {
			if(textBoxR.notation != ColorBox.Notation.DEC) {
				textBoxR.notation = ColorBox.Notation.DEC;
				textBoxR.Text = int.Parse(textBoxR.Text, System.Globalization.NumberStyles.HexNumber).ToString();

				textBoxG.notation = ColorBox.Notation.DEC;
				textBoxG.Text = int.Parse(textBoxG.Text, System.Globalization.NumberStyles.HexNumber).ToString();

				textBoxB.notation = ColorBox.Notation.DEC;
				textBoxB.Text = int.Parse(textBoxB.Text, System.Globalization.NumberStyles.HexNumber).ToString();
			}
		}

		private void textBoxR_TextChanged(object sender, EventArgs e) {
			if(textBoxR.Text != "") {
				changePanelColor();
			}
		}

		private void textBoxG_TextChanged(object sender, EventArgs e) {
			if(textBoxB.Text != "") {
				changePanelColor();
			}
		}

		private void textBoxB_TextChanged(object sender, EventArgs e) {
			if(textBoxG.Text != "") {
				changePanelColor();
			}
		}
	}
}
