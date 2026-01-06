using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_S1.Services.TodoService.Interface;
using Blazor_S1.Services.Models;

namespace Blazor_S1.Services.TodoService
{
    public class TodoService : ITodoService
    {
        private List<WeekDay> _weekDays;

        public TodoService()
        {
            InitializeWeek();
        }

        private void InitializeWeek()
        {
       _weekDays = new List<WeekDay>
        {
            new WeekDay("MÅNDAG", "monday"),
            new WeekDay("TISDAG", "tuesday"),
            new WeekDay("ONSDAG", "wednesday"),
            new WeekDay("TORSDAG", "thursday"),
            new WeekDay("FREDAG", "friday"),
            new WeekDay("LÖRDAG", "saturday"),
            new WeekDay("SÖNDAG", "sunday")
        };
    }

    public List<WeekDay> GetAllDays()
    {
        return _weekDays;
    }

    public WeekDay GetDay(string key)
    {
        return _weekDays.FirstOrDefault(d => d.Key == key);
    }

    public void AddTodoToDay(string dayKey, string todoText)
    {
        var day = GetDay(dayKey);
        day?.AddTodo(todoText);
    }

    public void RemoveTodoFromDay(string dayKey, int todoId)
    {
        var day = GetDay(dayKey);
        day?.RemoveTodo(todoId);
    }

    public void ToggleTodoInDay(string dayKey, int todoId)
    {
        var day = GetDay(dayKey);
        day?.ToggleTodo(todoId);
    }
    }
}
