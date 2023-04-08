using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetList();

        IDataResult<Employee>GetById(int employeeId);

        IResult Add(Employee employee);

        IResult Delete(Employee employee);

        IResult Update(Employee employee);

    }
}
