namespace Assignment_4._2
{
    partial class Form3
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
            studentidtextBox = new TextBox();
            studentnametextBox = new TextBox();
            gpatextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddStudentbutton = new Button();
            saveStudentbutton = new Button();
            SuspendLayout();
            // 
            // studentidtextBox
            // 
            studentidtextBox.Location = new Point(69, 212);
            studentidtextBox.Name = "studentidtextBox";
            studentidtextBox.Size = new Size(150, 31);
            studentidtextBox.TabIndex = 0;
            // 
            // studentnametextBox
            // 
            studentnametextBox.Location = new Point(271, 212);
            studentnametextBox.Name = "studentnametextBox";
            studentnametextBox.Size = new Size(150, 31);
            studentnametextBox.TabIndex = 1;
            // 
            // gpatextBox
            // 
            gpatextBox.Location = new Point(475, 212);
            gpatextBox.Name = "gpatextBox";
            gpatextBox.Size = new Size(150, 31);
            gpatextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 148);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "StudentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 148);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 4;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 148);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 5;
            label3.Text = "GPA";
            // 
            // AddStudentbutton
            // 
            AddStudentbutton.Location = new Point(209, 312);
            AddStudentbutton.Name = "AddStudentbutton";
            AddStudentbutton.Size = new Size(257, 56);
            AddStudentbutton.TabIndex = 6;
            AddStudentbutton.Text = "Add Student";
            AddStudentbutton.UseVisualStyleBackColor = true;
            AddStudentbutton.Click += AddStudentbutton_Click;
            // 
            // saveStudentbutton
            // 
            saveStudentbutton.Location = new Point(569, 337);
            saveStudentbutton.Name = "saveStudentbutton";
            saveStudentbutton.Size = new Size(161, 41);
            saveStudentbutton.TabIndex = 7;
            saveStudentbutton.Text = "Save Student";
            saveStudentbutton.UseVisualStyleBackColor = true;
            saveStudentbutton.Click += saveStudentbutton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveStudentbutton);
            Controls.Add(AddStudentbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gpatextBox);
            Controls.Add(studentnametextBox);
            Controls.Add(studentidtextBox);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentidtextBox;
        private TextBox studentnametextBox;
        private TextBox gpatextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddStudentbutton;
        private Button saveStudentbutton;
    }
}