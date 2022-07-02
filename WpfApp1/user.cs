using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    public class user
    {
        public List<user> users = new List<user>();
        public string user_name { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public int mojodi { get; set; }
        public user(string user_name, string password, string name, string phone_number)
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
                this.mojodi = 0;
                users.Add(this);
                sqladd();
            }



        }
        public bool check_username(string user_name)
        {
            
            for (int i = 0; i < users.Count; i++)
            {
                if (user_name == users[i].user_name)
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
        public void sqladd()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\WpfApp1\data\user2.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string command;
            command = "insert into Table values('" + user_name + "','" + password + "', '" + name + "','" + phone_number + "','" + mojodi + "')";
            SqlCommand cmd = new SqlCommand(command, conn);
            cmd.BeginExecuteNonQuery();
           // new
           // conn.Close();
        }




    }
}
