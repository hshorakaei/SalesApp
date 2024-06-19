public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}
