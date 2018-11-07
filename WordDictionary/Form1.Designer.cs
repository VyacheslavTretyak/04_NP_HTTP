namespace WordDictionary
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxURI = new System.Windows.Forms.TextBox();
			this.buttonGet = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// textBoxURI
			// 
			this.textBoxURI.Location = new System.Drawing.Point(13, 13);
			this.textBoxURI.Name = "textBoxURI";
			this.textBoxURI.Size = new System.Drawing.Size(416, 20);
			this.textBoxURI.TabIndex = 0;
			// 
			// buttonGet
			// 
			this.buttonGet.Location = new System.Drawing.Point(448, 9);
			this.buttonGet.Name = "buttonGet";
			this.buttonGet.Size = new System.Drawing.Size(75, 23);
			this.buttonGet.TabIndex = 1;
			this.buttonGet.Text = "Get";
			this.buttonGet.UseVisualStyleBackColor = true;
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(13, 40);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(416, 394);
			this.listBox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 450);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.buttonGet);
			this.Controls.Add(this.textBoxURI);
			this.Name = "Form1";
			this.Text = "WebDictionary";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxURI;
		private System.Windows.Forms.Button buttonGet;
		private System.Windows.Forms.ListBox listBox;
	}
}

