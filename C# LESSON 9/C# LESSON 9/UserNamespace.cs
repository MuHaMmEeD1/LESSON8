using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public class User
    {

        public string id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public int age { get; set; }
        public string email { get; set; }

        public string password { get; set; }

        public User(string id, string name, string username, int age, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.username = username;
            this.age = age;
            this.email = email;
            this.password = password;
        }

        public User() { }

    }

   



}
