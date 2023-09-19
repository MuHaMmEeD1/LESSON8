using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosstNameSpace;
using networknamespace;

namespace AdminNamespace
{

    public class Admin
    {
       
        public string id { get; set; } 
        public string username { get; set; } 
        public string email { get; set; } 
        public string password { get; set; } 
        public List<Post> Posts { get; set; } 
        public List<Notification> Notifications { get; set; }

        public Admin(string id,string username, string email, string password, List<Post> posts, List<Notification> notifications)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            Posts = posts;
            Notifications = notifications;
            this.id = id;
        }

        public Admin() { }  

    }


}
