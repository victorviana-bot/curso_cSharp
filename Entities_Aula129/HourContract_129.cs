using System;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities_Aula129
{
    class HourContract_129
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract_129()
        {
        }

        public HourContract_129(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }



    }
}
