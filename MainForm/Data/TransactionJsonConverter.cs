using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MainForm.Data
{
    public class TransactionJsonConverter : System.Text.Json.Serialization.JsonConverter<Transaction>
    {
        public override Transaction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var type = root.GetProperty("Type").GetString();

                Transaction transaction;
                if (type == "Income")
                {
                    transaction = new Income();
                }
                else if (type == "Expense")
                {
                    transaction = new Expense();
                }
                else
                {
                    throw new NotSupportedException($"Unsupported transaction type: {type}");
                }

                transaction.Date = root.GetProperty("Date").GetDateTime();
                transaction.Amount = root.GetProperty("Amount").GetDecimal();
                transaction.Category = root.GetProperty("Category").GetString();
                transaction.Description = root.GetProperty("Description").GetString();

                return transaction;
            }
        }
        public override void Write(Utf8JsonWriter writer, Transaction value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Type", value.Type);
            writer.WriteString("Date", value.Date);
            writer.WriteNumber("Amount", value.Amount);
            writer.WriteString("Category", value.Category);
            writer.WriteString("Description", value.Description);
            writer.WriteEndObject();
        }
    }
}
