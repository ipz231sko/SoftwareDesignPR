using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Data
{
    public static class CategoryData
    {
        public static List<string> IncomeCategories { get; } = new List<string>
        {
            "Зарплата",
            "Інші доходи",
            "Вхідний переказ"
        };

        public static Dictionary<string, List<string>> ExpenseCategories { get; } = new Dictionary<string, List<string>>
        {
            { "Їжа та напої", new List<string>() },
            { "Комунальні та абонплата", new List<string> { "Орендна плата", "Рахунок за воду", "Рахунок за мобільний зв'язок", "Рахунок за електроенергію", "Рахунок за газ", "Рахунок за телебачення", "Рахунок за Інтернет", "Інші рахунки за комунальні послуги" } },
            { "Покупки", new List<string> {"Особисті речі", "Побутові речі", "Макіяж" } },
            { "Сім'я", new List<string> { "Домашнє обслуговування", "Побутові послуги", "Домашні тварини"} },
            { "Транспорт", new List<string> { "Обслуговування авто" } },
            { "Здоров'я", new List<string> { "Медична перевірка", "Фітнес"} },
            { "Освіта", new List<string>() },
            { "Розваги", new List<string> { "Сервіс трансляції", "Смішні гроші"} },
            { "Подарунки та пожертвування", new List<string>() },
            { "Страховки", new List<string>() },
            { "Інвестиції", new List<string>() },
            { "Їнші витрати", new List<string>() },
            { "Виххідний переказ", new List<string>() }
        };
    }
}
