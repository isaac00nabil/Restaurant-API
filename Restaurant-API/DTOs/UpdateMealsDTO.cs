namespace Restaurant_API.DTOs
{
    public class UpdateMealsDTO
    {
        public int MealId { get; set; }
        public string MealName { get; set; }
        public string MealType { get; set; }
        public float MealPrice { get; set; }
        public bool MealStatus { get; set; }
    }
}
