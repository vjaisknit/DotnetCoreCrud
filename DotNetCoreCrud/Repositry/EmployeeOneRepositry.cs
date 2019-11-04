using DotNetCoreCrud.Data;
using DotNetCoreCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCrud.Repositry
{
    public class EmployeeOneRepositry : IEmployeeOneRepositry
    {
        private readonly ApplicationDbContext _db;

        public EmployeeOneRepositry(ApplicationDbContext db)
        {
            _db = db;
        }
       public void Create(EmployeeOne emp)
        {
            _db.EmployeeOne.Add(emp);
            _db.SaveChanges();
        }

        void IEmployeeOneRepositry.Delete(EmployeeOne emp)
        {
            throw new NotImplementedException();
        }

      public IEnumerable<EmployeeOne> GetAllEmployees()
        {
            return _db.EmployeeOne.ToList();
        }

        EmployeeOne IEmployeeOneRepositry.GetEmplyeeById(int EmpId)
        {
            throw new NotImplementedException();
        }

        void IEmployeeOneRepositry.Update(EmployeeOne emp)
        {
            throw new NotImplementedException();
        }
    }
}
