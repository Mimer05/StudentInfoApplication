using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LastName = TBLastName.Text;
            string FirstName = TBFirstName.Text;
            long StudentID = Convert.ToInt64(TBStudentID.Text);

            // object of StudentInfo class in StudentNamespace 
            StudentInfo student = new StudentInfo(LastName, FirstName, StudentID);

            // Add the data to the list boxes
            LBLastName.Items.Add(student.LastNameStudent);
            LBFirstName.Items.Add(student.FirstNameStudent);
            LBStudentID.Items.Add(student.StudentIDNum.ToString());

            // Clear the textboxes when click submit button
            TBLastName.Clear();
            TBFirstName.Clear();
            TBStudentID.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LBFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
namespace StudentNamespace
{
    public class StudentInfo
    {  //private fields
        private string LastName;
        private string FirstName;
        private long StudentID;
        //constructor overload
        public StudentInfo()
        {
            this.LastName = "";
            this.FirstName = "";
            this.StudentID = 0;
        }
        public StudentInfo(string Lname, string Fname, long StuID)
        {
            this.LastName = Lname;
            this.FirstName= Fname;
            this.StudentID= StuID;
        }
        // gettter and setter 
        public string LastNameStudent
        {
            get { 
                return this.LastName; 
            }
            set { 
                this.LastName = value;
            }
        }

        public string FirstNameStudent
        {
            get { 
                return this.FirstName;
            }
            set { 
                this.FirstName = value;
            }
        }
        public long StudentIDNum
        {
            get
            {
                return this.StudentID;
            }
            set
            {
                this.StudentID = value;
            }
        }
      
    }
}