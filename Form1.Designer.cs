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
			this.lblDisplayStudentNum = new System.Windows.Forms.Label();
			this.lblDisplayEmail = new System.Windows.Forms.Label();
			this.lblDisplaylName = new System.Windows.Forms.Label();
			this.lblDisplayfName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbllName = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.studentListbox = new System.Windows.Forms.ListBox();
			this.txtEntryBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblDisplayStudentNum);
			this.groupBox1.Controls.Add(this.lblDisplayEmail);
			this.groupBox1.Controls.Add(this.lblDisplaylName);
			this.groupBox1.Controls.Add(this.lblDisplayfName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lbllName);
			this.groupBox1.Controls.Add(this.lblName);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Location = new System.Drawing.Point(138, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(157, 192);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Students";
			// 
			// lblDisplayStudentNum
			// 
			this.lblDisplayStudentNum.AutoSize = true;
			this.lblDisplayStudentNum.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplayStudentNum.Location = new System.Drawing.Point(6, 116);
			this.lblDisplayStudentNum.Name = "lblDisplayStudentNum";
			this.lblDisplayStudentNum.Size = new System.Drawing.Size(0, 13);
			this.lblDisplayStudentNum.TabIndex = 7;
			// 
			// lblDisplayEmail
			// 
			this.lblDisplayEmail.AutoSize = true;
			this.lblDisplayEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplayEmail.Location = new System.Drawing.Point(6, 156);
			this.lblDisplayEmail.Name = "lblDisplayEmail";
			this.lblDisplayEmail.Size = new System.Drawing.Size(0, 13);
			this.lblDisplayEmail.TabIndex = 6;
			// 
			// lblDisplaylName
			// 
			this.lblDisplaylName.AutoSize = true;
			this.lblDisplaylName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplaylName.Location = new System.Drawing.Point(6, 76);
			this.lblDisplaylName.Name = "lblDisplaylName";
			this.lblDisplaylName.Size = new System.Drawing.Size(0, 13);
			this.lblDisplaylName.TabIndex = 5;
			// 
			// lblDisplayfName
			// 
			this.lblDisplayfName.AutoSize = true;
			this.lblDisplayfName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplayfName.Location = new System.Drawing.Point(6, 36);
			this.lblDisplayfName.Name = "lblDisplayfName";
			this.lblDisplayfName.Size = new System.Drawing.Size(0, 13);
			this.lblDisplayfName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Email:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Student #:";
			// 
			// lbllName
			// 
			this.lbllName.AutoSize = true;
			this.lbllName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbllName.Location = new System.Drawing.Point(6, 57);
			this.lbllName.Name = "lbllName";
			this.lbllName.Size = new System.Drawing.Size(72, 13);
			this.lbllName.TabIndex = 1;
			this.lbllName.Text = "Last Name:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(6, 17);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(45, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
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
			this.studentListbox.SelectedIndexChanged += new System.EventHandler(this.studentListbox_SelectedIndexChanged);
			// 
			// txtEntryBox
			// 
			this.txtEntryBox.BackColor = System.Drawing.Color.DimGray;
			this.txtEntryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEntryBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntryBox.ForeColor = System.Drawing.Color.Black;
			this.txtEntryBox.Location = new System.Drawing.Point(12, 199);
			this.txtEntryBox.Name = "txtEntryBox";
			this.txtEntryBox.Size = new System.Drawing.Size(120, 21);
			this.txtEntryBox.TabIndex = 2;
			this.txtEntryBox.Text = "Enter a student.";
			this.txtEntryBox.Enter += new System.EventHandler(this.txtEntryBox_Enter);
			this.txtEntryBox.Leave += new System.EventHandler(this.txtEntryBox_Leave);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(138, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 21);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(307, 229);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtEntryBox);
			this.Controls.Add(this.studentListbox);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Part 9";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox studentListbox;
		private System.Windows.Forms.TextBox txtEntryBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblDisplayStudentNum;
		private System.Windows.Forms.Label lblDisplayEmail;
		private System.Windows.Forms.Label lblDisplaylName;
		private System.Windows.Forms.Label lblDisplayfName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbllName;
		private System.Windows.Forms.Label lblName;
	}
}

