using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Webinars.Queries.GetWebinar
{
    class GetWebinarQueryHandler : IRequestHandler<GetWebinarQuery, WebinarViewModel>
    {
        private readonly IAsyncRepository<Webinar> _webinarRepository;
        private readonly IMapper _mapper;

        public GetWebinarQueryHandler(IAsyncRepository<Webinar> webinarRepository,IMapper mapper)
        {
            _webinarRepository = webinarRepository;
            _mapper = mapper;
        }
        public async Task<WebinarViewModel> Handle(GetWebinarQuery request, CancellationToken cancellationToken)
        {
            var webinar = await _webinarRepository.GetByIdAsync(request.Id);

            var webinarMapped = _mapper.Map<WebinarViewModel>(webinar);

            return webinarMapped;
        }
    }
}
