using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker
{
    public class Transaction
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }

        public Transaction(string description, decimal amount, string category, string date)
        {
            Description = description;
            Amount = amount;
            Category = category;
            Date = date;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Description: {Description}, Amount: {Amount}, Category: {Category}, Date: {Date}");
        }
    }

}
