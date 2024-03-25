using SOLID.AdditionalRequiredClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.UpgradedVersion
{
    public class JuniorDeveloperCalculator : BaseSalaryCalculator
    {
        public JuniorDeveloperCalculator(Employee developerReport) : base(developerReport){}

        public override double Calculate()
        {
            return DeveloperReport.HourRate * DeveloperReport.WorkingHours;
        }
    }
}
