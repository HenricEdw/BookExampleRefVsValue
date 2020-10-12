using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVsValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new TimeStruct();
            time.Seconds = 10;
            var time2 = new TimeClass();
            time2.Seconds = 10;

            UpdateTime(time);
            UpdateTime(time2);

            Console.WriteLine($"I structen ändras inte ORGINALVÄRDET för att vi har KOPIERAT värdet. {time.Seconds}");
            Console.WriteLine($"I klassen däremot, har värdet ändrats, för vi skickade referensen till time2-instansen {time2.Seconds}");
            Console.Read();
        }

        public static void UpdateTime(TimeStruct time)
        {
            time.Seconds++;
        }

        public static void UpdateTime(TimeClass time)
        {
            time.Seconds++;
        }
    }

    struct TimeStruct
    {
        private int seconds;

        public int Seconds 
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public int CalculateMinutes()
        {
            return seconds / 60;
        }
    }

    class TimeClass
    {
        private int seconds;        

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

    }
}
