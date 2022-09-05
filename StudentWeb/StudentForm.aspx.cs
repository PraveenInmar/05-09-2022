using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBaseConnection;
using Host;
using System.Data;


namespace StudentWeb
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadStudent()
        {
            Code c = new Code();
            GridViewStudent.DataSource = c.display();
            GridViewStudent.DataBind();
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
          
            Hub hubobj = new Hub();
            hubobj.RollNo1 = Convert.ToInt32(SRNINPUT.Text);
            hubobj.Name1 = SNINPUT.Text;
            hubobj.Age1 = Convert.ToInt32(SAINPUT.Text);
            hubobj.Branch1 = SBINPUT.Text;
            hubobj.College1 = SCINPUT.Text;

            string gender = "";
            string status = "";

            if (Male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            hubobj.Gender1 = gender;

            if (MarriedButton.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "Unmarried";
            }
            hubobj.Status1 = status;

            hubobj.adding();
            LoadStudent();       
        }
        private void clearData()
        {
            SRNINPUT.Text = "";
            SNINPUT.Text = "";
            SAINPUT.Text = "";
            SBINPUT.Text = "";
            SCINPUT.Text = "";
            Male.Checked = false;
            Female.Checked = false;
            MarriedButton.Checked = false;
            UnMarriedButton.Checked = false;

        }
        //Select method and display
        protected void GridViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearData();
            int name = Convert.ToInt32( GridViewStudent.Rows[GridViewStudent.SelectedIndex].Cells[1].Text);
            DisplayScreen(name);
        }
        public void DisplayScreen(int student)
        {
            Hub hubobj = new Hub();
            DataSet datasetobj = hubobj.searchDetails(student);

            //int RollNo    = Convert.ToInt32( datasetobj.Tables[0].Rows[0][0].ToString());
            string Name = datasetobj.Tables[0].Rows[0][1].ToString();
            int Age = Convert.ToInt32(datasetobj.Tables[0].Rows[0][2].ToString());
            string Branch = datasetobj.Tables[0].Rows[0][3].ToString();
            string College = datasetobj.Tables[0].Rows[0][4].ToString();
            string Gender = datasetobj.Tables[0].Rows[0][5].ToString();
            string Status = datasetobj.Tables[0].Rows[0][6].ToString();

            SRNINPUT.Text = student.ToString();
            SNINPUT.Text = Name;
            SAINPUT.Text = Age.ToString();
            SBINPUT.Text = Branch;
            SCINPUT.Text = College;

            if (Gender == "Male")
            {
                Male.Checked = true;
            }
            else
            {
                Female.Checked = true;
            }

            if (Status == "Married")
            {
                MarriedButton.Checked = true;
            }
            else
            {
                UnMarriedButton.Checked = true;
            }
            //StatusgroupBox.Text = Status;
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Hub ho = new Hub();

            int RollNo = Convert.ToInt32(SRNINPUT.Text);
            string Name = SNINPUT.Text;
            int age = Convert.ToInt32(SAINPUT.Text);
            string branch = SBINPUT.Text;
            string Collage = SCINPUT.Text;
            string gender = "";
            string status = "";
            if (Male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            // hubobj.Gender1 = GenderGroupbox.Text;

            if (MarriedButton.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "Unmarried";
            }
            // hubobj.Status1 = StatusgroupBox.Text;
            ho.Name1 = Name;
            ho.Age1 = age;
            ho.Branch1 = branch;
            ho.College1 = Collage;
            ho.Gender1 = gender;
            ho.Status1 = status;
            ho.RollNo1 = RollNo;
            ho.updating();
            LoadStudent();
            clearData();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            Hub h = new Hub();
            h.Name1 = SNINPUT.Text;
            h.deleting();
            clearData();
            LoadStudent();

        }
    }
}