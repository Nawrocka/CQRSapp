using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Contracts.Persistance
{
    public interface IPostRepository: IWebinarRepository<Post>
    {
    }
}
