using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace temp2 {
	public partial class Form1 : Form {

		string searchString;
		string regexPattern;
		MatchCollection currentCollection;

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
		
		//url text box
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

		//actual regex checker
		private void UpdateText() {
			try {
				MatchCollection collection = Regex.Matches(searchString, regexPattern);
				if (collection.Count > 0) {
					currentCollection = collection;
					TotalResults.Text = collection.Count.ToString();
					ResultIndex.Text = "1";
					ResultBox.Text = currentCollection[0].Value;
				} else {
					ResultBox.Text = "";
					ResultIndex.Text = "0";
					TotalResults.Text = "0";
				}
				TotalResults.Text = "/ " + collection.Count;
			}
			catch (Exception e) {
				ResultBox.Text = "Exception occured: " + e;
            }
		}

		//result box
		int prevPos = 0;
		private void OnResultTextChange(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				int index;
				try {
					index = Int32.Parse(ResultIndex.Text);
					if (index <= 0 || index > currentCollection.Count) { //set to the prev position if index is out of range
																		//set to prevpos
						ResultIndex.Text = prevPos.ToString();
					}
					else {
						prevPos = index;
						ResultBox.Text = currentCollection[index-1].Value; //don't want to enforce 0-indexing on the end user
						if (currentCollection[index - 1].Value == "") { //because how does "Result 0 of 1" sound with 2 results?
							//Console.WriteLine("Empty string"); Add handling for empty strings HERE
							//read "Note To Callers" https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex.matches.aspx
						}
					}
				}
				catch {
					//set to prevpos
					ResultIndex.Text = prevPos.ToString();
				}
			}
		}
	}
}
