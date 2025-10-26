using CRUD.CQRS.Command;
using CRUD.Data;
using CRUD.Model;
using MediatR;

namespace CRUD.CQRS.Handler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product { Name = request.Name, Price = request.Price };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }
    }

}
