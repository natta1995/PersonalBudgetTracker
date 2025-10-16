using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetTracker
{
    public class BudgetManager
    {
      
        private List<Transaction> transactions = new List<Transaction>();

      
        public void AddTransaction(Transaction nyTransaktion)
        {
            transactions.Add(nyTransaktion);
        }

        public void ShowAll()
        {
            if (transactions.Count == 0)
            {
                Console.WriteLine("Det finns inga transaktioner ännu.");
                return;
            }

            for (int t = 0; t < transactions.Count; t++)
            {
                Console.Write($"#{t}: ");
                transactions[t].ShowInfo();
            }
        }

       
        public decimal CalculateBalance()
        {
            decimal total = 0;
            foreach (var t in transactions)
            {
                total += t.Amount;
            }
            return total;
        }

        
        public bool DeleteTransaction(int index)
        {
            if (index < 0 || index >= transactions.Count)
            {
                return false;
            }

            transactions.RemoveAt(index);
            return true;
        }
    }
}

