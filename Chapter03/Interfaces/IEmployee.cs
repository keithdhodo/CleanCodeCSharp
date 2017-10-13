using Chapter03.Models;

namespace Chapter03
{
    public interface IEmployee
    {
        Money CalculatePay(Employee employee);
        void DeliverPay(Money pay);
        bool IsPayday();
    }
}