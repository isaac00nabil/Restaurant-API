namespace Restaurant_API.DTOs
{
    public class CreateNewItemsDTO
    {
        public string ItemName {get; set;}
        public string ItemType {get; set;}
        public float ItemPrice {get; set;}
        public bool ItemStatus { get; set; }
    }
}
