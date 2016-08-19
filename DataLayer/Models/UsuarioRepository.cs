using Data.DAL;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class UsuarioRepository
    {
        private BlogContext _blogcontext;

        public UsuarioRepository(BlogContext blogcontext)
        {
            _blogcontext = blogcontext;
        }

        public void Insert(Usuario usuario)
        {
            Console.WriteLine("Insert");
            _blogcontext.Usuarios.Add(usuario);
            _blogcontext.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _blogcontext.Entry<Usuario>(usuario).State = System.Data.Entity.EntityState.Modified;
            _blogcontext.SaveChanges();
        }

        public void Delete(Usuario usuario)
        {
            _blogcontext.Usuarios.Remove(usuario);
            _blogcontext.SaveChanges();
        }

        public IQueryable<Usuario> getList()
        {
            IQueryable<Usuario> result = _blogcontext.Usuarios;
            return result;
        }

        public void getListOfLastElements()
        {
        }
    }
}