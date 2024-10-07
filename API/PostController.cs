using Domain;
using Microsoft.AspNetCore.MVC;
using Persistance;

namespace API.Controllers
{
    [ApiController]
    [Route("api/(controller)")]

    public class PostController: ControllerBase{

        private readonly DataContext _context;

        public PostsController(DataContext context)
        {
            this._context = context;
        }

        // Get api/posts
        [HttpGet(Name = "GetPosts")]

        public ActionResult<List<Post>> Get()
        {
            return this._context.Posts.ToLists();
        }
    }
}