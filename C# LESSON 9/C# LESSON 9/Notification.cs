using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networknamespace 
{ 
    public class Notification
    {

        public string Id { get; set; }
        public string Text { get; set; }
        public DateTime dateTime { get; set; }
        public string FromUser { get; set; }


        public Notification(string ıd, string text, DateTime dateTime, string fromUser)
        {
            Id = ıd;
            Text = text;
            this.dateTime = dateTime;
            FromUser = fromUser;
        }

        public Notification() { }


    }
}
