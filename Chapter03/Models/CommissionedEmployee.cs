using System;

namespace Chapter03.Models
{
    public class CommissionedEmployee : Employee, IEmployee
    {
        public EmployeeRecord EmployeeRecord { get; private set; }

        private CommissionedEmployee()
        {

        }

        public CommissionedEmployee(EmployeeRecord record) : this()
        {
            EmployeeRecord = record;
        }

        public override Money CalculatePay(Employee employee)
        {
            return new Money() { Pay = EmployeeRecord.BasePay * 40 * 56 * (decimal)1.5 };
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
