﻿using EduPlatform.Application.Common;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF.Repositories
{
    public class WebinarRepository : IWebinarRepository
    {
        public Task<Webinar> AddAsync(Webinar entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Webinar entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Webinar>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Webinar> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Webinar>> GetPagedWebinarsForDate(SearchOptionsWebinars option, int page, int pageSize, DateTime? date)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalCountOfWebinarsForDate(SearchOptionsWebinars option, DateTime? date)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Webinar entity)
        {
            throw new NotImplementedException();
        }
    }
}
