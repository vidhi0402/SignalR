using DataRead.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace DataRead.Controllers
{
    public class EmployeeController : Controller
    {
       // GET: Employee
        public ActionResult Index()
        {
                return View(new List<Employees>());
        }
          
        [HttpPost]
        public ActionResult Index(Employees model)
        {
            List<Employees> employees = new List<Employees>();
            string[] path = { "Employee_Vidhi_1.csv", "Employee_Vidhi_2.csv", "Employee_Vidhi_3.csv" };

            foreach (string i in path)
            {
                string filepath = (@"C:\Users\vidhi\Desktop\ReadData\" + i);
                string csvData =  System.IO.File.ReadAllText(filepath);
                

                foreach (string row in csvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        employees.Add(new Employees
                        {
                            FileName = row.Split(',')[0],
                            EmployeeName = row.Split(',')[1],
                            Salary = row.Split(',')[2],
                            Email = row.Split(',')[3],
                            Mobile = row.Split(',')[4],
                            Qualification = row.Split(',')[5],
                            FirstName = row.Split(',')[6],
                            MiddleName = row.Split(',')[7],
                            LastName = row.Split(',')[8],
                            Address1 = row.Split(',')[9],
                            Address2 = row.Split(',')[10],
                            Address3 = row.Split(',')[11],
                            City = row.Split(',')[12],
                            State = row.Split(',')[13]

                        });

                    }
                }
            }

            return View(employees);
        }
    }
}