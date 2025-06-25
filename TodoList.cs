using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1
{
    public class TodoList
    {
        public List<TodoItem> Items { get; set; } = new();
        public string NewTodoText { get; set; } = "";
        public bool IsDark { get; set; } = false;
        public bool IsLocked { get; set; } = false;
        public bool JustAddded { get; set; } = true;

    }
}