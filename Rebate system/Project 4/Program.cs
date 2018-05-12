using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace Project_4
{

    static class Program
    {
        public static GeneratedCode.CashierInputView cashierView;
        public static GeneratedCode.uxReturnList customerView;
        public static GeneratedCode.RebateInputView rebateView;
        public static GeneratedCode.ConsoleInput consoleInput;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up model
            Database dataBase = new Database();
            ModelI controllerModel = dataBase;
            Database viewModel = dataBase;

            // Set up controllers
            SalesManager transactionController = new SalesManager(controllerModel);
            SalesManager trasactionController_C = new SalesManager(controllerModel);
            ReturnsManager returnController = new ReturnsManager(controllerModel);
            RebateManager rebateController = new RebateManager(controllerModel);

            // Set up output
            GeneratedCode.ReciptOutputView reciptOutput = new GeneratedCode.ReciptOutputView(dataBase);
            GeneratedCode.RebateOutputView rebateOutput = new GeneratedCode.RebateOutputView(dataBase);
            GeneratedCode.uxForm genRebateOutput = new GeneratedCode.uxForm(dataBase);
            GeneratedCode.ConsoleReciptOutput consoleOutput = new GeneratedCode.ConsoleReciptOutput(dataBase);

            // Set up input views
            cashierView = new GeneratedCode.CashierInputView(transactionController.transHandler, transactionController.itemHandler, transactionController.endTransaction);
            customerView = new GeneratedCode.uxReturnList(returnController.returnItem, returnController.endReturn);
            rebateView = new GeneratedCode.RebateInputView(rebateController.enterRebate, rebateController.genRebate);
            consoleInput = new GeneratedCode.ConsoleInput(trasactionController_C.transHandler, trasactionController_C.itemHandler, trasactionController_C.endTransaction);

            // Add observers
            transactionController.register(reciptOutput.run);
            trasactionController_C.register(consoleOutput.run);
            returnController.register(reciptOutput.run);
            rebateController.register(rebateOutput.run, genRebateOutput.run);           

            // Set up and run application
            Application.EnableVisualStyles();

            //runs forms on own threads
            new Thread(Driver1).Start();
            new Thread(Driver2).Start();
            new Thread(Driver3).Start();
            new Thread(Driver4).Start();
        }

        //set up treading
        static void Driver1()
        {      
            Application.Run(cashierView);
        }
        static void Driver2()
        {       
            Application.Run(customerView);
        }
        static void Driver3()
        {
            Application.Run(rebateView);
        }
        static void Driver4()
        {
            consoleInput.run();
        }
    }
}
