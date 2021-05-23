using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()  //in one to many there was no constructor and saving soemthing in HashSet was absent
        {
            this.JoinEntities = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CategoryItem> JoinEntities { get; } //in one to many:  public int CategoryId { get; set; }  && public virtual Category Category { get; set; }
                                                                       //JoinEntities property now holds the list of associated categories.

    }
}