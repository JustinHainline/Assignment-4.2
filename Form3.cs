using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class Form3 : Form
    {
        Student newStudent = new Student();
        public Form3()
        {
            InitializeComponent();
        }

        private void AddStudentbutton_Click(object sender, EventArgs e)
        {
            if (studentidtextBox.Text != " ")
            {
                newStudent.StudentId = studentidtextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter Student ID.");
            }
            if (studentnametextBox.Text != " ")
            {
                newStudent.StudentName = studentnametextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter Student Name.");
            }
            if (gpatextBox.Text != " ")
            {
                newStudent.GPA = Convert.ToDouble(gpatextBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter GPA.");
            }

            Program.studentList.Add(newStudent);

        }

        private void saveStudentbutton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Test\\Test.txt");
            sw.WriteLine(Program.studentList[0].GPA);
            sw.Close();

        }
    }
}
