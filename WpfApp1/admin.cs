using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class admin
    {
        public List<admin> admins = new List<admin>();
        public string user_name { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public admin(string user_name, string password, string name, string phone_number)
        {




            if (check_username(user_name) == false)
            {
                throw new Exception("username is not valid");
            }
            else
            {


                this.user_name = user_name;
                this.password = password;
                this.name = name;
                this.phone_number = phone_number;
                admins.Add(this);
            }



        }
        public bool check_username(string user_name)
        {

            for (int i = 0; i < admins.Count; i++)
            {
                if (user_name == admins[i].user_name)
                {
                    return false;
                }
                else
                {
                    continue;
                }
            }
            return true;
        }
    }
}
