using EduPlatform.Application.Common;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EduPlatform.Persistence.EF.Repositories
{
    public class WebinarRepository : BaseRepository<Webinar>, IWebinarRepository
    {
        public WebinarRepository(EduPlatformContext dbContext): base(dbContext)
        {
        }

        public async Task<List<Webinar>> GetPagedWebinarsForDate(SearchOptionsWebinars option, int page, int pageSize, DateTime? date)
        {
            if(option == SearchOptionsWebinars.Month && date.HasValue)
            {
                return await _dbContext.Webinars.Where(w => w.Date.Month == date.Value.Month)
                    .Skip((page - 1) * pageSize).Take(pageSize).AsNoTracking().ToListAsync();
            }
            else if(option == SearchOptionsWebinars.Year && date.HasValue)
            {
                return await _dbContext.Webinars.Where(w => w.Date.Year == date.Value.Year)
                    .Skip((page - 1) * pageSize).Take(pageSize).AsNoTracking().ToListAsync();
            }
            else if(option == SearchOptionsWebinars.MonthAndYear && date.HasValue)
            {
                return await _dbContext.Webinars.Where(w=>w.Date.Month == date.Value.Month && w.Date.Year == date.Value.Year)
                      .Skip((page - 1) * pageSize).Take(pageSize).AsNoTracking().ToListAsync();
            }
            else
            {
                return await _dbContext.Webinars
                   .Skip((page - 1) * pageSize).Take(pageSize).AsNoTracking().ToListAsync();
            }
        }

        public async Task<int> GetTotalCountOfWebinarsForDate(SearchOptionsWebinars option, DateTime? date)
        {
            if (option == SearchOptionsWebinars.Month && date.HasValue)
            {
                return await _dbContext.Webinars.CountAsync(w => w.Date.Month == date.Value.Month);
            }
            else if (option == SearchOptionsWebinars.Year && date.HasValue)
            {
                return await _dbContext.Webinars.CountAsync(w => w.Date.Year == date.Value.Year);
            }
            else if (option == SearchOptionsWebinars.MonthAndYear && date.HasValue)
            {
                return await _dbContext.Webinars.CountAsync(w => w.Date.Month == date.Value.Month && w.Date.Year == date.Value.Year);                      
            }
            else
            {
                return await _dbContext.Webinars.CountAsync();
            }            
        }
    }
}
