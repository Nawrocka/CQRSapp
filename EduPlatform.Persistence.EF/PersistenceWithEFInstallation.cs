using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Persistence.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF
{
    public static class PersistenceWithEFInstallation
    {
        public static IServiceCollection AddEduPlatformPersistenceEFServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EduPlatformContext>(options =>
                options.UseSqlServer(configuration
                .GetConnectionString("EduPlatformCOnnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IWebinarRepository, WebinarRepository>();

            return services;
        }


    }
}
