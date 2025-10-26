using CRUD.CQRS.Command;
using CRUD.Data;
using MediatR;

namespace CRUD.CQRS.Handler
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly AppDbContext _context;

        public UpdateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null) return false;

            product.Name = request.Name;
            product.Price = request.Price;

            await _context.SaveChangesAsync();
            return true;
        }
    }

}
