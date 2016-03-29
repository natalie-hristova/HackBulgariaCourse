using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Week1;
using System.Drawing;
using System.IO;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {

            //string numberAsString = Console.ReadLine();
            //int n = int.Parse(numberAsString);
            //Factorial.GetNth(n);

            //int factResult2 = Factorial.GetNthWithRecursion(n);
            //Console.WriteLine(factResult2);

            //for (int i = 0; i < 10; i++)
            //{
            //   Console.WriteLine("Hello world!");
            //}

            //Console.WriteLine(Lucas.NthLucas(5));
            //Console.WriteLine(Digitss.CountDigits(35521));
            //Console.WriteLine(Digitss.SumDigits(3145));
            //Console.WriteLine(Digitss.FactorialDigits(1221));
            //Fibunaci.FibNumber(6);
            //Lucas.FirstNLucas(5);
            //Console.WriteLine(HackNumbers.IsHack(21));
            //Console.WriteLine(HackNumbers.NextHack(8031));

            //Console.WriteLine(WordsInString.CountVowels("A nice day to code!"));
            //Console.WriteLine(WordsInString.CountConsonants("Hello World!"));
            // Chars.CharHistogram("Pytttttthon!");

            // Console.WriteLine(Palindromes.PScore(198));
            //Console.WriteLine(IntegerPolindromes.IsIntPalindrome(126661));
            //Console.WriteLine(IntegerPolindromes.GetLargestPalindrome(150));
            //Console.WriteLine(PrimeNumbers.IsPrime(83));
            // PrimeNumbers.ListFirstPrimes(5);
            // StringsAndNumbers.SumOfNumbersInString("dsfdgtr12232434");

            //var elem = Number.NumberToList(1322);
            //return;
            // Number.NumberToList(2134);
            //List<int> list = new List<int>();
            //list.Add(4);
            //list.Add(5);
            //list.Add(3);
            //Console.WriteLine(Number.ListToNumber(list));
            // int[] array = { 1,2,7,3,5,4,-2,0,};
            //Console.WriteLine(IncrDecr.IsIncreasing(array));
            //Console.WriteLine(IncrDecr.IsDecreasing(array));
            //Console.WriteLine(ExtrEl.Min(array));
            //Console.WriteLine(ExtrEl.Max(array));
            //  Console.WriteLine(ExtrEl.NthMin(2,array));
            // Console.WriteLine(ExtrEl.NthMax(2,array));
            // Console.WriteLine(ReverseString.ReverseMe("Natali"));
            // Console.WriteLine(ReverseString.ReverseEveryWord("What a wonderful evening!"));
            //Copies.CopyEveryChar("nat",5);
            //string a = "abcd";
            //string b = "abcdfgd";
            //Console.WriteLine(Anagrams.IsAnagram(a, b));
            //Console.WriteLine(Anagrams.HasAnagramOf(a, b));
            //  Console.WriteLine(StringsAndNumbers.SumOfNumbersInString("a32nbui11"));

            Bitmap bunny = (Bitmap)Image.FromFile("bunny.bmp");


            GreyBmp.ResampleImage(bunny, new Size(4010, 1166), "C:\\Users\\Natalie\\Desktop\\bigbunny.bmp");
            GreyBmp.BlurImage(bunny, "C:\\Users\\Natalie\\Desktop\\blurbunny.bmp");
            GreyBmp.GreyScaleImage(bunny, "C:\\Users\\Natalie\\Desktop\\newbunny.bmp");
            Console.WriteLine(DecodeURL.DecodeUrl("nata%20h%3Axxx %3DNNNNN%2F"));

            //List<int> a = new List<int>() {2,1, 3 };
            //List<int> b = new List<int>() { 1, 2,3};
            //Console.WriteLine(MaxScProduct.MaxScalarProduct(a, b));
            //Console.WriteLine(MaxScProduct.MaxScalarProduct2(a, b));
            //var a = new List<int>() { 1, 2, 3, 4, 5, 56, 2, 7, 8 };
            //var b = new List<KeyValuePair<int, int>>()
            //{
            //    new KeyValuePair<int, int>(2,3),
            //    new KeyValuePair<int, int>(5,6),
            //       new KeyValuePair<int, int>(1,6),
            //};
            // Birthday.BirthdayRanges(a, b);


            //int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };


            // Bombing.MatrixBombing(matrix);

            //List<int> list = new List<int>() { 1, 2, 3,4,5 };
            //ReverseAString.ReverseList(ref list);
            //Rectangle rect = new Rectangle(-3,-3,12,12);
            //Size size = new Size(2,2);
            //InflateRectangle.Inflate(ref rect,size);
            // List<string> list, string searched, out int foundIndex
            //    List<string> list = new List<string> { "today","isss","such"," a","bad", "day"};
            //string search = "such";
            //int foundIndex;
            //ListSearch.TryFindSubstring(list,search,out foundIndex);
            //  string JoinStrings(string separator, params string[] strings)
            //string separator = " aa ";
            //string[] strings = { "today", "is", "such", " a", "bad", "day" };
            //Console.WriteLine(ListSearch.JoinStrings(separator,strings));
            //Console.WriteLine(FactGenerator.GenerateFactorials(5));
            //foreach (var item in FactGenerator.GenerateFactorials(5)) ;
            //   DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Natalie\Desktop");
            //DirectoryTraversal.IterateDirectory(dir);
            //   foreach (var item in DirectoryTraversal.IterateDirectory(dir)) ;
            //List<int> transversal = new List<int>() { 10,4,6 };
            //var family = new List<List<int>> {
            //   new List<int>  { 5, 7, 9 },
            //   new List<int>  { 1, 4, 3 },new List<int>  { 2, 6 } };
            //Console.WriteLine(Transversal.IsTransversal(transversal, family));
            // Console.WriteLine(Friday13.UnfortunateFridays(2015, 2017));
            // DateSums.PrintDatesWithGivenSum(2015,10);
            //HackersTime.HackerTime();
            //var list = new List <int> { 1, 4, 2, 1, 4, 4, 4 };
            //Console.WriteLine(MaxSpan.MaxiSpan(list));
            //DateTime[] startDate = new DateTime[] {
            //    new DateTime(2015, 10, 1,10,00,25),
            //    new DateTime(2015, 10, 1,10,30,25),
            //    new DateTime(2015, 10, 1,11,05,25),
            //    //new DateTime(2015, 10, 1),
            //    //new DateTime(2015, 10, 5)
            //};

            //TimeSpan[] durations = new TimeSpan[] {
            //    new TimeSpan(2, 10, 1),
            //    new TimeSpan(3, 10, 2),
            //    new TimeSpan(2, 10, 3),
            //    //new TimeSpan(5, 10, 4),
            //    //new TimeSpan(2, 10, 5)
            //};

            // Appointments.FindIntersectingAppointments(startDate, durations);

            //PointF[] pointsa = new PointF[] {
            //     new PointF(0,0), new PointF(3,0),
            //    new PointF(3,3)
            //};
            //PointF[] points = new PointF[] {
            //     new PointF(0,0), new PointF(3,0),
            //    new PointF(4,3), new PointF(2,5),
            //    new PointF(0,3)
            //};
            // PolygonCircumference.CalcCircumference(points);
            // PolygonCircumference.CalcArea(points);          



            //Calendar.PrintCalendar(5, 2016, new CultureInfo("bg-BG"));
            //DateTime da = new DateTime(1994,05,14,4,30,0);
            //Console.WriteLine(ClockAngle.GetClockHandsAngle2(da));
            //   RandomNumbers.GenerateRandomMatrix(3, 3, @" C:\Users\Natalie\Desktop\Nata.txt");

            //DateTime dt = new DateTime();
            //BankAccountBalance.Money(@" C:\Users\Natalie\Desktop\Pesho.txt");
            string hack = (@"C:\Users\Natalie\Desktop\pesho.txt");
            DateTime startDate = new DateTime(2015,3,30);
            DateTime endDate = new DateTime(2015, 4, 30);
          BankAccountBalance.GetTransactions(hack,startDate,endDate);
        }
    }
}
