using System;

namespace POO2.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract() { }
        public HourContract(DateTime date,double value,int hour)
        {
            Date = date;
            ValuePerHour = value;
            Hour = hour;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hour;
        }
    }
}
