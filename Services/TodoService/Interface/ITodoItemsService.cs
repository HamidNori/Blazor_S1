using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_S1.Services.Models;

namespace Blazor_S1.Services.TodoService.Interface
{
    public interface ITodoService
    {
        List<WeekDay> GetAllDays();
        WeekDay GetDay(string key);
        void AddTodoToDay(string dayKey, string todoText);
        void RemoveTodoFromDay(string dayKey, int todoId);
        void ToggleTodoInDay(string dayKey, int todoId);
    }
}