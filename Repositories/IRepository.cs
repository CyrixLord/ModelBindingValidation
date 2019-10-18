using ModelBindingValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingValidation.Repositories
{
    public interface IRepository
    {
        IEnumerable<Employee> Employee { get; }  // assume get list of employees
        Employee this[int id] { get; set; }  // modify an individual employee
    }
}
