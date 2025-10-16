# Klassdiagram - Personal Budget Tracker
```mermaid

classDiagram
	class Transaction {
		+string Description
        +decimal Amount  // positivt = inkomst, negativt = utgift
        +string Category // t.ex. "Mat", "Transport", "Hyra", "Inkomst"
        +string Date     // t.ex. "2025-10-10"
        +void ShowInfo()
	}
	class BudgetManager {
		 -List~Transaction~ transactions
        +void AddTransaction(Transaction t)
        +void ShowAll()
        +decimal CalculateBalance()
        +bool DeleteTransaction(int index)
	}

    BudgetManager "1" *-- "many" Transaction : innehåller
