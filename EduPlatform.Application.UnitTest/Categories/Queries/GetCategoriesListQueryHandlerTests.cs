using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Application.Functions.Categories.Queries.GetCategoriesList;
using EduPlatform.Application.Mapper;
using EduPlatform.Domain.Entities;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EduPlatform.Application.UnitTest.Categories.Queries
{ 
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly GetCategoriesListQueryHandler _handler;
        private readonly Mock<ICategoryRepository> _categoryRepositoryMock = new Mock<ICategoryRepository>();
        private readonly IMapper _mapper;
        public GetCategoriesListQueryHandlerTests()
        {
            _handler = new GetCategoriesListQueryHandler(_categoryRepositoryMock.Object, _mapper);
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTest()
        {
            //Arrange
            List<Category> categories = new List<Category>()
            {
                new Category(){Id=1, Name = "CSharp", DisplayName = "C#"},
                new Category(){Id=2, Name= "aspnet", DisplayName = "ASP.NET"},
                new Category(){Id=3, Name="docker", DisplayName="Docker"},
                new Category(){Id=4, Name="triki-z-windows", DisplayName="Triki z Windows"},
                new Category(){Id=5, Name="filozofia", DisplayName="Filozofia"}
            };

            _categoryRepositoryMock.Setup(repo => repo.GetAllAsync())
                .ReturnsAsync(categories);            

            //Act
            var result = await _handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            //Assert
            result.ShouldBeOfType<List<CategoryInListViewModel>>();
            result.Count.ShouldBe(5);
        }
    }
}
