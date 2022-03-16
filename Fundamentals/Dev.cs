using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.Fundamentals
{
    internal class Dev : Person
    {
        private int BugsToFix;

        public Dev(string name, int ci, int bugsToFix): base(name, ci)
        {
            this.BugsToFix = bugsToFix;
        }

        public override string ShowYourWork()
        {
            return $"I have to fix this quantity of bugs: {BugsToFix}";
        }
    }
}
