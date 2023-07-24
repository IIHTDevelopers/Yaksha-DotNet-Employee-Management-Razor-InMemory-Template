using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EmployeeManagement.Models;
using System.Linq;
using System.Threading.Tasks;
using System;
using EmployeeManagement.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Dataflow;

namespace EmployeeManagement.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeDbContext _dbContext;

        public IndexModel(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        public int EmployeeID { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }
       
        public decimal Salary { get; set; }

        public List<Employee> Employees { get; set; }

        public void OnGet()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public IActionResult OnPost()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        private List<Employee> EmployeeList()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public void AddEmployee()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

    }
}