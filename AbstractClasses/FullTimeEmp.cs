namespace AbstractClasses
{
    class FullTimeEmp : BaseEmp
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
