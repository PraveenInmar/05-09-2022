using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataBaseConnection
{
    public class Code
    {
        //This Method is used for User and Password
        public DataSet getUser(string UserName,string Password)
        {
            //Step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnectionobj = new SqlConnection(connection);
            sqlconnectionobj.Open();
            //step-2
            string query = "select * from UserEntery where UserName='"+UserName+"'and Password='"+Password+"'";
            SqlCommand sqlcmdobj = new SqlCommand(query, sqlconnectionobj);
            SqlDataAdapter adapterobj = new SqlDataAdapter(sqlcmdobj);
            DataSet datasetobj = new DataSet();
            adapterobj.Fill(datasetobj);
            //step-3          
            sqlconnectionobj.Close();
            return datasetobj;

        }

        // This Method is used for display on datagrideview 
        public DataSet display()
        {
                //Step-1
                string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
                SqlConnection sqlconnectionobj = new SqlConnection(connection);
                sqlconnectionobj.Open();
                //step-2
                string query = "select * from Student";
                SqlCommand sqlcmdobj = new SqlCommand(query, sqlconnectionobj);
                SqlDataAdapter adapterobj = new SqlDataAdapter(sqlcmdobj);
                DataSet datasetobj = new DataSet();
                adapterobj.Fill(datasetobj);            
                //step-3          
                sqlconnectionobj.Close();
                return datasetobj;    
        }


        //This Method is used for search by rollNo and display 
        public DataSet search(int RollNo)
        {
            //Step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnectionobj = new SqlConnection(connection);
            sqlconnectionobj.Open();
            //step-2
            string query = "select * from Student where RollNo="+RollNo+"";
            SqlCommand sqlcmdobj = new SqlCommand(query, sqlconnectionobj);
            SqlDataAdapter adapterobj = new SqlDataAdapter(sqlcmdobj);
            DataSet datasetobj = new DataSet();
            adapterobj.Fill(datasetobj);   
            //step-3          
            sqlconnectionobj.Close();
            return datasetobj;
        }


        //Add Method
        public bool add(int RollNo,string Name,int Age,string Branch,string College,string Gender,string Status)
        {
        
            
                //step-1
                string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
                SqlConnection sqlconnection = new SqlConnection(connection);
                sqlconnection.Open();
            try
            { 
                //step-2
                string query = "insert into Student values('"+ RollNo + "','"
                                                             + Name + "','"
                                                             + Age + "','"
                                                             + Branch + "','"
                                                             + College + "','"
                                                             + Gender + "','"
                                                             + Status + "')";
                SqlCommand sqlcommond = new SqlCommand(query, sqlconnection);
                sqlcommond.ExecuteNonQuery();
                sqlconnection.Close();
                return true;
            }
            catch (Exception e)
            {
                
                return false;
            }
        }                                       


        //Update Method
        public bool update(int RollNo,string Name,int Age,string Branch,string College,string Gender,string Status)
        {
            //step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnectionobj = new SqlConnection(connection);
            sqlconnectionobj.Open();
            //step-2
            string query = "update Student set RollNo="
                                                        + RollNo + ",Name='"
                                                        + Name + "',Age="
                                                        + Age + ",Branch='"
                                                        + Branch + "',College='"
                                                        + College + "',Gender='"
                                                        + Gender + "',Status='"
                                                        + Status + "'where RollNo="
                                                        +RollNo+"";
            SqlCommand sqlcommandobj = new SqlCommand(query, sqlconnectionobj);
            sqlcommandobj.ExecuteNonQuery();
            //step-3
            sqlconnectionobj.Close();
            return true;
        }


        //Delete Method
        public bool delete(string Name)
        {
            //step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnectionobj = new SqlConnection(connection);
            sqlconnectionobj.Open();
            //step-2
            string query = "delete from Student where Name='" + Name + "'";
            SqlCommand sqlcommandobj = new SqlCommand(query, sqlconnectionobj);
            sqlcommandobj.ExecuteNonQuery();
            //step-3
            sqlconnectionobj.Close();
            return true;
        }
    }
}
