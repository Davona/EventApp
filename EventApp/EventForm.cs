using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
 
    public partial class EventForm : Form
    {
        private const string requiredMessage = "Required";
        private readonly StudentService _studentService;
        public EventForm()
        {
            _studentService = new StudentService();
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string result=string.Empty;
            if (string.IsNullOrEmpty(firstNameBox.Text)||string.IsNullOrEmpty(lastNameBox.Text))
            {
                result = "Please enter any firstname and lastname";
                MessageBox.Show(result);
            }
            else
            {
                _studentService.Add(new Student() { Name = firstNameBox.Text, LastName = lastNameBox.Text });
                List < Student > students= _studentService.GetAll();
                UpdateDataSource(students);
            }
            
        }
        private void UpdateDataSource(List<Student> students) 
        {
            studentGridView.DataSource = null;
            studentGridView.Update();
            studentGridView.DataSource = students;
            studentGridView.Update();
        }
        private void FirstName_TextChanged(object sender,EventArgs e) 
        {
            if (string.IsNullOrEmpty(firstNameBox.Text))
            {
                firstNameValidLbl.Text = requiredMessage;
                firstNameValidLbl.ForeColor = Color.Red;
            }
            else
            {
                firstNameValidLbl.Text = string.Empty;
            }
        
        }
        private void LastName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastNameBox.Text))
            {
                lastNameValidLbl.Text = requiredMessage;
                lastNameValidLbl.ForeColor = Color.Red;
            }
            else
            {
                lastNameValidLbl.Text = string.Empty;
            }

        }
        private void StudentGridView_SelectionChanged(object sender,EventArgs e) 
        {
            firstNameBox.Text = studentGridView.CurrentRow.Cells[1].Value.ToString();
            lastNameBox.Text = studentGridView.CurrentRow.Cells[2].Value.ToString();
        
        }

        private void StudentUpdate_Click(object sender, EventArgs e)
        {
            string result;
            if (string.IsNullOrEmpty(firstNameBox.Text)||string.IsNullOrEmpty(lastNameBox.Text))
            {
                result = "Please enter any firstname and lastname";
                MessageBox.Show(result);
            }
            else
            {
                studentGridView.CurrentRow.Cells[1].Value = firstNameBox.Text;
                studentGridView.CurrentRow.Cells[2].Value = lastNameBox.Text;
            }
        }
        private void DeleteStudent_Click(object sender,EventArgs e) 
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(firstNameBox.Text)||string.IsNullOrEmpty(lastNameBox.Text))
            {
                result = "Please Selecte Name and LastName For Delete";
                MessageBox.Show(result);
            }
            else
            {
                studentGridView.CurrentRow.Cells[1].Value = string.Empty;
                studentGridView.CurrentRow.Cells[2].Value = string.Empty;
            }

        }
        
    }
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

    }
    public class StudentService
    {
        List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }
        public List<Student> GetAll()
        {
            return students;

        }
       

    }
}
