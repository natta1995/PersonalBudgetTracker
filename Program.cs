namespace PersonalBudgetTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vi skapar en ny budget igenom vår klass BudgetManager som vi för enkelhetens skull kallar för "budget"
            
            BudgetManager budget = new BudgetManager();

            // Så länge som running = true så körs wileloopen nedan.
            bool running = true;

            // Vi kör en whileloop som visar en meny och låter användaren välja olika alternativ.
            // Den håller liv i applicationen tills användaren har valt att avsluta(5). På så sätt kan vi fortsätta efter vi gjort ett alternativ.

            while (running)
            {
                // Vi skriver ut valen användaren kan göra i konsollen

                Console.WriteLine("\n--- Personal Budget Tracker ---");
                Console.WriteLine("1. Lägg till transaktion");
                Console.WriteLine("2. Visa alla transaktioner");
                Console.WriteLine("3. Visa total balans");
                Console.WriteLine("4. Ta bort transaktion");
                Console.WriteLine("5. Avsluta");
                Console.Write("Välj ett alternativ: ");

                // Vi tar strängvärdet (allt i konsollen är string som i så fall får omvandlas, men inte här. vi tar bara värdet ifrån konsollen och sätter det som "choise"
                string? choice = Console.ReadLine();

                // choice = ett nummer (men numret är en stärng, därför jämför vi det i switch.
                // vi tar in värdet av choice i vår switch- se under.

                switch (choice)
                {
                    // Vi jämför vårt strängnummer med de olika casen och kör koden beroende på vårt val

                    // Lägg till transaktion
                    case "1":
                        Console.Write("Beskrivning: "); // Be om input
                        string desc = Console.ReadLine(); // ta emot input 

                        Console.Write("Belopp (positivt = inkomst, negativt = utgift): "); // Be om input
                        decimal amount = Convert.ToDecimal(Console.ReadLine());     // Ta emot input 

                        Console.Write("Kategori: ");
                        string category = Console.ReadLine();

                        Console.Write("Datum (t.ex. 2025-10-16): ");
                        string date = Console.ReadLine();

                        Transaction ny = new Transaction(desc, amount, category, date);
                        budget.AddTransaction(ny);
                        Console.WriteLine("Transaktionen har lagts till.");
                        break;


                    // Visa alla transaktioner
                    case "2":
                        budget.ShowAll();
                        break;

                    // Visa total balans
                    case "3":
                        Console.WriteLine($"Total balans: {budget.CalculateBalance()}");
                        break;

                    // Ta bort transaktion
                    case "4":
                        Console.Write("Ange index att ta bort: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        bool removed = budget.DeleteTransaction(index);
                        Console.WriteLine(removed ? "Transaktionen togs bort." : "Ogiltigt index.");
                        break;

                    // Exit, (avsluta loopen)
                    case "5":
                        running = false;
                        Console.WriteLine("Programmet avslutas...");
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }
    }
}
