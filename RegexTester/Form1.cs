using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace temp2 {
	public partial class Form1 : Form {

		string searchString;
		string regexPattern;

		public Form1() {
			InitializeComponent();
			if (searchString != string.Empty) {
				textBox1.Text = searchString;
			}
			if (regexPattern != string.Empty) {
				textBox2.Text = regexPattern;
			}
		}

		//string text box
		private void OnStringChange(object sender, EventArgs e) {
			searchString = textBox1.Text;
		}

		//regex text box
		private void OnRegexChange(object sender, EventArgs e) {
			regexPattern = textBox2.Text;
		}

		private void OnUrlKeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				if (textBox3.Text != "") {
					string html;
					using (System.Net.WebClient client = new System.Net.WebClient()) {
						try {
							html = client.DownloadString(textBox3.Text);
							textBox1.Text = "length: " + html.Length;
							searchString = html;
							Console.WriteLine("Search length: " + searchString.Length);
						}
						catch {
							textBox1.Text = "Error";
						}
					}
				} else {
					textBox1.Text = "";
				}
			}
		}
	
		//txtbox2
		private void txtboxKeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				UpdateText();
			}
		}
		//txtbox1
		private void OnTextbox1KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				UpdateText();
			}
		}

		private void UpdateText() {
			try {
				Match match = Regex.Match(searchString, regexPattern);
				if (match.Success) {
					ResultBox.Text = match.Value;
				} else {
					ResultBox.Text = "No match";
				}
				//Console.WriteLine(searchString);
				//Console.WriteLine(regexPattern);
			} catch (Exception e) {
				ResultBox.Text = "Exception occured: "+e;
            }
		}
	}
}
