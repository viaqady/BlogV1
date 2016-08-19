using Data.DAL;
using Data.Models;
using DataLayer.Models;
using System;
using System.Linq;


namespace Blog
{
    class Program 
    {

        public static void PostCRUD()
        {
            PostRepository postRep = new PostRepository(new BlogContext());
            var result = postRep.getList();

            Console.WriteLine("\nTodos los posts en la base de datos\n");
            foreach (var item in result)
            {
                Console.WriteLine(item.TextoPost);
            }

        }

        public static void UserCRUD()
        {
            Usuario usuario = new Data.Models.Usuario { UsuarioId = Guid.NewGuid(), NombreUsuario = "Pedro Picapiedra", Password = "1234", Email = "a.a@a.com" };
            UsuarioRepository usuarioRep = new UsuarioRepository(new BlogContext());
            usuarioRep.Insert(usuario);
            var result = usuarioRep.getList();

            Console.WriteLine("\nTodos los usuarios en la base de datos\n");
            foreach (var item in result)
            {
                Console.WriteLine(item.NombreUsuario);
            }
        }
        static void Main(string[] args)
        {
            PostCRUD();
            UserCRUD();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
