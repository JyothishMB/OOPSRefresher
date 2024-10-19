namespace LSP.Lib
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
            
        }
        public PermanentEmployee(int Id, string Name) : base(Id, Name)
        {
            
        }
        public override decimal CalculateBonus(decimal Salary)
        {
            return Salary*.1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
