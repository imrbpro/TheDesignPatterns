using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Factory.Implementation
{
    public class GoldCard : IPaymentCard
    {
        public int AnnualCharges()
        {
            return 2000;
        }

        public int CardLimit()
        {
            return 500000;
        }

        public string GetCardType()
        {
            return "Credit Card Gold";
        }

        public int Validity()
        {
            return 2025;
        }
    }
}
