using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoItem = Blazor_S1.TodoItem;

namespace Blazor_S1.Service
{
    public class TodoService
    {
        private List<TodoItem> _todos = new();
        public List<TodoItem> Todos => _todos;
        
        // Add this event definition
        public event Action? OnChange;

        public void AddTodo(string title)
        {
            var todo = new TodoItem
            {
                Id = Guid.NewGuid(),
                Title = title,
                IsDone = false
            };
            _todos.Add(todo);
            NotifyStateChanged();
        }

        public void DescriptionTodo(Guid id, string description)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                todo.Description = description;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}