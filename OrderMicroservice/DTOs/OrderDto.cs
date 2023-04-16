namespace OrderMicroservice.DTOs
{
    public class OrderDto
    {
        public string? Name { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
    }
}
