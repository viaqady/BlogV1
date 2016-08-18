using Data.DAL;
using System;
using System.Linq;


namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
               
                // Display all Posts in the database
                var queryPost = from b in db.Posts
                            orderby b.Fecha
                            select b;
                
                Console.WriteLine("Todos los posts en la base de datos:\n");
                foreach (var item in queryPost)
                {
                    Console.WriteLine(item.TextoPost);
                      
                }

           
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
