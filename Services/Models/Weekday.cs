using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1.Services.Models
{
        public class WeekDay
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public List<TodoItem> Todos { get; set; }

        public WeekDay(string name, string key)
        {
            Name = name;
            Key = key;
            Todos = new List<TodoItem>();
        }
        public void AddTodo(string text)
        {
            var todo = new TodoItem(text);
            todo.Id = Todos.Count > 0 ? Todos.Max(t => t.Id) + 1 : 1;
            Todos.Add(todo);
        }

        public void RemoveTodo(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                Todos.Remove(todo);
            }
        }

        public void ToggleTodo(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            todo?.Toggle();
        }

        public int GetCompletedCount()
        {
            return Todos.Count(t => t.IsCompleted);
        }
        
        public int GetTotalCount()
        {
            return Todos.Count;
        }


    }
}