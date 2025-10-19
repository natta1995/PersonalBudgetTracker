using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker
{
    // Vi har en public klass som heter Transactions. Vi vill ha den public för att komma åt den överallt i applikationen. 
    public class Transaction
    {

        // Vi skriver de properties vi vill ha ( Tankesätt: vi skapar "lådorna")
        public string Description { get; set; } //ex. ICA
        public decimal Amount { get; set; } //ex. 2000
        public string Category { get; set; } //ex. Mat
        public string Date { get; set; } // ex. 2025-10-17



        // Vi använder konstruktor när vi skapar en ny transaktion. 
        // Vi tar emot värdena och lagrar dem i (Tankesätt: lådorna - start rad 23) 
        public Transaction(string description, decimal amount, string category, string date) 
        {
        
            Description = description; 
            Amount = amount;
            Category = category;
            Date = date;
        }

        // Vi använder en metod som visar upp hela transaktionen - dvs all information
        public void ShowInfo()
        {
            Console.WriteLine($"Description: {Description}, Amount: {Amount}, Category: {Category}, Date: {Date}");
        }
    }

}
