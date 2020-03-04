using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shad_web_app.Models.Entity;

namespace shad_web_app.Models.DAO
{
    interface UserDAO
    {

        string validate(string name, string password);

        string createUser(User user);

        List<User> getAllUsers();

        string updateUser(string name, string newPassword);

        string deleteUser(string name);

    }
}
