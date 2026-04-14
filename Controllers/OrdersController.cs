using Microsoft.AspNetCore.Mvc;
using IntralogisticsSimulator.Data;


namespace IntralogisticsSimulator.Controllers;

public class OrdersController : Controller
{
    public IActionResult Index()
    {
        var orders = FakeDataStore.Orders;
        return View(orders);
    }
}
