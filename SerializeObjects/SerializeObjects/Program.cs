using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialize {

	[Serializable]
	public class Point : IComparable {
		public double x;
		public double y;
		public int type;

		public Point() {
			x = 0;
			y = 0;
			type = 0;
		}

		public Point(double x = 0, double y = 0) {
			this.x = x;
			this.y = y;
			this.type = 0;
		}

		public virtual double Metric() {
			return Math.Sqrt(this.x * this.x + this.y * this.y);
		}

		public override string ToString() {
			return ($"({x}, {y})");
		}

		public double CompareTo(object obj) {
			Point p = (Point)obj;
			return this.Metric() - p.Metric();
		}

		int IComparable.CompareTo(object obj) {
			return (int)(this.Metric() - ((Point)obj).Metric());
		}
	}

	[Serializable]
	public class Point3D : Point {
		public double z;

		public Point3D() : base() {
			z = 0;
			type = 1;
		}

		public Point3D(int x = 0, int y = 0, int z = 0) : base(x, y) {
			this.z = z;
			this.type = 1;
		}

		public override double Metric() {
			return Math.Sqrt(x * x + y * y + z * z);
		}

		public override string ToString() {
			return string.Format($"({x}, {y}, {z})");
		}
	}


	class Program {
		static void Main(string[] args) {
			int n = 10;

			Point[] points = new Point[n];
			for(int i = 0; i < n / 2; i++) {
				Point point = new Point(i, i);
				points[i] = point;
			}

			for(int i = n / 2; i < n; i++) {
				Point3D point = new Point3D(i, i, i);
				points[i] = point;
			}

			Console.Write($"Enter file extension: bin - Binary, xml - XML, json - JSON: ");
			string ext = Console.ReadLine();
			string path = "";

			switch(ext) {
				case "bin": path = "bin.txt"; break;
				case "xml": path = "XML.txt"; break;
				case "json": path = "JSON.txt"; break;
			}

			using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)) {
				switch(ext) {
					case "bin": {
						#pragma warning disable SYSLIB0011
						var bf = new BinaryFormatter();

						bf.Serialize(fs, points);
						#pragma warning restore SYSLIB0011
					}; break;

					case "xml": {
						var xf = new XmlSerializer(typeof(Point[]), new[] { typeof(Point3D) });

						xf.Serialize(fs, points);
					}; break;

					case "json": {
						string jsonStr = JsonConvert.SerializeObject(points);
						StreamWriter file = new StreamWriter(fs);

						file.WriteLine(jsonStr);
						file.Close();
					}; break;
				}
			}

			Point[] readPoints = new Point[n];

			using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				switch(ext) {
					case "bin": {
						#pragma warning disable SYSLIB0011
						var bf = new BinaryFormatter();

						readPoints = (Point[])bf.Deserialize(fs);
						#pragma warning restore SYSLIB0011
					}; break;

					case "xml": {
						var xf = new XmlSerializer(typeof(Point[]), new[] { typeof(Point3D) });

						readPoints = (Point[])xf.Deserialize(fs);
					} break;

					case "json": {
						StreamReader file = new StreamReader(fs);
						string json = file.ReadToEnd();
						Point3D[] pointJson = JsonConvert.DeserializeObject<Point3D[]>(json);

						for(int i = 0; i < n; i++) {
							if(pointJson[i].type == 1)
								readPoints[i] = (Point3D)(pointJson[i]);
							else
								readPoints[i] = new Point(pointJson[i].x, pointJson[i].y);
						}
					}; break;
				}
			}

			for(int i = 0; i < n; i++) {
				Console.WriteLine(readPoints[i].ToString());
			}
		}
	}
}
