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


        public void AdjustCurrentDate(int days = Globals.WeekLength , int weeks = 0, int months = 0, int years = 0)
        {
            // sets the day and the automatic turns over the week and month from that day

            this.Day += System.Math.Abs(days);
            this.Week += System.Math.Abs(weeks);
            this.Month += System.Math.Abs(months);
            this.Year += System.Math.Abs(years);

            this.Week += (int)System.Math.Floor((decimal)this.Day / Globals.WeekLength); //I know int / int gives the floor quotient, but I just don't care.
            this.Day =  this.Day % Globals.WeekLength;

            this.Month += (int)System.Math.Floor((decimal)this.Week / Globals.MonthLength);
            this.Week = this.Week % Globals.MonthLength;

            this.Year += (int)System.Math.Floor((decimal)this.Month / Globals.YearLength);
            this.Month = this.Month % Globals.YearLength;
        }



        public Date GetFutureDate(int futureDay = 1, int futureWeek = 0, int futureMonth = 0, int futureYear = 0)
        {
            // 
            futureDay = System.Math.Abs(futureDay) + this.Day;
            futureWeek = System.Math.Abs(futureWeek) + this.Week;
            futureMonth = System.Math.Abs(futureMonth) + this.Month;
            futureYear = System.Math.Abs(futureYear) + this.Year;

            futureWeek += (int)System.Math.Floor((decimal)futureDay / Globals.WeekLength);
            futureDay = futureDay % Globals.WeekLength;

            futureMonth += (int)System.Math.Floor((decimal)futureWeek / Globals.MonthLength);
            futureWeek = futureWeek % Globals.MonthLength;

            futureYear += (int)System.Math.Floor((decimal)futureMonth / Globals.YearLength);
            futureMonth = futureMonth % Globals.YearLength;

            Date futureDate = new (futureDay, futureWeek, futureMonth, futureYear);
            return futureDate;
        }
        public Date GetPastDate(int pastDay = 1, int pastWeek = 0, int pastMonth = 0, int pastYear = 0)
        {
            pastDay = this.Day - System.Math.Abs(pastDay);
            pastWeek = this.Week - System.Math.Abs(pastWeek);
            pastMonth = this.Month - System.Math.Abs(pastMonth);
            pastYear = this.Year - System.Math.Abs(pastYear);

            while (pastDay < 0)
            {
                pastDay += Globals.WeekLength;
                pastWeek--;
            }
            while (pastWeek < 0)
            {
                pastWeek += Globals.MonthLength;
                pastMonth--;
            }
            while (pastMonth < 0)
            {
                pastMonth += Globals.YearLength;
                pastYear--;
            }
            return new Date(pastDay, pastWeek, pastMonth, pastYear);

        }




    }
}