using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;

namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Queries.AppUserProfileProfileQueries
{
    public class GetAppUserProfileQuery : IRequest<List<GetAppUserProfileQueryResult>>
    {
    }
}
