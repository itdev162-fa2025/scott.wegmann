using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence {

    public class Seed {
        
     public static void SeedData(DataContext context)
     {
        if (!context.Posts.Any())
        {
            var Posts = new List<Post>
            {
                new Post {
                    Title = "First Post",
                    Body = "Hello World",
                    Date = DateTime.Now.AddDays(-10)

                },
                new Post 
                {
                    Title = "First Post",
                    Body = "What a new Day",
                    Date = DateTime.Now.AddDays(-10)

                },
                new Post
                {
                    Title = "First Post",
                    Body = "Greetings to you",
                    Date = DateTime.Now.AddDays(-10)

                }
            };

            context.Posts.AddRange(Posts);
            context.SaveChanges();
        }
     }   
    }
}