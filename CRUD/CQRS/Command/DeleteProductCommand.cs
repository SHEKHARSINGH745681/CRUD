using MediatR;

namespace CRUD.CQRS.Command
{
    public record DeleteProductCommand(int Id) : IRequest<bool>;

}
