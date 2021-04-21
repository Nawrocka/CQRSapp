using EduPlatform.Application.Common;
using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Application.Contracts.Persistance
{
    public interface IWebinarRepository: IWebinarRepository<Webinar>
    {
        Task<List<Webinar>> GetPagedWebinarsForDate(SearchOptionsWebinars option, int page, int pageSize, DateTime? date);

        Task<int> GetTotalCountOfWebinarsForDate(SearchOptionsWebinars option, DateTime? date);
    }
}
