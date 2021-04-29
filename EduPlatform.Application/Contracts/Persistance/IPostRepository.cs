using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Application.Contracts.Persistance
{
    public interface IPostRepository: IAsyncRepository<Post>
    {
        public Task<bool> IsTitleAdnAuthorAlreadyExist(string title, string author);
    }
}
