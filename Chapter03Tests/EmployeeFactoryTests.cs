using Chapter03;
using Chapter03.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Chapter03Tests
{
    [TestClass]
    public class EmployeeFactoryTests
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

        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void SwitchStatementExample_Employee_Commissioned_DeliverPayNotImplemented()
        {
            EmployeeRecord.Type = EmployeeType.COMMISSIONED;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            employee.DeliverPay(new Money());
        }

        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void SwitchStatementExample_Employee_Hourly_DeliverPayNotImplemented()
        {
            EmployeeRecord.Type = EmployeeType.HOURLY;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            employee.DeliverPay(new Money());
        }

        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void SwitchStatementExample_Employee_Salaried_DeliverPayNotImplemented()
        {
            EmployeeRecord.Type = EmployeeType.SALARIED;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            employee.DeliverPay(new Money());
        }

        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void SwitchStatementExample_Employee_Commissioned_IsPayday_NotImplemented()
        {
            EmployeeRecord.Type = EmployeeType.COMMISSIONED;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            employee.IsPayday();
        }

        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void SwitchStatementExample_Employee_Hourly_IsPayday_NotImplemented()
        {
            EmployeeRecord.Type = EmployeeType.HOURLY;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            employee.IsPayday();
        }

        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod]
        public void SwitchStatementExample_Employee_Salaried_IsPaydayNotImplemented()
        {
            EmployeeRecord.Type = EmployeeType.SALARIED;
            EmployeeRecord.BasePay = 40.00M;

            var employee = EmployeeFactory.MakeEmployee(EmployeeRecord);
            employee.IsPayday();
        }
    }
}
