using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class VerifyStudentForm : Form
    {
        public VerifyStudentForm()
        {
            InitializeComponent();
        }

        private void VerifyStudentForm_Load(object sender, EventArgs e)
        {

        }
        public void setValues(int RollNo,string Name,int Age,string Branch,string College,string Genger,string status)
        {
            RollNo = Convert.ToInt32(VRN.Text);
            Name = VN.Text;
            Age = Convert.ToInt32(VA.Text);
            Branch = VB.Text;
            College = Vcollege.Text;
            Genger = VG.Text;
            status = VS.Text;
        }
    }
}
