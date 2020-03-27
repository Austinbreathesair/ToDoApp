namespace ToDoList.Models
{
    public class ItemModel
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string ItemName { get; set; }
        public bool ItemChecked { get; set; } = false;
    }
}