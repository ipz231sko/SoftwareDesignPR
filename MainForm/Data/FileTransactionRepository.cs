using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using MainForm.Models;
using MainForm.Interfaces;

namespace MainForm.Data
{
    public class FileTransactionRepository : ITransactionRepository
    {
        private readonly string _filePath = "transactions.json";

        public List<Transaction> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Transaction>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Transaction>>(json, new JsonSerializerOptions
            {
                Converters = { new TransactionJsonConverter() },
                PropertyNameCaseInsensitive = true
            });
        }
        public void Save(List<Transaction> transactions)
        {
            var json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new TransactionJsonConverter() }
            });

            File.WriteAllText(_filePath, json);
        }
    }
}
