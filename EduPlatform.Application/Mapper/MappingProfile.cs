using AutoMapper;
using EduPlatform.Application.Functions.Categories.Commands.CreateCategory;
using EduPlatform.Application.Functions.Categories.Queries.GetCategoriesList;
using EduPlatform.Application.Functions.Categories.Queries.GetCategoriesListWithPosts;
using EduPlatform.Application.Functions.Posts.Commands.CreatePost;
using EduPlatform.Application.Functions.Posts.Commands.DeletePost;
using EduPlatform.Application.Functions.Posts.Commands.UpdatePost;
using EduPlatform.Application.Functions.Posts.Queries.GetPostDetail;
using EduPlatform.Application.Functions.Posts.Queries.GetPostsList;
using EduPlatform.Application.Functions.Webinars.Queries.GetWebinar;
using EduPlatform.Application.Functions.Webinars.Queries.GetWebinarsListByDate;
using EduPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostInListViewModel>().ReverseMap();
            CreateMap<Post, PostDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>();

            CreateMap<Category, CategoryInListViewModel>();
            CreateMap<Category, CategoryWithPostsInListViewModel>();
            CreateMap<Post, CategoryPostDto>();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();

            CreateMap<Webinar, WebinarViewModel>().ReverseMap();
            CreateMap<Webinar, WebinarInListViewModel>().ReverseMap();

            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>();
        }
    }
}
