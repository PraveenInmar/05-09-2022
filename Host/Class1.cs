using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseConnection;
using System.Data;

namespace Host
{
    public class Hub
    {
        private int RollNo = 0;
        private string Name = "";
        private int Age = 0;
        private string Branch = "";
        private string College = "";
        private string Gender = "";
        private string Status = "";

        public int RollNo1 { get => RollNo; set => RollNo = value; }
        public string Name1
        {
            get { return Name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("student name is required");
                }
                if (value.Length > 20)
                {
                    throw new Exception("student name should less then 20 characters");
                }
                Name = value;

            }
        }
        public int Age1 { get => Age; set => Age = value; }
        public string Branch1 { get => Branch; set => Branch = value; }
        public string College1 { get => College; set => College = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Status1 { get => Status; set => Status = value; }



        //This method will call the add method 
        public void adding()
        {
            Code codeobj = new Code();
            codeobj.add(RollNo,Name,Age,Branch,College,Gender,Status);
        }

        //This method will call the update method 
        public void updating()
        {
            Code codeobj = new Code();
            codeobj.update(RollNo, Name, Age, Branch, College, Gender, Status);
        }

        //This method will call the delete method
        public void deleting()
        {
            Code codeobj = new Code();
            codeobj.delete(Name1);
        }

        //This method will call the getStudent method 
        public DataSet displayDeatils()
        {
            Code codeobj = new Code();
            return codeobj.display();
        }

        //This method will call the getStudet method with
        public DataSet searchDetails(int Name)
        {
            Code codeobj = new Code();
            return codeobj.search(Name);
        }
    }
}