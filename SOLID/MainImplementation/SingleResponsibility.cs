using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.MainImplementation
{
    public class SingleResponsibility
    {
        private readonly ToRuleThemAll _ruleThemAll;
        public SingleResponsibility(ToRuleThemAll ruleThemAll)
        {

            _ruleThemAll = ruleThemAll;
            _ruleThemAll.RunMaggots();
        }
    }

    public class ToRuleThemAll
    {
        private readonly HowToRuleThemForDummies _manual;
        public ToRuleThemAll(HowToRuleThemForDummies manual)
        {
            _manual = manual;
        }
        public void RunMaggots()
        {
            _manual.ShoutOnEveryoneManyTimes();
            _manual.KillCoupleOfPeasants(5);
            _manual.GetPeasantsToBowBeforeMe();
        }
    }

    public class HowToRuleThemForDummies
    {
        public void ShoutOnEveryoneManyTimes()
        {
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine("I am shouting!!");
            }
        }

        public void KillCoupleOfPeasants(int numberOfPeasantsToKill)
        {
            for (var i = 0; i < numberOfPeasantsToKill; i++)
            {
                Console.WriteLine("I am killing the peasant!!!");
            }
        }

        public void GetPeasantsToBowBeforeMe()
        {
            Console.WriteLine("Now peasants! Bow!");
        }
    }
}
