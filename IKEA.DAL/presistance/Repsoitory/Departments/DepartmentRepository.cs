using IKEA.DAL.Models.Department;
using IKEA.DAL.presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.presistance.Repsoitory.Departments
{
    internal class DepartmentRepository : IDepartmentRepsitory
    {
        private readonly ApplicationDbContext _dbContext;

        public DepartmentRepository(ApplicationDbContext dbContext)
        {
           _dbContext =dbContext;    
        
        }
        public int Add(Department entity)
        {
              _dbContext.Departments.Add(entity);
            return _dbContext.SaveChanges();    
        }
        public int Update(Department entity)
        {
           _dbContext.Departments.Update(entity);   
            return _dbContext.SaveChanges();        
        }
        public int Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetALL(bool withAsNoTracking = true)
        {
            throw new NotImplementedException();
        }

        public Department? GetById(int id)
        {
           var department = _dbContext.Departments.Find(id);
            return department;
        }

       
    }
}
