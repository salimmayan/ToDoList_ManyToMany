using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
    {
        public Category()
        {
            this.JoinEntities = new HashSet<CategoryItem>();  //in one to many this was: this.Items = new HashSet<Item>(); 
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CategoryItem> JoinEntities { get; set; }  //in one to many this was:  public virtual ICollection<Item> Items { get; set; }  //Items:Item::JoinEntities:CategoryItem
    }    ////Items:Item::JoinEntities:CategoryItem  //JoinEntities property now holds the list of associated categories.
} 