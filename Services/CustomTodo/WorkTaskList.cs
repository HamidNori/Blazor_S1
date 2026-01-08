

namespace Blazor_S1.Services.CustomTodo
{
    public class WorkTaskList : AbstractCustomTodo
    {
        public List<WorkTaskItem> Task {get; set;} = new();
        public override string ListType => "WorkTaskList";
        public override void AddItem(string input)
        {
            Task.Add((new WorkTaskItem { Title = input }));
        }

        public IEnumerable<WorkTaskItem> GetPendingTasks()
        {
            return Task.Where(t => !t.Done).OrderBy(t => t.DueDate);
        }
        public IEnumerable<WorkTaskItem> GetCompletedTasks()
        {
            return Task.Where(t => t.Done).OrderBy(t => t.DueDate);
        }
    }

    public class WorkTaskItem
    {
        public string Title { get; set; } = "";
        public bool Done { get; set; }

        public DateTime? DueDate { get; set; }
        public WorkPriority Priority { get; set; } = WorkPriority.M;

        public bool IsOverDue =>
            DueDate.HasValue && DueDate.Value.Date < DateTime.Today && !Done;
    }

    public enum WorkPriority
    {
        L,
        M,
        H
    }

    
}