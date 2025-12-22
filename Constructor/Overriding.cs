namespace OopsSession.Constructor
{
    public class Father
    {
        public virtual string InterestOn()
        {
            return "I Like Cricket";
        }
    }

    public class Son : Father
    {
        public override string InterestOn()
        {
            return "I like Football";
        }
    }

    public class Employee
    {
        public virtual string ListOfHolidays()
        {
            return "Christmas " +
                   "Black Friday " +
                   "Holi " +
                   "Diwali " +
                   "Independence Day " +
                   "New Year";
        }
    }

    public class Indian : Employee
    {
        public override string ListOfHolidays()
        {
            return "Diwali " +
                   "Holi " +
                   "Christmas";
        }
    }

    public class USA : Employee
    {
        public override string ListOfHolidays()
        {
            return base.ListOfHolidays();
        }
    }
}
