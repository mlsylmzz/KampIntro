using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager financeCreditManager = new FinanceCreditManager();          
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(transportCreditManager, 
                new List<ILoggerService> {new DataBaseLoggerService(), new SmsLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager>() {financeCreditManager, transportCreditManager };
            //applyManager.CreditPreInfo(credits);


        }
    }
}
