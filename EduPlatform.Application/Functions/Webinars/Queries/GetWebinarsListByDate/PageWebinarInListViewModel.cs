using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Webinars.Queries.GetWebinarsListByDate
{
    public class PageWebinarInListViewModel
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public int AllCount { get; set; }
        public ICollection<WebinarInListViewModel> WebinarsOnPage { get; set; }
    }
}
