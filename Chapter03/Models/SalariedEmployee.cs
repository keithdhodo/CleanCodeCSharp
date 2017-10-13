using System;

namespace Chapter03.Models
{
    public class SalariedEmployee : Employee, IEmployee
    {
        public EmployeeRecord EmployeeRecord { get; private set; }

        private SalariedEmployee()
        {

        }

        public SalariedEmployee(EmployeeRecord record) : this()
        {
            EmployeeRecord = record;
        }

        public override Money CalculatePay(Employee employee)
        {
            return new Money() { Pay = EmployeeRecord.BasePay * 40 * 56 };
        }

        public override void DeliverPay(Money pay)
        {
            throw new NotImplementedException();
        }

        public override bool IsPayday()
        {
            throw new NotImplementedException();
        }
    }
}
