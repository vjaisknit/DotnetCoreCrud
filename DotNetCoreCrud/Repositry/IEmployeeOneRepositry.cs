using DotNetCoreCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCrud.Repositry
{
  public  interface IEmployeeOneRepositry
    {
        void Create(EmployeeOne emp);
        void Update(EmployeeOne emp);
        void Delete(EmployeeOne emp);
        EmployeeOne GetEmplyeeById(int EmpId);
        IEnumerable<EmployeeOne> GetAllEmployees();
    }
}
