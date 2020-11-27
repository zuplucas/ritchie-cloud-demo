using System;
using formula;

namespace main
{
    static class main
    {
        static void Main(string[] args)
        {
            string paramName = Environment.GetEnvironmentVariable("RIT_NAME");
            string paramUsedRitchie = Environment.GetEnvironmentVariable("RIT_USED_RITCHIE");
            string credential = Environment.GetEnvironmentVariable("TEST_TOKEN");

            Formula f = new formula.Formula(paramName, paramUsedRitchie, credential);
            f.Run();
        }
    }
}
