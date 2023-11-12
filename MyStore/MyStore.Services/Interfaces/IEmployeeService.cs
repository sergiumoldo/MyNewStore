using MyStore.NewFolder;

namespace MyStore.MyStore.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees(int page);
        IEnumerable<Employee> GetEmployees(int page, string? text);
        Employee? GetEmployee(int id);
        Employee InsertNew(Employee category);
        bool IsDuplicate(string Categoryname);
        int Remove(Employee category);
        Employee Update(Employee category);
    }
}
