using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Serialization;

namespace WPFClock {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			DispatcherTimer timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += timer_Tick;
			timer.Start();
			ChangeOuter();
			ChangePin();
			ResizeArrows();
		}

		void ChangeOuter() {
			if(Height > Width) {
				outer.Width = Width - 40;
				outer.Height = Width - 40;
			} else {
				outer.Width = Height - 40;
				outer.Height = Height - 40;
			}
		}

		void ChangePin() {
			int margin = 0;

			if(Height > Width) {
				margin = (int)(Width - 40) / 2 - 6;
			} else {
				margin = (int)(Height - 40) / 2 - 6;
			}

			Canvas.SetTop(pin, margin);
			Canvas.SetLeft(pin, margin);
		}

		void ResizeArrows() {
			int paneSize = 0;
			if(Height > Width) {
				paneSize = (int)(Width - 40) / 2;
			} else {
				paneSize = (int)(Height - 40) / 2;
			}

			hourHand.Width = paneSize + 2;
			hourHand.Height = paneSize;
			hourHand.X1 = paneSize;
			hourHand.Y1 = paneSize;
			hourHand.X2 = paneSize;
			hourHand.Y2 = (double)paneSize * 0.5;

			minuteHand.Width = paneSize + 1;
			minuteHand.Height = paneSize;
			minuteHand.X1 = paneSize;
			minuteHand.Y1 = paneSize;
			minuteHand.X2 = paneSize;
			minuteHand.Y2 = (double)paneSize * 0.25;

			secondHand.Width = (double)paneSize + 0.5;
			secondHand.Height = paneSize;
			secondHand.X1 = paneSize;
			secondHand.Y1 = paneSize;
			secondHand.X2 = paneSize;
			secondHand.Y2 = (double)paneSize * 0.15;

			ChangeArrowsPosition();
		}

		void ChangeArrowsPosition() {
			DateTime currentTime = DateTime.Now;
			int hour = currentTime.Hour % 12;
			int minute = currentTime.Minute;
			int second = currentTime.Second;

			double hourAngle = (hour + minute / 60.0) * 30;
			double minuteAngle = minute * 6;
			double secondAngle = second * 6;

			int margin = 0;
			if(Height > Width) {
				margin = (int)(Width - 40) / 2;
			} else {
				margin = (int)(Height - 40) / 2;
			}

			hourHand.RenderTransform = new RotateTransform(hourAngle, margin, margin);
			minuteHand.RenderTransform = new RotateTransform(minuteAngle, margin, margin);
			secondHand.RenderTransform = new RotateTransform(secondAngle, margin, margin);
		}

		void timer_Tick(object sender, EventArgs e) {
			ChangeArrowsPosition();
		}

		void window_SizeChanged(object sender, EventArgs e) {
			ChangeOuter();
			ChangePin();
			ResizeArrows();
		}
	}
}
