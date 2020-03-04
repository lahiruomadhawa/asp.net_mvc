using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shad_web_app.Models.Entity
{
    public class User
    {

        private string userName;

        private string userPassword;

        private int userAge;

        private string userAddress;

        public User(string userName, string userPassword, int userAge, string userAddress)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userAge = userAge;
            this.userAddress = userAddress;
        }

        public User()
        {
        }

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public int UserAge { get => userAge; set => userAge = value; }
        public string UserAddress { get => userAddress; set => userAddress = value; }
    }
}