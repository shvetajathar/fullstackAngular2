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
        
    }
    public  void DeleteDept(int id)
    {
        var data=context.Departments.Find(id);
        context.Departments.Remove(data);
    }
}