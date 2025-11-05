using System;

namespace Blazor_S1.Services.Models
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
        public bool JustAddded { get; set; } = true;
    }
}