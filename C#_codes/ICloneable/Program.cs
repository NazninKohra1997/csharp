using ImportantInterface;

Product product = new Product();

product.Name = "Camera";
product.Price = 3000;


if (product is ICloneable)
{
    Product product1 = (Product)product.Clone();
    Console.WriteLine(product1.Name);
    Console.WriteLine(product1.Price);

}

