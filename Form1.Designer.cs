namespace part_9_form
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.studentListbox = new System.Windows.Forms.ListBox();
			this.userEntryBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(138, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(132, 192);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Students";
			// 
			// studentListbox
			// 
			this.studentListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.studentListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.studentListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.studentListbox.FormattingEnabled = true;
			this.studentListbox.Location = new System.Drawing.Point(12, 12);
			this.studentListbox.Name = "studentListbox";
			this.studentListbox.Size = new System.Drawing.Size(120, 184);
			this.studentListbox.TabIndex = 0;
			this.studentListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
			// 
			// userEntryBox
			// 
			this.userEntryBox.Location = new System.Drawing.Point(12, 199);
			this.userEntryBox.Name = "userEntryBox";
			this.userEntryBox.Size = new System.Drawing.Size(120, 20);
			this.userEntryBox.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(138, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.userEntryBox);
			this.Controls.Add(this.studentListbox);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Part 9";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox studentListbox;
		private System.Windows.Forms.TextBox userEntryBox;
		private System.Windows.Forms.Button button1;
	}
}

