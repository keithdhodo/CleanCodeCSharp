using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.Models
{
    public class HourlyEmployee : Employee, IEmployee
    {
        public EmployeeRecord EmployeeRecord { get; private set; }

        private HourlyEmployee()
        {

        }

        public HourlyEmployee(EmployeeRecord record) : this()
        {
            EmployeeRecord = record;
        }

        public override Money CalculatePay(Employee employee)
        {
            return new Money() { Pay = EmployeeRecord.BasePay };
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
