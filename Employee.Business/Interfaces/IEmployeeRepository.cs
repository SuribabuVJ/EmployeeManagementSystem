using Employee.Business.EntityModels;

namespace Employee.Business.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee.Business.EntityModels.Employee> GetAll();

        Employee.Business.EntityModels.Employee? GetById(int id);

        void Add(Employee.Business.EntityModels.Employee employee);

        void Update(Employee.Business.EntityModels.Employee employee);

        void Delete(int id);
    }
}