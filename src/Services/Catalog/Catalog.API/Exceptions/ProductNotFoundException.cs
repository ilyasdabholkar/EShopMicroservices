namespace Catalog.API.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException() : base("Product Not Found!"){}
    public ProductNotFoundException(string message)
          : base(message) { }

    public ProductNotFoundException(string message, Exception innerException)
        : base(message, innerException) { }
}
