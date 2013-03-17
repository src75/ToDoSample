using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.ToDo
{
    public class ToDoItem
    {
        public int ToDoId { get; set; }
        public string ToDoDescription { get; set; }
        public DateTime? ToDoCreateDate { get; set; }
        public DateTime? ToDoDeadlineDate { get; set; }
    }
}