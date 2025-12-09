using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using OnionVb02.Persistence.ContextClasses;

namespace OnionVb02.Persistence.RepositoryConcretes
{
    public class ProductAttributeValueRepository(MyContext context) : BaseRepository<ProductAttributeValue>(context), IProductAttributeValueRepository
    {
    }
}
