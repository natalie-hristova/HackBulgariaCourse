using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public struct Transaction
    {
        public DateTime date;//  CultureInfo("bg-BG");
        
        public bool isPut;
        public double amount;
    }
    class BankAccountBalance
    {
       public static void GetTransactions(string filePath, DateTime startDate, DateTime endDate)
        {
            string[] allText = File.ReadAllLines(filePath);//zema txt s1dyrjanieto 

            Transaction[] currentTransaction = new Transaction[allText.Length];
            string[] str = new string[3]; 
            for (int i = 0; i < allText.Length; i++)
            {
                str = allText[i].Split(';');
                for (int j = 0; j < allText.Length; j++)
                {
                    currentTransaction[j].date = DateTime.ParseExact(str[0], "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                    if (currentTransaction[i].date!= null)
                    {
                        Console.WriteLine(currentTransaction[i].date);
                    }
                    Console.WriteLine(currentTransaction[i].date);
                }
            }
         //NE RABOTIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII

            // get date
           
           // Console.WriteLine(transactions);
        }
        } }