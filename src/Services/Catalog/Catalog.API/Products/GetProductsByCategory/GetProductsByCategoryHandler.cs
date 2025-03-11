
namespace Catalog.API.Products.GetProductsByCategory;

public record GetProductsByCategoryQuery(string Category) : IQuery<GetProductsByCategoryResult>;
public record GetProductsByCategoryResult(IEnumerable<Product> Products);

public class GetProductsByCategoryHandler(IDocumentSession session, ILogger<GetProductsByCategoryHandler> logger) : IQueryHandler<GetProductsByCategoryQuery, GetProductsByCategoryResult>
{
    public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductsByCategoryHandler.Handle called with {@Query}", query);
        var products = await session.Query<Product>().Where(p => p.Category.Contains(query.Category)).ToListAsync();
        return new GetProductsByCategoryResult(products);
    }
}
