﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelBindingValidation.Models;

namespace ModelBindingValidation.Repositories
{
    public class EmployeeRepository : IRepository
    {
        private readonly Dictionary<int, Employee> employee = new Dictionary<int, Employee> // create a list of employees
        {
            [1] = new Employee
            {
                Id = 1,
                Name = "John",
                DOB = new DateTime(1980, 12, 25),
                Role = Role.Admin
            },
            [2] = new Employee
            {
                Id = 2,
                Name = "Michael",
                DOB = new DateTime(1981, 5, 13),
                Role = Role.Designer
            },
            [3] = new Employee
            {
                Id = 3,
                Name = "Rachael",
                DOB = new DateTime(1982, 11, 25),
                Role = Role.Designer
            },
            [4] = new Employee
            {
                Id = 4,
                Name = "Anna",
                DOB = new DateTime(1983, 1, 20),
                Role = Role.Manager
            }
        };
        public IEnumerable<Employee> Employee => employee.Values; // populate the Employee with the values
        public Employee this[int id]
        {
            get
            {
                return employee.ContainsKey(id) ? employee[id] : null;
            }
            set
            {
                employee[id] = value;
            }
        }
    }
}