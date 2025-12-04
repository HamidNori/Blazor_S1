using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1.Services.CustomTodo
{
    public class WorkoutList : AbstractCustomTodo
    {
        public List<string> Exercises { get; set; } = new();
        public override string ListType => "WorkoutList";
        public override void AddItem(string input)
        {
            Exercises.Add(input);
        }
    }
}