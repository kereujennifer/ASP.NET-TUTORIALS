﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeerepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeerepository()
        {
            _employeeList = new List<Employee>()
            {
             new Employee() {Id =1, Name ="Jennifer", Department="SD", Email="Jennifer@g.com"},
             new Employee() { Id = 2, Name = "Mary", Department = "HR", Email = "Mary@g.com" },
             new Employee() { Id = 3, Name = "Kereu", Department = "IT", Email = "Kereu@g.com" },

            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
           return _employeeList;
        }

        public Employee GetEmployee (int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }    
    }
}