using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataBaseConnection;

namespace Host
{
    public class UserClass
    {
        private string userName = "";
        private string password = "";

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool isValid()
        {
            Code c = new Code();
            if(c.getUser(userName, password).Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

    }
}
