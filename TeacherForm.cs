using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp1.Database1DataSetTableAdapters;

namespace DesktopApp1
{
    public partial class TeacherForm : Form
    {
        int numberOfGroups;

        public TeacherForm()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numberOfGroups = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            var adapter = new StudentTableAdapter();
            var rows = adapter.GetData();
            
            List<Students> students = new List<Students>();
           
            foreach (var row in rows)
            {
                Students student = new Students();
                student.firstname = row.First_Name;
                student.lastname = row.Last_Name;
                students.Add(student);
            }

            List<List<Students>> groups = new List<List<Students>>();
            
            for (int g = 0; g < numberOfGroups; g++)
            {
                groups.Add(new List<Students>());
            }

            Random random;
            while(students.Count > 0)
            {

                for (int n = 0; n < numberOfGroups; n++)
                {
                    random = new Random();
                    int rand = random.Next(0, students.Count);
                    //Console.WriteLine(students[n].firstname);
                    groups[n].Add(students[rand]);
                    students.RemoveAt(rand);

                }
            }

            int i = 1;
            foreach (var group in groups)
            {
                listBox1.Items.Add("Group #" + i);
                foreach (var person in group)
                {
                    listBox1.Items.Add(person.firstname + " " + person.lastname);
                }
                listBox1.Items.Add("\n");
                i++;
            }
        }
    }



}
