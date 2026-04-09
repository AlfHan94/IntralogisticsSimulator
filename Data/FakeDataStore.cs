namespace IntralogisticsSimulator.Data;

using IntralogisticsSimulator.Models;

public static class FakeDataStore
{

    public static List<Product> Products { get; set; } = new();
    public static List<Order> Orders { get; set; } = new();
    public static List<PickTask> PickTasks { get; set; } = new();

    private static int _nextProductId = 1;
    private static int _nextOrderId = 1;
    private static int _nextPickTaskId = 1;

    public static void Initialize()
    {
        Products = new List<Product>
        {
            new Product
            {
                Id = _nextProductId++,
                Name = "Skruvmejsel 5mm",
                QuantityInStock = 150,
                Location = "A1-B2"
            },
            new Product
            {
                Id = _nextProductId++,
                Name = "Laptop HP Elitebook",
                QuantityInStock = 25,
                Location = "C3-D4"
            },
            new Product
            {
                Id = _nextProductId++,
                Name = "Kontorsstol Ergonomic",
                QuantityInStock = 40,
                Location = "E5-F6"
            },
            new Product
            {
                Id = _nextProductId++,
                Name = "Whiteboard 120x90cm",
                QuantityInStock = 12,
                Location = "G7-H8"
            },
            new Product
            {
                Id = _nextProductId++,
                Name = "USB-kabel USB-C 2m",
                QuantityInStock = 500,
                Location = "A2-B3"
            }
        };

        var order1 = new Order
        {
            Id = _nextOrderId++,
            CreatedAt = DateTime.Now.AddHours(-2),
            Status = "Pending",
            OrderItems = new List<OrderItem>
            {
                new OrderItem {Id = 1, ProductId = 1, Quantity = 10},
                new OrderItem {Id = 2, ProductId = 2, Quantity = 2},
            }
        };

        var order2 = new Order
        {
            Id = _nextOrderId++,
            CreatedAt = DateTime.Now.AddMinutes(-30),
            Status = "Pending",
            OrderItems = new List<OrderItem>
            {
                new OrderItem {Id = 3, ProductId = 5, Quantity = 50}
            }
        };

        Orders = new List<Order> { order1, order2 };
        PickTasks = new List<PickTask>();
    }

    public static int GetNextProductId() => _nextProductId++;
    public static int GetNextOrderId() => _nextOrderId++;
    public static int GetNextPickTaskId() => _nextPickTaskId++;



}
