using MediatR;

namespace CRUD.CQRS.Command
{

    public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;

}
