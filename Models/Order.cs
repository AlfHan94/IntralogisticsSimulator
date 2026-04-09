namespace IntralogisticsSimulator.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string Status { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
