using System.Collections;
using System.Collections.Generic;

namespace ToDoList.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<CategoryModel> CategoryTypes { get; set; }
    }
    
    
}