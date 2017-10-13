namespace Chapter03.Models
{
    public class Employee : IEmployee
    {
        public virtual Money CalculatePay(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public virtual void DeliverPay(Money pay)
        {
            throw new System.NotImplementedException();
        }

        public virtual bool IsPayday()
        {
            throw new System.NotImplementedException();
        }
    }
}