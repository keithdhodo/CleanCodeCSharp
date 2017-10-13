using Chapter03.Models;

namespace Chapter03
{
    public interface IEmployeeFactory
    {
        Employee MakeEmployee(EmployeeRecord record);
    }
}
