using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduPlatform.Application.Functions.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<int>
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
