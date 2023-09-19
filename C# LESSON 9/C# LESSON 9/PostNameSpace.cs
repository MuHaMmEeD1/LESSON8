using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosstNameSpace
{
   
    public class Post
    {
       

        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }

        public Post(string ıd, string content, DateTime creationDateTime, int likeCount, int viewCount)
        {
            Id = ıd;
            Content = content;
            CreationDateTime = creationDateTime;
            LikeCount = likeCount;
            ViewCount = viewCount;
        }


        public Post() { }

        public void show() {

            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine($"DateTime: {CreationDateTime}");
            Console.WriteLine($"Like Count: {LikeCount}");
            Console.WriteLine($"View Count: {ViewCount}\n");

        }



    }




}
