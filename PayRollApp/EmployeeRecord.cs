using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollApp
{
    public abstract class EmployeeRecord
    {
        string Name {  get; set; }
        double[] WeeklyHours { get; set; }

        public EmployeeRecord(string name, double[] weeklyHours) {
            this.Name = name;
            this.WeeklyHours = weeklyHours;
        }

        public abstract double GetMonthlyPay(double[] weeklyHours, double HourlyRate, double MonthlyBonus);
    }

    public class FullTimeEmployee : EmployeeRecord
    {
        double HourlyRate { get; set; }
        double MonthlyBonus { get; set; }

        double totalHours = 0;
        public override double GetMonthlyPay(double[] weeklyHours, double HourlyRate, double MonthlyBonus)
        {
            this.HourlyRate = HourlyRate;
            this.MonthlyBonus = MonthlyBonus;
            for (int i = 0; i < weeklyHours.Length; i++)
            {
                totalHours += weeklyHours[i];
            }
            
            return totalHours;
        }
        //public override double GetMonthlyPay(double[] weeklyHours)
        //{

        //    for (int i = 0; i < weeklyHours.Length; i++)
        //    {
        //        totalHours += weeklyHours[i];
        //    }

        //    return totalHours;
        //}
    }
}
