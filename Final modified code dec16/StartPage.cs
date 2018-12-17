using System;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            checkBox.Refresh();
            if (checkBox.GetItemChecked(0) == true)
            {
                StudentForm frm = new StudentForm();
                frm.ShowDialog();
                checkBox.SetSelected(0, false);
            }
            else if (checkBox.GetItemChecked(1) == true)
            {
                Form tchform = new TeacherForm();
                tchform.ShowDialog();
                checkBox.SetSelected(1, false);               

            } 

            else
            {
                MessageBox.Show("No Item Selected! ");
            }

            checkBox.ClearSelected();
        }
    }
}
