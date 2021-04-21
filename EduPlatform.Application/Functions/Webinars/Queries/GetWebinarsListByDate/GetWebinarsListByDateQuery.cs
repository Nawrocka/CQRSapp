using EduPlatform.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Webinars.Queries.GetWebinarsListByDate
{
    public class GetWebinarsListByDateQuery : IRequest<PageWebinarInListViewModel>
    {
        public DateTime? Date { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public SearchOptionsWebinars Option { get; set; }
    }
}
