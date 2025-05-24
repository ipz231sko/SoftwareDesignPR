﻿using MainForm.Models;
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
        private static readonly Dictionary<string, Func<Transaction>> TransactionFactories =
            new Dictionary<string, Func<Transaction>>(StringComparer.OrdinalIgnoreCase)
            {
                { "Дохід", () => new Income() },
                { "Витрата", () => new Expense() }
            };

        public override Transaction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                var type = root.GetProperty("Type").GetString();

                if (!TransactionFactories.TryGetValue(type, out var factory))
                    throw new NotSupportedException($"Unsupported transaction type: {type}");

                var transaction = factory();

                transaction.Date = root.GetProperty("Date").GetDateTime();
                transaction.Amount = root.GetProperty("Amount").GetDecimal();
                transaction.Category = root.GetProperty("Category").GetString();
                transaction.Subcategory = root.TryGetProperty("Subcategory", out var subcatProp)
                    ? subcatProp.GetString()
                    : string.Empty;
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
            writer.WriteString("Subcategory", value.Subcategory);
            writer.WriteString("Description", value.Description);
            writer.WriteEndObject();
        }
    }
}
