using SOLID.AdditionalRequiredClasses;
using SOLID.UpgradedVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.MainImplementation
{
    public class OpenClose
    {
        public OpenClose(Violation violation)
        {
            violation.Calculate();
            List<BaseSalaryCalculator> _employees = new List<BaseSalaryCalculator>
            {
                new JuniorDeveloperCalculator(new Employee { Id = 1, HourRate = 50, WorkingHours = 50, Level = 1 }),
                new SeniorDeveloperCalculator(new Employee { Id = 2, HourRate = 100, WorkingHours = 50, Level = 2 })
            };

            UpgradedVersion upgradedVersion = new UpgradedVersion(_employees);
            upgradedVersion.CalculateTotalSalaries(); 
        }
    }

    public class Violation
    {
        public List<Employee> _employees;
        public Violation()
        {
            _employees = new List<Employee>
            {
                new Employee { Id = 1, HourRate = 50, WorkingHours = 50, Level = 1 },
                new Employee { Id = 2, HourRate = 100, WorkingHours = 50, Level = 2}
            };//We get data from DB 
        }
        public void Calculate()
        {
            double total = 0;
            foreach (Employee emp in _employees)
            {
                if (emp.Level == 1)
                {
                    total += emp.HourRate * emp.WorkingHours;
                }
                if (emp.Level == 2)
                {
                    total += emp.HourRate * emp.WorkingHours * 1.2;
                }
            }
        }
    }

    public class UpgradedVersion
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculator;

        public UpgradedVersion(IEnumerable<BaseSalaryCalculator> developerCalculator)
        {
            _developerCalculator = developerCalculator;
        }
        
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D; 
            foreach (var calc in _developerCalculator)
            {
                totalSalaries += calc.Calculate(); 
            }
            return totalSalaries;
        }
    }
}
