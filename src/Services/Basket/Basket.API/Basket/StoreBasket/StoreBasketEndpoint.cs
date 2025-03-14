namespace Basket.API.Basket.StoreBasket;

public record GetBasketRequest(string UserName);

public record GetBasketResponse(ShoppingCart cart);

public class StoreBasketEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        throw new NotImplementedException();
    }
}
