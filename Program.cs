namespace PersonalBudgetTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vi skapar en ny budget igenom vår klass "BudgetManager" som vi för enkelhetens skull kallar för "budget"
            
            BudgetManager budget = new BudgetManager();

            // Så länge som running = true så körs wileloopen nedan.

            bool running = true;

            // Vi kör en whileloop som visar en meny och låter användaren välja olika alternativ.
            // Den håller liv i applikationen tills användaren väljer att avsluta(case: 5). På så sätt kan vi fortsätta, efter vi valt ett case i menyn.

            while (running)
            {
                // Vi skriver ut valen användaren kan göra i konsollen (Menyn):
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n--- Personal Budget Tracker ---\n");
                Console.WriteLine("[1] + Lägg till transaktion ");
                Console.WriteLine("[2] # Visa alla transaktioner ");
                Console.WriteLine("[3] $ Visa total balans ");
                Console.WriteLine("[4] - Ta bort transaktion ");
                Console.WriteLine("[5] X Avsluta \n");
                Console.WriteLine("------------------------------\n");
                Console.Write("Välj ett alternativ: ");

                // Vi tar stringvärdet (allt i konsollen är string som i så fall får omvandlas, men inte här. vi tar bara värdet ifrån konsollen och sätter det som "choise"
                
                string? choice = Console.ReadLine();

                // choice = ett nummer (men numret är en stärng, därför jämför vi det i switch alternativen som är siffror men i en string.
                // vi tar in värdet av choice i vår switch:

                switch (choice)
                {
                    // Vi jämför vårt strängnummer med de olika casen och kör koden beroende på användarens val

                    // Lägg till transaktion
                    case "1":
                        Console.Write("Beskrivning: "); // Be om input
                        string desc = Console.ReadLine(); // ta emot input 

                        Console.Write("Belopp (inkomst + , negativt -): "); // Be om input
                        decimal amount = Convert.ToDecimal(Console.ReadLine());     // Ta emot input osv

                        Console.Write("Kategori: ");
                        string category = Console.ReadLine();

                        Console.Write("Datum (t.ex. 2025-10-16): ");
                        string date = Console.ReadLine();

                        // Skapar transaktion och lägger i lista
                        Transaction ny = new Transaction(desc, amount, category, date);
                        budget.AddTransaction(ny);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Transaktionen har lagts till.");
                        Console.ResetColor();
                        break;


                    // Visa alla transaktioner
                    case "2":
                        budget.ShowAll();
                        break;


                    // Visa total balans
                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Total balans: {budget.CalculateBalance()}");
                        Console.ResetColor();
                        break;


                    // Ta bort transaktion
                    case "4":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Ange index att ta bort: ");
                        int index = Convert.ToInt32(Console.ReadLine()); // omvandlar string till int
                        bool removed = budget.DeleteTransaction(index); // delete transaktionen med den indexen OM vilkoren (se BudgetManager.cs)
                        Console.WriteLine(removed ? "Transaktionen togs bort." : "Ogiltigt index.");
                        Console.ResetColor();
                        break;


                    // Exit, (avsluta loopen)
                    case "5":
                        running = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Programmet avslutas...");
                        Console.ResetColor();
                        break;


                    // Default som fångar upp ifall inte valet matchar något av ovanstående.
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
