using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_9_form
{
	public partial class Form1 : Form
    {
        

        //list that will contain all names
        List<string> studentList = new List<string>();
        // list of students so i can add later automatically 
        List<Student> studentObjList = new List<Student>();
        

        public Form1()
		{
			InitializeComponent();
            // random initial students
            studentObjList.Add(new Student("barack", "obama"));
            studentObjList.Add(new Student("donald", "trump"));
            studentObjList.Add(new Student("justin", "trudeau"));
            // add each student NAME to the list box 
            for(int i = 0; i<studentObjList.Count;i++)
            {
                studentList.Add(studentObjList[i].FirstName.ToString() + " " + studentObjList[i].LastName.ToString());
            }

            studentListbox.DataSource = studentList;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtEntryBox.Text = txtEntryBox.Text.Trim();
            bool spaceFound = false;
            string fName, lName;

            // check if user entry is two words seperated by a space
            for(int x = 0; x < txtEntryBox.Text.Length; x++)
            {
                if(txtEntryBox.Text[x].ToString() == " " && spaceFound == false)
                {
                    // so it doesnt check for more spaces
                    spaceFound = true;

                    // x will be the index of where the space is, the fname will be before, and the lname after. 
                    fName = txtEntryBox.Text.Substring(0, x).Trim();
                    lName = txtEntryBox.Text.Substring(x, txtEntryBox.Text.Length - x).Trim();


                    // add new student NAME to the list box 
                    studentObjList.Add(new Student(fName, lName));

                    // add to listbox datasource
                    studentList.Add(fName + " " + lName);

                    // update listbox datasource
                    studentListbox.DataSource = null;
                    studentListbox.DataSource = studentList;
                    
                }
            }
            if (spaceFound == false)
            {
                MessageBox.Show("Please enter a first and last name.", "Error");
            }
            txtEntryBox.Text = "";

        }









        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
            e.DrawBackground();
            var myFont = new Font("Verdana", 8, FontStyle.Bold);
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < studentListbox.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color (condition) ? [true path] : [false path];
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(82, 82, 82) : Color.FromArgb(64, 64, 64));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = studentListbox.Items[itemIndex].ToString();


                // (condition) ? [true path] : [false path]; -> changes colour depending on what is selected
                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.FromArgb(79, 146, 255)) : new SolidBrush(Color.FromArgb(240, 240, 240));
                g.DrawString(itemText, myFont, itemTextColorBrush, studentListbox.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            studentListbox.DataSource = studentList;

        }

        private void txtEntryBox_Enter(object sender, EventArgs e)
        {
            if (txtEntryBox.Text == "Enter a student.")
            {
            txtEntryBox.Text = "";
            }

        }

        private void txtEntryBox_Leave(object sender, EventArgs e)
        {
            if (txtEntryBox.Text.Length == 0)
            {
                txtEntryBox.Text = "Enter a student.";
            }

        }

        private void studentListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("selection changed");
            Console.WriteLine(studentObjList.Count);
            // get what index the user is at
            int index = studentListbox.SelectedIndex;
            Console.WriteLine("selected index " + index); //+ ". Which means " + studentObjList[index].FirstName.ToString() + " is selected.");
            // make sure something is selected
            if(index >= 0)
            {
                
                lblDisplayfName.Text = studentObjList[index].FirstName.ToString();
                lblDisplaylName.Text = studentObjList[index].LastName.ToString();
                lblDisplayEmail.Text = studentObjList[index].Email.ToString();
                lblDisplayStudentNum.Text = studentObjList[index].StudentNumber.ToString();
                
            }
        }

    }
}
