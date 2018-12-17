using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();

            DataSet dataSet = new DataSet();
            //dataSet.fill()
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database1DataSet.Student);
            // TODO: This line of code loads data into the 'database1DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database1DataSet.Student);
            this.studentTableAdapter.GetData();           
        }

        
        private void submitButton_Click(object sender, EventArgs e)
        {                    
            int wrk_ethic = Convert.ToInt32(workEthic.Value);
            int reliability_ = Convert.ToInt32(reliabNum.Value);
            studentTableAdapter.InsertQuery(Guid.NewGuid(), firstName.Text, lastName.Text, majorBox.Text, wrk_ethic, studentPref.Text, collabBox.Text, roleBox.Text, reliability_);
            studentTableAdapter.Update(this.database1DataSet.Student);
            

            MessageBox.Show("Thanks!");
            
            studentID.Text = "";
            firstName.Text = "";
            lastName.Text = "";
            majorBox.Text = "";
            workEthic.Value = 0;
            studentPref.Text = "";
            collabBox.Text = "";
            roleBox.Text = "";
            reliabNum.Value = 0;

           // availpick date value

        }

        private void viewDbItem_Click(object sender, EventArgs e)
        {
            var vw = new StudentData();
            vw.ShowDialog();
        }
    }
}
