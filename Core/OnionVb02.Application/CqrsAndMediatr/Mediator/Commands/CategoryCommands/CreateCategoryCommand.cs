using MediatR;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.CategoryResults;
public class CreateCategoryCommand : IRequest // Generic dönüş eklendi
{
    public string CategoryName { get; set; }
    public string Description { get; set; }
}
