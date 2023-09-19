using AdminNamespace;
using networknamespace;
using PosstNameSpace;
using C__LESSON_9;

using UserNamespace;
using System.Diagnostics.Tracing;

class Program
{

    static List<User> users = new List<User>(){ new User("1111", "user","userli" , 18, "user.com","1111") };
    static Admin admin = new Admin("1111", "admin", "admin.com", "1111",

       new List<Post>() { new Post("1111", "en gozel post", new DateTime(2022, 2, 5), 3, 4) },


       new List<Notification>() { new Notification("1111", "TEXTE BAXIN", new DateTime(2022, 2, 4), "1111") }
     );


    static void showPosts()
    {
        for (int i = 0; i < admin.Posts.Count; i++)
        {
            admin.Posts[i].show();
        }

    }

    static void secim()
    {
        Console.WriteLine("(1) Admin kimi gir");
        Console.WriteLine("(2) User kimi gir");

        Console.Write("\nsecim edin: ");
        string sec = Console.ReadLine();

        bool yoxla = false;

        if (sec == "1") {

            Console.Write("\nusername daxil edin: ");
            string usernaem = Console.ReadLine();

            Console.Write("password daxil edin: ");
            string password = Console.ReadLine();

            if (usernaem == admin.username && password == admin.password) {

                Console.WriteLine("(1) Add Post");
                Console.WriteLine("(2) cix");

                Console.Write("\nsecim edin: ");

                sec = Console.ReadLine();
                if (sec == "1") {

                    
                    Console.Write("id daxil edin: "); string id = Console.ReadLine();
                    Console.Write("Content daxil edin: "); string Content = Console.ReadLine();

                    admin.Posts.Add(new Post(id, Content, DateTime.Now, 0, 0));


                }
                else if (sec == "2") { return; }
                else { try { throw new YanlisCesimException(); } catch (YanlisCesimException ex) { Console.WriteLine(ex.Message); } }

            }
            
            else { try{ throw new BeleBirAdminYoxduException(); }catch(BeleBirAdminYoxduException e) { Console.WriteLine(e.Message); } }


        }
        else if (sec == "2") {

            Console.Write("\nusername daxil edin: ");
            string username = Console.ReadLine();

            Console.Write("password daxil edin: ");
            string password = Console.ReadLine();

            int userIndex = -1;

            for (int i = 0; i < users.Count; i++)
            {
                if(username == users[i].username && password == users[i].password) { userIndex = i; }
            }

            if(userIndex >  -1) {


                showPosts();

                for (int i = 0; i < admin.Posts.Count; i++)
                {
                    admin.Posts[i].ViewCount++;
                }

                Console.WriteLine("(1) Like At");
                Console.WriteLine("(2) Cix");

                Console.Write("\nsecim edin:");
                sec = Console.ReadLine();


                if (sec == "1")
                {
                    Console.Write("Post id si dazil edin: ");
                    string id = Console.ReadLine();

                    int postIdIndex = -1;

                    for (int i = 0; i < admin.Posts.Count; i++)
                    {
                        if (admin.Posts[i].Id == id) { postIdIndex = i; }
                    }

                    if (postIdIndex > -1) {

                        admin.Posts[postIdIndex].LikeCount += 1;
                        admin.Notifications.Add(new Notification("1111", "bax", DateTime.Now, users[userIndex].id));

                    }
                    else { try { throw new BelBirIDYoxduException(); } catch (BelBirIDYoxduException ex) { Console.WriteLine(ex.Message); } }
                }


                else if (sec == "2") { return; }

                else { try { throw new BeleBiriYoxduException(); } catch (BeleBiriYoxduException ex) { Console.WriteLine(ex.Message); } } }

             else { try { throw new BeleBiriYoxduException(); } catch (BeleBiriYoxduException ex) { Console.WriteLine(ex.Message); } }



        }
        else { yoxla = true; }

        if (yoxla) { try {throw new YanlisCesimException(); }catch (YanlisCesimException ex){Console.WriteLine(ex.Message);}}

    }

    static void start()
    {
        secim();



        start();
    }


    static void Main(string[] args)
    {
        start();
    }

}