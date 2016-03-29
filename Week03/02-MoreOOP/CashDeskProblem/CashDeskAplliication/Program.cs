using CashDesk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskAplliication
{
    class Program
    {
        static void PrintHelp()
        {


            Console.WriteLine("takebill <number> - adds a bill with value <number> to the CashDesk");
            Console.WriteLine("takebatchbill <number1> <number2> ... - adds a batch of bills to the CashDesk");
            Console.WriteLine("inspect - prints detailed information of the money in the CashDesk");
            Console.WriteLine("total - prints the total money in the cash desk");
            Console.WriteLine("exit - exits the application");

        }

        static void Main(string[] args)
        {
            CashDesk.Bill a = new CashDesk.Bill(5);
            CashDesk.Bill b = new CashDesk.Bill(5);
            CashDesk.Bill c = new CashDesk.Bill(10);

            List<Bill> batch = new List<Bill>() { a, b, c };
            BatchBill batchbill = new BatchBill(batch);

            Dictionary<int, int> billCashDesk = new Dictionary<int, int>();
            CashDesk.CashDesk desk = new CashDesk.CashDesk();

            bool exit = false;
            Console.WriteLine("CashDesk application\n");
            Console.WriteLine("/help - for the full list of commands\n");

            StringBuilder userInput = new StringBuilder();

            while (!exit)
            {

                userInput.Append(Console.ReadLine());


                if (userInput.ToString().Contains("takebill"))
                {
                    userInput.Replace("takebill", "");
                    int amount = -1;
                    if (int.TryParse(userInput.ToString(), out amount))
                    {
                        desk.TakeMoney(new Bill(amount));
                    }
                    else
                        Console.WriteLine("ERROR: Invalid amount!");

                }

                else if (userInput.ToString().Contains("takebatchbill"))
                {
                    userInput.Replace("takebatchbill", "");
                    List<Bill> listOfBills = new List<Bill>();

                    string[] arrayOfBills = userInput.ToString().Split(' ');
                    int amount = -1;
                    foreach (var bill in arrayOfBills)
                    {
                        if (int.TryParse(bill, out amount))
                        {

                            listOfBills.Add(new Bill(amount));
                        }
                    }

                    if (listOfBills.Count == 0)
                        Console.WriteLine("ERROR: Invalid amount!");
                    else
                        desk.TakeMoney(new BatchBill(listOfBills));

                }
                else if (userInput.ToString().Contains("total"))
                {
                    Console.WriteLine("${0} ", desk.Total());
                }
                else if (userInput.ToString().Contains("inspect"))
                {
                    if (desk.Total() != 0)
                        desk.Inspect();
                    else
                        Console.WriteLine("The Cash Desk is empty right now.");

                }
                else if (userInput.ToString().Contains("exit"))
                {
                    exit = true;
                }
                else if (userInput.ToString().Contains("/help"))
                {
                    CashDeskAplliication.Program.PrintHelp();
                }
                else
                    Console.WriteLine("ERROR: Invalid command!");

                userInput.Clear();
            }
        }
    }
}



