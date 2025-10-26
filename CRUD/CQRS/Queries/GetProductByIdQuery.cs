using CRUD.Model;
using MediatR;

namespace CRUD.CQRS.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;

}
