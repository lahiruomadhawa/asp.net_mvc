using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using shad_web_app.Models.DAO;
using shad_web_app.Models.Entity;
using shad_web_app.Models.Connection;
using System.Data.SqlClient;

namespace shad_web_app.Models.Service
{
    public class UserService : UserDAO
    {

        SqlConnection con = DBConnection.getConnection();

        public string createUser(User user)
        {
            try
            {
                SqlCommand cm = new SqlCommand("INSERT INTO UserTable (Uname, Upassword, Uage, Uaddress) VALUES ('" + user.UserName + "', '" + user.UserPassword + "', " + user.UserAge + ", '" + user.UserAddress + "');", con);

                con.Open();
                int i = cm.ExecuteNonQuery();

                if (i > 0)
                {
                    return "ok";
                }
                else
                {
                    return "not";
                }

            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                con.Close();
            }
        }

        public List<User> getAllUsers()
        {
            List<User> userList = new List<User>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable", con);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    userList.Add(new User(dr["Uname"].ToString(), dr["Upassword"].ToString(), int.Parse(dr["Uage"].ToString()), dr["Uaddress"].ToString()));
                }

                return userList;

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public string updateUser(string name, string newPassword)
        {
            throw new NotImplementedException();
        }

        public string validate(string name, string password)
        {
            try
            {
                string getName = null;
                string getPass = null;

                SqlCommand cmd = new SqlCommand("SELECT Uname, Upassword FROM UserTable WHERE Uname='"+name+"' AND Upassword='"+password+"' ;",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    getName = dr["Uname"].ToString();
                    getPass = dr["Upassword"].ToString();
                }

                if (getName.Equals(name) && getPass.Equals(password))
                {
                    return "ok";
                }
                else
                {
                    return "not";
                }

            }
            catch (Exception e)
            {
                return "error";
            }
            finally
            {
                con.Close();
            }
        }

        public string deleteUser(string name)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM UserTable WHERE Uname='"+name+"' ;", con);
                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i>0)
                {
                    return "ok";
                }
                else
                {
                    return "not";
                }


            }
            catch (Exception e)
            {
                return "error";
            }
            finally
            {
                con.Close();
            }
        }
    }
}