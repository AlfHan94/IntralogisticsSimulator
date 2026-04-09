using Microsoft.AspNetCore.Mvc;
using IntralogisticsSimulator.Data;
namespace IntralogisticsSimulator.Controllers;


public class ProductsController : Controller
{
    public IActionResult Index()
    {
        var products = FakeDataStore.Products;
        return View(products);
    }
}
