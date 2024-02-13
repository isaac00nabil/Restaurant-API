namespace Restaurant_API.DTOs
{
    public class CreateNewMealsDTO
    {
        public string MealName  {get;set;}
        public string MealType  {get;set;}
        public float MealPrice  {get;set;}
        public bool MealStatus { get; set; }
    }
}
