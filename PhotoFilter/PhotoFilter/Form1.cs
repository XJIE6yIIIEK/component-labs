using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;

namespace PhotoFilter {
	public partial class Form1 : Form {
		Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();
		string configureFile = "config.cfg";

		public Form1() {
			InitializeComponent();
			FindPlugins();
			CreatePluginMenu();
		}

		void CreatePluginMenu() {
			foreach(string key in plugins.Keys) {
				var menuKey = filtersToolStripMenuItem.DropDownItems.Add(key);
				menuKey.Click += filtersToolStripMenuItem_Click;
			}
		}

		void FindPlugins() {
			using(StreamReader sr = new StreamReader(configureFile)) {
				string path;

				try {
					while((path = sr.ReadLine()) != null) {
						Assembly assembly = Assembly.LoadFile(path);

						foreach(Type type in assembly.GetTypes()) {
							Type _interface = type.GetInterface("PluginInterface.IPlugin");

							if(_interface != null) {
								IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
								plugins.Add(plugin.Name, plugin);
							}
						}
					}
				} catch(Exception e) {
					MessageBox.Show("Не удалось загрузить плагин.\n" + e.Message);
				}
			}
		}

		private void filtersToolStripMenuItem_Click(object sender, EventArgs e) {
			IPlugin plugin = plugins["Размытие"];
			var newImg = plugin.Transform((Bitmap)pictureBox.Image);
			pictureBox.Image = newImg;
		}
	}
}

