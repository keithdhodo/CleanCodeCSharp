using Chapter03;
using Chapter03.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter03Tests
{
    [TestClass]
    public class SwitchStatementExampleTests
    {
        public EmployeeFactory EmployeeFactory { get; set; }
        public EmployeeRecord EmployeeRecord { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            EmployeeFactory = new EmployeeFactory();
            EmployeeRecord = new EmployeeRecord();
        }

        [TestMethod]
        public void SwitchStatementExample_Employee_HourlyRate()
        {
            EmployeeRecord.Type = EmployeeType.HOURLY;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord); 
            var hourlyRate = employee.CalculatePay(employee);

            Assert.AreEqual(40.00M, hourlyRate.Pay);
        }

        [TestMethod]
        public void SwitchStatementExample_Employee_Salaried()
        {
            EmployeeRecord.Type = EmployeeType.SALARIED;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            var hourlyRate = employee.CalculatePay(employee);

            Assert.AreEqual(89600.00M, hourlyRate.Pay);
        }

        [TestMethod]
        public void SwitchStatementExample_Employee_Commissioned()
        {
            EmployeeRecord.Type = EmployeeType.COMMISSIONED;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            var hourlyRate = employee.CalculatePay(employee);

            Assert.AreEqual(134400.00M, hourlyRate.Pay);
        }
    }
}
