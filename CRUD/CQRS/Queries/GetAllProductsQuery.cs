using CRUD.Model;
using MediatR;

namespace CRUD.CQRS.Queries
{
    public record GetAllProductsQuery() : IRequest<List<Product>>;
}
