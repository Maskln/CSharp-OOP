namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private double weekSalary;
        private uint dailyWorkingHours;

        public Worker(string firsName, string lastName, double weekSalary, uint dailyWorkingHours)
            : base(firsName, lastName)
            {
                this.weekSalary = weekSalary;
                this.dailyWorkingHours = dailyWorkingHours;
            }
        
        
        public double WeekSalary
        {
            get { return this.weekSalary;}
            private set { weekSalary = value;}
        }

        public uint DaylyWorkingHours
        {
            get { return this.dailyWorkingHours;}
            private set { dailyWorkingHours = value;}
        }

        public double MoneyPerHour()
        {
            double result;
            int workingWeek = 5;    // 5 days

            result = this.weekSalary / (this.dailyWorkingHours * workingWeek);              
            
            return result;
        }


         public override string ToString()
         {
             return string.Format("{0} Week salary: {1} Daily working hours: {2}, Meney/hour: {3:0.00}", base.ToString(), this.WeekSalary, this.DaylyWorkingHours, this.MoneyPerHour());
         }
    }
}
