using System.Collections.Generic;
using System.Linq;

namespace EMSApi.Models;
public class DepartmentsRepository:IDept{
    EmsDbContext context=new EmsDbContext();
    public  void AddDept(Department dept)
    {
        context.Departments.Add(dept);
        context.SaveChanges();
    }
    public  void EditDept(Department dept)
    {
        Department department=context.Departments.Find(dept.Id);
        department.DeptName=dept.DeptName;
        department.Location=dept.Location;
        context.SaveChanges();
        
    }
    public  Department FindDept(int id)
    {
        var data=context.Departments.Find(id);
        return data;
    }
    public  void DeleteDept(int id)
    {
        Department department=context.Departments.Find(id);
        context.Departments.Remove(department);
        context.SaveChanges();
    }
    public List<Department> GetDepartments()
    {
        return context.Departments.ToList();
    }
}