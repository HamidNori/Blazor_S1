using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1.Services.CustomTodo
{
    public class ShoppingList : AbstractCustomTodo
    {
        public List<string> Items { get; set; } = new();

        public override string ListType => "ShoppingList";
        public override void AddItem(string text)
        {
            Items.Add(text);
        }
    }
}