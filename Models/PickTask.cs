namespace IntralogisticsSimulator.Models;

public class PickTask
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; } = string.Empty;
    public bool IsCompleted { get; set; } = false;
    public Product? Product { get; set; }

}
