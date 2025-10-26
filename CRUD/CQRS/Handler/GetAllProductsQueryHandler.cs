using CRUD.CQRS.Queries;
using CRUD.Data;
using CRUD.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CRUD.CQRS.Handler
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly AppDbContext _context;

        public GetAllProductsQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }

}
