using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.ToDo
{
    public class ToDoViewModel
    {
        public ToDoViewModel()
        {
            ToDoList = new List<ToDoItem>();
        }

        public string NewToDoDescription { get; set; }
        public DateTime? NewToDoDeadline { get; set; }
        public List<ToDoItem> ToDoList { get; set; }
    }
}