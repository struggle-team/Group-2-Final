using DesktopApp1.Database1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (checkBox.GetItemChecked(0))
            {
                MessageBox.Show("Generating groups based on the number of students!");
                checkBox.SetSelected(0, false);
            }        

            else if(checkBox.GetItemChecked(1))
            {
                MessageBox.Show("Generating groups based on the number of groups!");
                checkBox.SetSelected(1, false);
                int numberOfGroups = Int32.Parse(numLbl.Text);
                numLbl.Text = "";
                var adapter = new StudentTableAdapter();
                var rows = adapter.GetData();
               
                List<Students> students = new List<Students>();
                
                foreach (var row in rows)
                {
                    int n = 0;
                    List<Students> student = new List<Students>();
                    student.Add(new Students() { firstname = row.First_Name, lastname = row.Last_Name});
                    //student[n].firstname = row.First_Name;
                    //student[n].lastname = row.Last_Name;
                    students.Add(student[n]);
                    n++; 
                }

                List<List<Students>> groups = new List<List<Students>>();

                for (int g = 0; g < numberOfGroups; g++)
                {
                    groups.Add(new List<Students>());
                }

                Random random;
                while (students.Count > 0)
                {

                    for (int n = 0; n < numberOfGroups; n++)
                    {
                        random = new Random();                        
                        int rand = random.Next(0, students.Count);
                        //Console.WriteLine(students[n].firstname);
                        groups.ElementAt(n).Add(students[rand]);
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

        private void studentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vw = new StudentData();
            vw.ShowDialog();
        }
    }
}
