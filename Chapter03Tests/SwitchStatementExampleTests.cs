using Chapter03;
using Chapter03.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter03Tests
{
    [TestClass]
    public class SwitchStatementExampleTests
    {
        [TestMethod]
        public void SwitchStatementExample_Employee_HourlyRate()
        {
            var employee = new Employee() { Type = EmployeeType.HOURLY, HourlyRate = 40.00M };
            var hourlyRate = new SwitchStatementExample().CalculatePay(employee);

            Assert.AreEqual(40.00M, hourlyRate.Pay);
        }

        [TestMethod]
        public void SwitchStatementExample_Employee_Salaried()
        {
            var employee = new Employee() { Type = EmployeeType.SALARIED, HourlyRate = 40.00M };
            var hourlyRate = new SwitchStatementExample().CalculatePay(employee);

            Assert.AreEqual(89600.00M, hourlyRate.Pay);
        }

        [TestMethod]
        public void SwitchStatementExample_Employee_Commissioned()
        {
            var employee = new Employee() { Type = EmployeeType.COMMISSIONED, HourlyRate = 40.00M };
            var hourlyRate = new SwitchStatementExample().CalculatePay(employee);

            Assert.AreEqual(134400.00M, hourlyRate.Pay);
        }
    }
}
