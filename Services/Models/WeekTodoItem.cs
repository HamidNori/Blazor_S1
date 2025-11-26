using System;

namespace Blazor_S1.Services.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }

        public TodoItem(string text)
        {
            Text = text;
            IsCompleted = false;
            CreatedAt = DateTime.Now;
        }

        public void Toggle()
        {
            IsCompleted = !IsCompleted;
        }
    }
}