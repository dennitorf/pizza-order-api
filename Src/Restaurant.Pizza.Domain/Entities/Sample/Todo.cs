using Restaurant.Pizza.Domain.Common;
using System.Collections.Generic;

namespace Restaurant.Pizza.Domain.Entities.Sample
{
    public class Todo : BaseEntity
    {
        public string Name { set; get; }        
        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }
}
