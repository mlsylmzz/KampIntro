using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Method injection
    class ApplyManager
    {
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
           
        }

        public void CreditPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();

            }

        }
    }
}
