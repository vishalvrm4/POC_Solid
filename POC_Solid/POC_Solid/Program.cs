// See https://aka.ms/new-console-template for more information
using POC_Solid;

Console.WriteLine("Hello, World!");

IEmailService emailService = new EmailService();
ISMSService sMSService = new SMSService();
        ProductService productService = new ProductService(emailService,sMSService);

        Product product = new Product { Name = "Laptop", Price = 1200 };
        productService.AddProduct(product);

        IDiscount discount = new PercentDiscount(10);
        OrdersService ordersService = new OrdersService(discount);
        decimal total = ordersService.CalculateTotal(product.Price);

Console.WriteLine($"Total after discount: {total}");