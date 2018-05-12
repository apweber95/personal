using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.GeneratedCode
{
    class ConsoleInput
    {
        private SalesManager.TransactionHandler transHandler;
        private SalesManager.ItemHandler itemHandler;
        private SalesManager.EndTransactionHandler endTransaction;
        private int id = 1000;

        public ConsoleInput(SalesManager.TransactionHandler h, SalesManager.ItemHandler i, SalesManager.EndTransactionHandler e)
        {
            transHandler = h;
            itemHandler = i;
            endTransaction = e;
        }
        public void run()
        {
            while (true)
            {
                Console.WriteLine("New transaction (enter)");
                Console.ReadLine();
                transHandler(id); id++;
                bool transaction = true;
                while (transaction)
                {
                    Console.Write("Enter an (i)tem or (e)nd transaction (id: " + (id - 1) + "): ");
                    string input = Console.ReadLine();
                    if (input == "i" || input == "I")
                    {
                        try
                        {
                            Console.Write("Item Name:");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            float price = float.Parse(Console.ReadLine());
                            Console.Write("Qty: ");
                            int qty = int.Parse(Console.ReadLine());
                            itemHandler(qty, price, name);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid Input");
                        }
                    }
                    else if (input == "e" || input == "E")
                    {
                        endTransaction();
                        transaction = false;
                    }
                }
            }

        }

    }
}
