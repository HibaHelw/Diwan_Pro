using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiwanModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DiwanControllers.ModelsControllers
{
    public class PostController : BaseController<Post>
    {

        public List<Post> GetAllPosts(int year)
        {
            return _context.Posts.Include(c => c.PostType).Include(c => c.PostState)
                .Include(c => c.Sender)
                .Where(c => c.IsExist == true && c.Year == year).ToList();
        }

        public List<Post> GetPostsWithType(int typeId)
        {
            return _context.Posts.Where(c => c.IsExist == true
                                             && c.PostTypeId == typeId).ToList();
        }
        public List<Post> GetPostsWithState(int stateId)
        {
            return _context.Posts.Where(c => c.IsExist == true
                                             && c.PostStateId == stateId).ToList();
        }

        public List<Post> GetPostsInYear(int year)
        {
            return _context.Posts.Where(c => c.IsExist == true
                                             && c.Year == year).ToList();
        }

        public List<PostEmployee> GetPostReceivers(int postId)
        {
            return _context.PostEmployees.Where(c => c.PostId == postId).ToList();
        }
        public void DeletePostReceivers(int postId)
        {
            var receivers = _context.PostEmployees.Where(c => c.PostId == postId).ToList();
            _context.PostEmployees.RemoveRange(receivers);
            _context.SaveChanges();
        }
        public void AddPostReceivers(int postId, List<int> receivers)
        {
            foreach (var rec in receivers)
            {
                var postEmployee = new PostEmployee()
                {
                    ReceiverId = rec,
                    PostId = postId,
                    State = "",
                };
                _context.PostEmployees.Add(postEmployee);
            }

            _context.SaveChanges();
        }
    }
}
