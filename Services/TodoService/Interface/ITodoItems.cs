using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1.Services.TodoService.Interface
{
    public interface ITodoItems
    {
        void RemoveItem();
        void AddItem();
    }
}