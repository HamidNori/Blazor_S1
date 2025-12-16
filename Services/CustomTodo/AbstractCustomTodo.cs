using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1.Services.CustomTodo
{
    public abstract class AbstractCustomTodo
    {
        public string? Title { get; set; }

        public abstract string ListType { get; }
        public abstract void AddItem(string text);
    }

    public static class CustomTodoFactory
    {
        public static AbstractCustomTodo Create(string listType)
        {
            return listType switch
            {
                "ShoppingList" => new ShoppingList(),
                "WorkoutList" => new WorkoutList(),
                "WorkTaskList" => new WorkTaskList(),
                _ => throw new ArgumentException("Invalid list type"),
            };
        }
    }
}