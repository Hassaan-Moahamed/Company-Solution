using IKEA.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.presistance.Repsoitory.Departments
{
    public interface IDepartmentRepsitory
    {
        IEnumerable<Department> GetALL(bool withAsNoTracking =true );
       Department? GetById( int id );
        int Add(Department entity);
        int Update(Department entity);
        int Delete(Department entity);

    }
}
