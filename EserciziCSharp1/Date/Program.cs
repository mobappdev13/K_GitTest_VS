using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{    
    class Program
    {
        //https://msdn.microsoft.com/en-us/library/system.datetime.now(v=vs.110).aspx
        static void Main(string[] args)
        {
            //DateTime localDate = DateTime.Now;
            DateTime date1 = new DateTime(1961, 6, 19, 11, 11, 0);
            Console.WriteLine();
            Console.WriteLine($"MY  BD was  {date1.ToString()}");
            Console.WriteLine();
            //formati
            DateTime date2 = new DateTime(2017, 10, 20);

        
            Console.WriteLine("Today is MMMM dd, yyyy" + " " + date2.ToString("MMMM dd, yyyy") + ".");
            Console.WriteLine();
            Console.WriteLine();
            //DateTimeOffset date3 = new DateTimeOffset(2017, 10, 20, 12, 38, 16, TimeSpan.Zero);
            //Console.WriteLine("The current date and time: {0:MM/dd/yy H:mm:ss zzz}",date3);
            //

            Console.WriteLine();
            string[] dateValues = {"30-12-2011", "12-30-2011", "30-12-11", "12-30-11" };

            string pattern1 = "MM-dd-yy";
            //string pattern2 = "yy-MM-yy";// erroneo
            string pattern2 = "yy-MM-dd";
            string pattern3 = "dd-MM-yyyy";

            DateTime parsedDate;
            Console.WriteLine("con pattern 1 MM-dd-yy");
            foreach (var date in dateValues)
            {

                //Console.WriteLine((DateTime.TryParseExact(date, pattern3, null, System.Globalization.DateTimeStyles.None,out parsedDate)));
                if (DateTime.TryParseExact(date, pattern1, null, System.Globalization.DateTimeStyles.None, out parsedDate))
                {
                    Console.WriteLine("***Converted con '{0}' to {1:d}.",date, parsedDate);
                }
                else
                {
                    Console.WriteLine("unable to convert  '{0}'  to a date and time.", date);
                }
               
            }
            Console.WriteLine("***********************************");
            Console.WriteLine("con pattern 2 yy-MM-dd");
            foreach (var date in dateValues)
            {

                //Console.WriteLine((DateTime.TryParseExact(date, pattern2, null, System.Globalization.DateTimeStyles.None,out parsedDate)));
                if (DateTime.TryParseExact(date, pattern2, null, System.Globalization.DateTimeStyles.None, out parsedDate))
                {
                    Console.WriteLine("***Converted con  '{0}' to {1:d}.", date, parsedDate);

                }
                else
                {
                    Console.WriteLine("unable to convert  '{0}'  to a date and time.", date);
                }
            }
                Console.WriteLine("con pattern3 dd-MM-yyyy");
                Console.WriteLine("***********************************");
                foreach (var date in dateValues)
                {

                    //Console.WriteLine((DateTime.TryParseExact(date, pattern2, null, System.Globalization.DateTimeStyles.None,out parsedDate)));
                    if (DateTime.TryParseExact(date, pattern3, null, System.Globalization.DateTimeStyles.None, out parsedDate))
                    {
                        Console.WriteLine("***Converted con  '{0}' to {1:d}.", date, parsedDate);

                    }
                    else
                    {
                        Console.WriteLine("unable to convert  '{0}'  to a date and time.", date);
                    }
                }
           
            //

            Console.WriteLine("altro con DateTime");
            Console.WriteLine("***********************************");
            String[] formats = {"d", "G", "MM/yyyy", @"MM\/dd\/yyyy HH:mm","yyyyMMdd" };
            DateTime dateBirthDay = new DateTime(2017, 6, 19, 13, 31, 17);
            foreach (var format in formats)
            {
                Console.WriteLine(" format  {0}: {1}", format, dateBirthDay.ToString(format));

            }
            
            Console.ReadLine();


            Console.WriteLine("altro con DateTime");
            //DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            DateTime currTimeAndDate = DateTime.Now;
            Console.WriteLine("Today's time and date is {0}\n", currTimeAndDate);
            Console.WriteLine("Enter a date: gg/mm/YYYY ");
            DateTime userDateTime;
            while (true)
            {
                if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
                {
                    Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);

                    break;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value.");
                }

            }
            Console.ReadLine();
            //public TimeSpan Subtract( DateTime value)
            //)
            //            }

        }
    }
}

//public class Example
//{
//    public static void Main()
//    {
//        string[] dateValues = { "30-12-2011", "12-30-2011",
//                              "30-12-11", "12-30-11" };
//        string pattern = "MM-dd-yy";
//        DateTime parsedDate;

//        foreach (var dateValue in dateValues)
        //{
            
        //}
//    }
//}
////
//DateTime localDate = DateTime.Now;
//String[] cultureNames = { "en-US", "en-GB", "fr-FR",
//                                "de-DE", "ru-RU" };

//      foreach (var cultureName in cultureNames) {
//         var culture = new CultureInfo(cultureName);
//Console.WriteLine("{0}: {1}", cultureName,
//                           localDate.ToString(culture));
//      }
//DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
//Console.WriteLine(date1.ToString());

//      // Get date-only portion of date, without its time.
//      DateTime dateOnly = date1.Date;
//// Display date using short date string.
//Console.WriteLine(dateOnly.ToString("d"));
//      // Display date using 24-hour clock.
//      Console.WriteLine(dateOnly.ToString("g"));
//      Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));   