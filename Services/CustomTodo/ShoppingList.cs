using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_S1.Services.CustomTodo
{
    public class ShoppingList : AbstractCustomTodo
    {
        public List<ShoppingItem> Items { get; set; } = new();

        public override string ListType => "ShoppingList";
        public override void AddItem(string text)
        {
            Items.Add(new ShoppingItem { Name = text });
        }

        public void ToggleItem(ShoppingItem item)
        {
            item.IsChecked = !item.IsChecked;
        }

        public void RemoveItem(ShoppingItem item)
        {
            Items.Remove(item);
        }
        public decimal GetTotalCost()
        {
            return Items.Sum(item => item.TotalPrice);
        }
    }

    public class ShoppingItem
    {
        public string Name { get; set; } = "";
        public int Quantity { get; set; } = 1;
        public bool IsChecked { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Price * Quantity;
    }
}