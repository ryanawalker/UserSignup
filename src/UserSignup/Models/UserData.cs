using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        private static List<User> users = new List<User>();
        
        //DONE 2: instantiate a few new users in code here and add them to your users list
        //then write methods to add users to your list, return all users and return a user by UserId

        public static List<User> GetUsers()
        {
            return users;
        }

        public static void AddUser(User newUser)
        {
            users.Add(newUser);
        }

        public static User GetUserById(int userId)
        {
            return users.Single(user => user.UserId == userId);
        }

    }
}
