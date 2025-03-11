namespace BlazorCascadingAndLogging.Models
{
    public class CounterModel
    {
        public int Count { get; set; } = 0;
        public event Action? OnCountChanged;

        public void IncrementCount()
        {
            Count++;
            OnCountChanged?.Invoke();
        }
    }
}
