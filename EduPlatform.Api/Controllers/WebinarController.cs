using EduPlatform.Application.Common;
using EduPlatform.Application.Functions.Webinars.Commands.CreateWebinar;
using EduPlatform.Application.Functions.Webinars.Queries.GetWebinar;
using EduPlatform.Application.Functions.Webinars.Queries.GetWebinarsListByDate;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduPlatform.Api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class WebinarController : Controller
    {
        private readonly IMediator _mediator;

        public WebinarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddWebinar")]
        public async Task<ActionResult<CreateWebinarCommandResponse>> Create([FromBody] CreateWebinarCommand createWebinarCommand)
        {
            var response = await _mediator.Send(createWebinarCommand);
            return Ok(response);
        }

        [HttpGet("{id}", Name = "GetWebinar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<WebinarViewModel>> GetWebinarById(int id)
        {
            var result = await _mediator.Send(new GetWebinarQuery() { Id = id });
            return Ok(result);
        }

        [HttpGet("/getwebinarfordate", Name ="GetPagedWebinarsForDate")]
        public async Task<ActionResult<PageWebinarInListViewModel>> GetPagedWebinars(SearchOptionsWebinars searchWebinarOption, int page, int pagesize, DateTime? date)
        {
            var getWebinarsListByDataQuery = new GetWebinarsListByDateQuery()
            {
                Option = searchWebinarOption,
                Page = page,
                PageSize = pagesize,
                Date = date
            };

            var result = await _mediator.Send(getWebinarsListByDataQuery);

            return Ok(result);
        }
    }
}
