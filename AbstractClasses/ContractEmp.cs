namespace AbstractClasses
{
    class ContractEmp : BaseEmp
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return HourlyPay * TotalHours;
        }
    }
}
