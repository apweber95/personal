using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.GeneratedCode
{
    class ConsoleReciptOutput
    {
        public delegate void Observer(int id, bool valid);
        public Observer run;

        private Database database;

        public ConsoleReciptOutput(Database d)
        {
            run = new Observer(update);
            database = d;
        }

        public void update(int id, bool valid)
        {
            if (valid)
            {
                Transaction transaction = database.getTransaction(id);
                string i = "ID: " + id;
                string date = "Date: " + DateTime.Today.ToString();
                string items = "";
                foreach (Item item in transaction.Items.Values)
                {
                    items += item.ToString() + "\n";
                }
                string total = "Total: $" + transaction.Total;
                Console.WriteLine("\n" + i + "\n" + date + "\n\n" + items + "\n" + total + "\n");
            }
            else
            {
                Console.WriteLine("Invalid transaction");
            }
        }
    }
}
