using UnityEngine;

namespace SMercenaries.Global
{
    public class Date : MonoBehaviour
    {
        public Date() : this(Calendar.CalInstance.GetFutureDate(futureDay: 1)) { }

        public Date(Date date)
        {
            this.Day = date.Day;
            this.Week = date.Week;
            this.Month = date.Month;
            this.Year = date.Year;
        }
        public Date(int day, int week, int month, int year)
        {
            this.Day = day;
            this.Week = week;
            this.Month = month;
            this.Year = year;
        }



        [SerializeField] public int Day { get; private set; }
        [SerializeField] public int Week { get; private set; }
        [SerializeField] public int Month { get; private set; }
        [SerializeField] public int Year { get; private set; }


        public void AdjustCurrentDate(int days = Globals.daysInWeek, int weeks = 0, int months = 0, int years = 0)
        {
            // sets the day and the automatic turns over the week and month from that day

            this.Day += System.Math.Abs(days);
            this.Week += System.Math.Abs(weeks);
            this.Month += System.Math.Abs(months);
            this.Year += System.Math.Abs(years);

            this.Week += (int)System.Math.Floor((decimal)this.Day / Globals.daysInWeek); //I know int / int gives the floor quotient, but I just don't care.
            this.Day = this.Day % Globals.daysInWeek;

            this.Month += (int)System.Math.Floor((decimal)this.Week / Globals.weeksInMonth);
            this.Week = this.Week % Globals.weeksInMonth;

            this.Year += (int)System.Math.Floor((decimal)this.Month / Globals.monthsInYear);
            this.Month = this.Month % Globals.monthsInYear;
        }



        public Date GetFutureDate(int futureDay = 1, int futureWeek = 0, int futureMonth = 0, int futureYear = 0)
        {
            // 
            futureDay = System.Math.Abs(futureDay) + this.Day;
            futureWeek = System.Math.Abs(futureWeek) + this.Week;
            futureMonth = System.Math.Abs(futureMonth) + this.Month;
            futureYear = System.Math.Abs(futureYear) + this.Year;

            futureWeek += (int)System.Math.Floor((decimal)futureDay / Globals.daysInWeek);
            futureDay = futureDay % Globals.daysInWeek;

            futureMonth += (int)System.Math.Floor((decimal)futureWeek / Globals.weeksInMonth);
            futureWeek = futureWeek % Globals.weeksInMonth;

            futureYear += (int)System.Math.Floor((decimal)futureMonth / Globals.monthsInYear);
            futureMonth = futureMonth % Globals.monthsInYear;

            Date futureDate = new(futureDay, futureWeek, futureMonth, futureYear);
            return futureDate;
        }

        public Date GetPastDate(int pastDay = 1, int pastWeek = 0, int pastMonth = 0, int pastYear = 0)
        {
            pastDay = this.Day - (int)System.Math.Abs((decimal)pastDay);
            pastWeek = this.Week - (int)System.Math.Abs((decimal)pastWeek);
            pastMonth = this.Month - (int)System.Math.Abs((decimal)pastMonth);
            pastYear = this.Year - (int)System.Math.Abs((decimal)pastYear);

            while (pastDay < 0)
            {
                pastDay += Globals.daysInWeek;
                pastWeek--;
            }
            while (pastWeek < 0)
            {
                pastWeek += Globals.weeksInMonth;
                pastMonth--;
            }
            while (pastMonth < 0)
            {
                pastMonth += Globals.monthsInYear;
                pastYear--;
            }
            return new Date(pastDay, pastWeek, pastMonth, pastYear);

        }
        //public bool isToday()
        //{
        //    if(daysInThis() - Calendar.CalInstance.daysInThis() == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool isFuture()
        //{
        //    if (daysInThis() - Calendar.CalInstance.daysInThis() < 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}


        public int daysInThis()
        {
            return (((((this.Year * Globals.monthsInYear) + this.Month) * Globals.weeksInMonth) + this.Week) * Globals.daysInWeek) + this.Day;
        }


        public int[] getTimeToThisDate()   // Return int[5] in format: Future?, Years, Months, Weeks, Days
                                           // Future? == 1 -> Past Date, Future? == 0 -> Today, Future? == -1 -> Future Date
        {
            int[] YMWDF = new int[5];

            int total = Calendar.CalInstance.daysInThis() - daysInThis();
            if (total > 0)
            {
                YMWDF[0] = 1;
            }
            else if (total == 0)
            {
                YMWDF[0] = 0;
            }
            else if (total < 0) {
                YMWDF[0] = -1;
            }
            total = Mathf.Abs(total);

            YMWDF[4] = total % Globals.daysInWeek;
            total = total / Globals.daysInWeek;

            YMWDF[3] = total % Globals.weeksInMonth;
            total = total / Globals.weeksInMonth;

            YMWDF[2] = total % Globals.monthsInYear;
            total = total / Globals.monthsInYear;

            YMWDF[1] = total;
            return YMWDF;
        }
    }
}
