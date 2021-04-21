using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Posts.Queries.GetPostsList
{
    public class PostInListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
