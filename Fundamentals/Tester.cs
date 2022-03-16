using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.Fundamentals
{
    internal class Tester: Person
    {
        private int FoundBugs;

        public Tester(string name, int ci, int foundBugs) : base(name, ci)
        {
            this.FoundBugs = foundBugs;
        }

        public override string ShowYourWork()
        {
            return $"I found this quantity of bugs: {FoundBugs}";
        }
    }
}
