using System;
namespace PharmaTest
{
    public class Date
    {
        private int day;
        private int month;
        public int Year { get; set; }

        public Date(int day, int month, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public int Month
        {
            get { return month; }
            set{
                if(value > 0 && value <= 12)
                {
                    month = value;
                } else {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Day
        {
            get{ return day;}
            set {
                int[] daysPerMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
                if(value > 0 && value <= daysPerMonth[ Month])
                {
                    day = value;
                } else if (month == 2 && value == 29 && ((Year % 400 == 0 || (Year % 4 == 0 && Year % 100 !=0))))
                {
                    day = value;
                } else {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}