namespace OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults
{
    public class GetProductAttributeValueByIdQueryResult
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public string Value { get; set; }
    }
}
