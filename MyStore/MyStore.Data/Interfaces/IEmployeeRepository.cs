using MyStore.NewFolder;

namespace MyStore.MyStore.Data.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee Add(Employee category);
        int Delete(Employee category);
        IEnumerable<Employee> GetAll(int page);
        IQueryable<Employee> GetAll();
        IQueryable<Employee> GetAll(int page, string? text);
        Employee? GetEmployeeById(int id);
        Employee Update(Employee category);
    }
}