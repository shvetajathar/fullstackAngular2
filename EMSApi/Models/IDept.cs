using System.Collections.Generic;
namespace EMSApi.Models;

public interface IDept
{
    List<Department> GetDepartments();
    Department FindDept(int id);
    void AddDept(Department dept);
    void EditDept(Department dept);
    void DeleteDept(int id);
    // public void GetAll();
    // public void GetById();
    // public void Insert();
    // public void Update();
    // public void Delete();

}