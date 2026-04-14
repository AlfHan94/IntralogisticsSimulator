using Microsoft.AspNetCore.Mvc;
using IntralogisticsSimulator.Data;


namespace IntralogisticsSimulator.Controllers;

public class OrdersController : Controller
{
    public IActionResult Index()
    {
        var orders = FakeDataStore.Orders;
        
        foreach (var order in orders)
        {
            foreach (var item in order.OrderItems)
            {
                item.Product = FakeDataStore.Products.FirstOrDefault(p => p.Id == item.ProductId);
            }
        }

        return View(orders);
    }
}
