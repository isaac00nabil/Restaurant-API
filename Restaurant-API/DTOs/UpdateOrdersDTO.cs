namespace Restaurant_API.DTOs
{
    public class UpdateOrdersDTO
    {
        public int OrderId { get; set; }
        public float TotalPrice { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public int EmployeeId { get; set; }
        public int ItemId { get; set; }
        public int MealId { get; set; }
    }
}
