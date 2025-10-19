using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker
{
    // Vi skapar en public klass som heter "BudgetManager"
    public class BudgetManager
    {

        // Vi säger att vi vill ha en privat lista som vi kallar "transactions" (dvs vi skapar nu med "new")
        private List<Transaction> transactions = new List<Transaction>();


        // Metod - tar in och lägger till varje ny transaktions i vår lista
        public void AddTransaction(Transaction nyTransaktion)
        {
            transactions.Add(nyTransaktion); 
        }

        // Metod - för att visa alla transaktioner
        public void ShowAll()
        {
            // Om det inte finns några transaktioner så gör vi följande : 
            if (transactions.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Det finns inga transaktioner ännu.");
                Console.ResetColor();
                return;
            }
            // Annars kör vi en for loop. Som visar varje transaktion
            for (int t = 0; t < transactions.Count; t++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"#{t}: "); // Vi visar upp numret på transaktionen 
                transactions[t].ShowInfo(); // vi visar all information om transaktionen
                Console.ResetColor();
            }
        }

       // Vi kalkulerar aktuella balansen på kontot med vår metod
        public decimal CalculateBalance() // Eftersom vi vill ha ett värde i form av en decimal tillbaka, skriver vi decimal istället för ex. void.
        {
            decimal total = 0; // Startvärde är 0
            foreach (var t in transactions) // för varje "t" i vår lista vill vi plusa
            {
                total += t.Amount; // Hade också kunnat skrivas total = total + t.Amount
            }
            return total; // retunerar aktuella balans
        }

        //Metod för att ta bort transaktion
        public bool DeleteTransaction(int index) 
        { 
            // Vi tittat så inte index är mindre än 0 eller så att index inte är större eller likamed antalet transaktioner i vår lista
            if (index < 0 || index >= transactions.Count)
            {
                return false; // I sådant fall retunerar vi falskt
            }

            transactions.RemoveAt(index); // Annars tar vi bort transaktionen med det index
            return true; // retunerar true
        }
    }
}

