using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BudgetConsole
{
    class Expensesreport
        
    {
        public Expensesreport()
        {
            expenses = new List<float>();
        }

        public void AddExpense(float expense)
        {
            expenses.Add(expense);
        }

        public List<float> expenses;
    }
}
