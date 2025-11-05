using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_S1.Services.TodoService.Interface;

namespace Blazor_S1.Services.TodoService
{
    public class TodoItemsService : ITodoItems
    {
        string newTodo = "";
        string nameTodo = "";
        public void AddItem()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }

        public void RemoveItem()
        {
            throw new NotImplementedException();
        }
    }
}