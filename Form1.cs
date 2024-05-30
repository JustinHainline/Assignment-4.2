namespace Assignment_4._2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Form2 studentForm = new Form2();
            studentForm.ShowDialog();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Form3 addStudentform = new Form3();
            addStudentform.ShowDialog();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
