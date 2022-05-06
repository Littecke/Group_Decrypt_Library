﻿using Decrypt_Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace Decrypt_Library.EntityFrameworkCode
{
    public class EntityframeworkUsers
    {
        public static List<User> ShowAllUsers()
        {
            using (var db = new Decrypt_LibraryContext())
            {
                var users = db.Users.ToList();
                return users;
            }
        }

        public static void CreateUser(User newCustomer)
        {
            try
            {
                using (var db = new Decrypt_LibraryContext())
                {
                    var userList = db.Users;

                    userList.Add(newCustomer);
                    db.SaveChanges();
                }

            }
            catch (System.Exception)
            {
                
            }
           
        }
    }
}
