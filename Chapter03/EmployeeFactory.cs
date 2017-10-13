using Chapter03.Enums;
using Chapter03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee MakeEmployee(EmployeeRecord record)
        {
            switch(record.Type)
            {
                case EmployeeType.COMMISSIONED:
                    return new CommissionedEmployee(record);
                case EmployeeType.HOURLY:
                    return new HourlyEmployee(record);
                case EmployeeType.SALARIED:
                    return new SalariedEmployee(record);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
