using System;
using PluginInterface;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Transforms {
	[Version(1, 0)]
	public class BlurTransform : IPlugin {
		private const double sigma = 0.9;

		public string Name {
			get { return "Размытие"; }
		}

		public string Author {
			get { return "Владислав Долгирев"; }
		}

		private double Gauss(int x, int y) {
			return 1 / (2 * Math.PI * sigma * sigma) * Math.Exp(-(x * x + y * y) / (2 * sigma * sigma));
		}

		public Bitmap Transform(Bitmap bitmap) {
			var resBitmap = new Bitmap(bitmap.Width, bitmap.Height);
			int kernelRadius = 7;
			int coreOffset = kernelRadius / 2;
			
			var gaussMatrix = new double[kernelRadius, kernelRadius];
			double gaussSum = 0;

			for(int cx = -coreOffset; cx <= coreOffset; cx++) {
				for(int cy = -coreOffset; cy <= coreOffset; cy++) {
					double coeff = Gauss(cx, cy);
					gaussMatrix[cx + coreOffset, cy + coreOffset] = coeff;
					gaussSum += coeff;
				}
			}

			for(int cx = -coreOffset; cx <= coreOffset; cx++) {
				for(int cy = -coreOffset; cy <= coreOffset; cy++) {
					gaussMatrix[cx + coreOffset, cy + coreOffset] /= gaussSum;
				}
			}

			for(int x = 0; x < bitmap.Width; x++) {
				for(int y = 0; y < bitmap.Height; y++) {
					double r = 0;
					double g = 0;
					double b = 0;

					for(int cx = -coreOffset; cx <= coreOffset; cx++) {
						for(int cy = -coreOffset; cy <= coreOffset; cy++) {
							int ox = Math.Clamp(x + cx, 0, bitmap.Width - 1);
							int oy = Math.Clamp(y + cy, 0, bitmap.Height - 1);

							int _b = bitmap.GetPixel(ox, oy).B;
							int _g = bitmap.GetPixel(ox, oy).G;
							int _r = bitmap.GetPixel(ox, oy).R;

							b += gaussMatrix[cx + coreOffset, cy + coreOffset] * _b;
							g += gaussMatrix[cx + coreOffset, cy + coreOffset] * _g;
							r += gaussMatrix[cx + coreOffset, cy + coreOffset] * _r;
						}
					}

					int newB = Math.Clamp((int)b, 0, 255);
					int newG = Math.Clamp((int)g, 0, 255);
					int newR = Math.Clamp((int)r, 0, 255);
					Color newColor = Color.FromArgb(newR, newG, newB);
					resBitmap.SetPixel(x, y, newColor);
				}
			}

			return resBitmap;
		}
	}
}