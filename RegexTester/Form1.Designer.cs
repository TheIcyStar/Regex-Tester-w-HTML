namespace temp2 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.ResultBox = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ResultIndex = new System.Windows.Forms.TextBox();
			this.TotalResults = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(145, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(219, 23);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.OnStringChange);
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnTextbox1KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "String";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "RegEx";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(145, 76);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(219, 23);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextChanged += new System.EventHandler(this.OnRegexChange);
			this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxKeyUp);
			// 
			// ResultBox
			// 
			this.ResultBox.Location = new System.Drawing.Point(17, 118);
			this.ResultBox.Multiline = true;
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.Size = new System.Drawing.Size(347, 123);
			this.ResultBox.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(145, 42);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(219, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnUrlKeyUp);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "or input a url";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(128, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Result";
			// 
			// ResultIndex
			// 
			this.ResultIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultIndex.Location = new System.Drawing.Point(171, 247);
			this.ResultIndex.Name = "ResultIndex";
			this.ResultIndex.Size = new System.Drawing.Size(52, 26);
			this.ResultIndex.TabIndex = 8;
			this.ResultIndex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnResultTextChange);
			// 
			// TotalResults
			// 
			this.TotalResults.AutoSize = true;
			this.TotalResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalResults.Location = new System.Drawing.Point(229, 250);
			this.TotalResults.Name = "TotalResults";
			this.TotalResults.Size = new System.Drawing.Size(26, 20);
			this.TotalResults.TabIndex = 9;
			this.TotalResults.Text = "/ 0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 276);
			this.Controls.Add(this.TotalResults);
			this.Controls.Add(this.ResultIndex);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.ResultBox);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "RegEx Tester";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox ResultBox;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ResultIndex;
		private System.Windows.Forms.Label TotalResults;
	}
}

