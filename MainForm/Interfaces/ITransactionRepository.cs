using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Interfaces
{
    public interface ITransactionRepository
    {
        List<Transaction> Load();
        void Save(List<Transaction> transactions);
    }
}
