using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Host;

namespace Student
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           
            UserClass uc = new UserClass();
            uc.UserName = UNINPUT.Text;
            uc.Password = PWINPUT.Text;
            if(uc.isValid())
            {
                ApplicationStudent ass = new ApplicationStudent();
                ass.Show();

            }
            else
            {
                MessageBox.Show("Invalid Credentials...");
            }
            
        }
    }
}
