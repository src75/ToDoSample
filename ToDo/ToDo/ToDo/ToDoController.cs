using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.ToDo
{
    public class ToDoController
    {
        public ToDoViewModel Index()
        {
            ToDoViewModel model = new ToDoViewModel();
            HttpContext.Current.Session["ToDoList"] = model.ToDoList;

            return model;
        }

        public ToDoViewModel Post(ToDoViewModel model)
        {
            int MaxId = 0;
            List<ToDoItem> ToDoList = new List<ToDoItem>();
            ToDoList = (List<ToDoItem>)HttpContext.Current.Session["ToDoList"];
            if (ToDoList.Count > 0)
            {
                MaxId = ToDoList.OrderByDescending(i => i.ToDoId).First().ToDoId;
            }
            ToDoList.Add(new ToDoItem()
            {
                ToDoId = MaxId + 1,
                ToDoDescription = model.NewToDoDescription,
                ToDoDeadlineDate = model.NewToDoDeadline,
                ToDoCreateDate = DateTime.Now.Date
            });

            model.ToDoList = ToDoList;

            return model;
        }

    }
}