﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Application.Contracts.Persistance
{
    public interface IWebinarRepository <T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}