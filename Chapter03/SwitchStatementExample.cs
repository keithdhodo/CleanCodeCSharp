using Chapter03.Enums;
using System;

namespace Chapter03
{
    public class SwitchStatementExample
    {
        public Money CalculatePay(Employee employee)
        {
            switch (employee.Type)
            {
                case EmployeeType.COMMISSIONED:
                    return CalculateCommissionedPay(employee);
                case EmployeeType.HOURLY:
                    return CalculateHourlyPay(employee);
                case EmployeeType.SALARIED:
                    return CalculateSalariedPay(employee);
                default:
                    throw new NotImplementedException();
            }
        }

        private Money CalculateHourlyPay(Employee employee)
        {
            return new Money() { Pay = employee.HourlyRate };
        }

        private Money CalculateSalariedPay(Employee employee)
        {
            return new Money() { Pay = employee.HourlyRate * 40 * 56 };
        }

        private Money CalculateCommissionedPay(Employee employee)
        {
            return new Money() { Pay = employee.HourlyRate * 40 * 56 * (decimal) 1.5 };
        }
    }
}
