using SOLID.AdditionalRequiredClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.UpgradedVersion
{
    public class SeniorDeveloperCalculator : BaseSalaryCalculator
    {
        public SeniorDeveloperCalculator(Employee developerReport) : base(developerReport){}
        public override double Calculate()
        {
            return DeveloperReport.HourRate * DeveloperReport.WorkingHours * 1.2; 
        }
    }
}
