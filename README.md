# Фінансовий планувальник

## Функціонал програми
WindowsForms застосунок для планування подобових транзакцій та контролю бюджету:
  - Додавання транзакцій (дохід/витрата)
  - Вибір категорії та підкатегорії
  - Фільтрування транзакцій за типом, категорією, підкатегорією, датою
  - Редагування та видалення транзакцій
  - Звітність: загальні доходи/витрати/баланс
  - Статистика транзакційЖ середні, найбільші, за категоріями
  - Збереження звіту у файл *.txt

## Старт проекту
  1. Відкрийте .sln-файл у Visual Studio
  2. Оберіть конфігурацію  Debug або Release
  3. Натисніть F5 або кнопку Start для запуску програми
Дані зберігаються у JSON-файлі transactions.json, який автоматично створюється при першому запуску за шляхом: ```MainForm\bin\Debug\transactions.json```

## Programming Principles
  1. **Single Responsibility Principle (SRP)**
      - [`ReportService`](https://github.com/ipz231sko/SoftwareDesignPR/blob/feature/add-report-service/MainForm/Services/ReportService.cs) - відповідає лише за обчислення статистики.
      - [`FilterService`](https://github.com/ipz231sko/SoftwareDesignPR/blob/feature/add-report-service/MainForm/Services/FilterService.cs) - відповідає лише за фільтрацію
      - [`BudgetService`](https://github.com/ipz231sko/SoftwareDesignPR/blob/feature/add-report-service/MainForm/Services/BudgetService.cs) - відповідає лише за обробку транзакцій
  2. **Open/Closed Principle (OCP)**
      - Форма `TransactionForm` була доповнена логікою фільтрації через `FilterService`, без змін її початкової логіки.
  3. **Liskov Substitution Principle (LSP)**
      - Клас [`Income`](https://github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/Models/Income.cs) та [`Expense`](https://github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/Models/Expence.cs) можна використовувати замість [`Transaction`](https://github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/Models/Transaction.cs) без порушення логіки, наприклад у [`ReportService`](https://github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/Services/ReportService.cs).
  4. **DRY (Don’t Repeat Yourself)**
      - Повторювана логіка обробки категорій і підкатегорій винесена в окремі методи, наприклад, [ResetSubcategoryFilter](github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/TransactionListForm.cs#L142-L145)
  5. **KISS ((Keep It Simple, Stupid))**
      - Форми `AddTransactionForm`, `TransactionListForm`, `ReportForm` мають чіткий, лаконічний інтерфейс.
      - Додавання транзакцій відбувається через просту перевірку та створення об’єкта `Income` або `Expense` без складних умов або логіки.
## Design Patterns
  1. **Service Pattern**
      - `FilterService.cs`, `ReportService.cs` — інкапсуляція логіки окремо від UI, забезпечує перевикористання та тестованість.
  2. **Factory-like Pattern**
      - У AddTransactionForm.cs об’єкт Transaction створюється як [Income](github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/AddTransactionForm.cs#L71-L81) або [Expense](github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/AddTransactionForm.cs#L82-L92) на основі типу, вибраного користувачем.
  3. **DTO / Data Model Separation**
      - `Transaction.cs`, `Income.cs`, `Expense.cs` — зберігають лише дані, не містять UI-логіки.
## Refactoring Techniques
  1. **Extract Method** - метод [DisplayStatisticsTable()](github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/ReportForm.cs#L36-L64) виділено з `DisplayReport()` у ReportForm.cs.
  2. **Encapsulate Field** - eсі поля форм оголошено приватними (private) з контролем доступу через UI.
  3. **Replace Conditional with Polymorphism** — замість використання умов для визначення типу транзакції, використано класи-нащадки `Income` та `Expense`, що дозволяє працювати з колекцією `Transaction` поліморфно без перевірок типу.
  4. **Split Responsibilities** - Логіка фільтрації, обчислень та UI розділена по окремих класах: `FilterService`, `ReportService`, форми.
  5. **Remove Dead Code** - після збереження транзакції в `AddTransactionForm` очищується форма і закривається — зайвий код видалено.
## Статистика (ReportService)
Файл [ReportService.cs](https://github.com/ipz231sko/SoftwareDesignPR/blob/main/MainForm/Services/ReportService.cs):
  - Підрахунок транзакцій (загальна, дохід, витрата): `GetTransactionCount()`, `GetIncomeTransactionCount()`, `GetExpenseTransactionCount()`
  - Середні витрати / доходи: `GetAverageExpense()`, `GetAverageIncome()`
  - Найбільша витрата / дохід: `GetLargestExpense()`, `GetLargestIncome()`
  - Витрати за категоріями: `GetExpenseByCategory()`
  - Витрати за категоріями + підкатегоріями: `GetExpenseByCategoryAndSubcategory()`

![Знімок екрана 2025-05-19 164759](https://github.com/user-attachments/assets/c8e4d893-67ed-4fc5-abee-82a1950c9aeb)
