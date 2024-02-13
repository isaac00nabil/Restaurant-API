namespace Restaurant_API.DTOs
{
    public class UpdateNewItemsDTO
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public float ItemPrice { get; set; }
        public bool ItemStatus { get; set; }
    }
}
