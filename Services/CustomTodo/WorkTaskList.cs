using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1.Services.CustomTodo
{
    public class WorkTaskList : AbstractCustomTodo
    {
        public List<(string Task, bool Done)> Task {get; set;} = new();
        public override string ListType => "WorkTaskList";
        public override void AddItem(string input)
        {
            Task.Add((input, false));
        }
    }
}