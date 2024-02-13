namespace Restaurant_API.DTOs
{
    public class CreateNewOrdersDTO
    {
        public float TotalPrice { get; set; }
        public bool OrderStatus { get; set; }
        public int EmployeeId { get; set; }
        public int ItemId { get; set; }
        public int MealId { get; set; }
    }
}
