namespace PersonalBudgetTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new Transaction("Grocery Shopping", 150.75m, "Food", "2024-06-15");
            t.ShowInfo();
        }
    }
}
