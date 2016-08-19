using Data.DAL;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class PostRepository
    {
        private BlogContext _blogcontext;
        
        public PostRepository(BlogContext blogcontext)
        {
            _blogcontext = blogcontext;
        }

        public void Insert(Post post)
        {
            Console.WriteLine("Insert");
            _blogcontext.Posts.Add(post);
            _blogcontext.SaveChanges();
        }

        public void Update(Post post)
        {
            _blogcontext.Entry<Post>(post).State = System.Data.Entity.EntityState.Modified;
            _blogcontext.SaveChanges();
        }

        public void Delete(Post post)
        {
            _blogcontext.Posts.Remove(post);
            _blogcontext.SaveChanges();
        }

        public IQueryable<Post> getList()
        {
            IQueryable<Post> result = _blogcontext.Posts;
            return result;
        }

        public void getListOfLastElements()
        {
        }
    }
}
