using AutoMapper;
using EduPlatform.Application.Contracts.Persistance;
using EduPlatform.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Application.Functions.Webinars.Queries.GetWebinarsListByDate
{
    public class GetWebinarsListByDateQueryHandler : IRequestHandler<GetWebinarsListByDateQuery, PageWebinarInListViewModel>
    {
        private readonly IAsyncRepository _webinarRepository;
        private readonly IMapper _mapper;

        public GetWebinarsListByDateQueryHandler(IAsyncRepository webinarRepositor, IMapper mapper)
        {
            _webinarRepository = webinarRepositor;
            _mapper = mapper;
        }

        public async Task<PageWebinarInListViewModel> Handle(GetWebinarsListByDateQuery request, CancellationToken cancellationToken)
        {
            var webinars = await _webinarRepository.GetPagedWebinarsForDate(request.Option, request.Page, request.PageSize, request.Date);
            var mappedWebinars = _mapper.Map<List<WebinarInListViewModel>>(webinars);

            var count = await _webinarRepository.GetTotalCountOfWebinarsForDate(request.Option, request.Date);

            return new PageWebinarInListViewModel()
            {
                AllCount = count,
                Page = request.Page,
                PageSize = request.PageSize,
                WebinarsOnPage = mappedWebinars
            };
        }
    }
}
