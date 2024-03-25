using SOLID.AdditionalRequiredClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.UpgradedVersion
{
    public abstract class BaseSalaryCalculator
    {
        protected Employee DeveloperReport { get; set; }
        public BaseSalaryCalculator(Employee developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double Calculate();
    }
}
