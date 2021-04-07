using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Factory.Implementation
{
    public class PlatinumCard : IPaymentCard
    {
        public int AnnualCharges()
        {
            return 2500;
        }

        public int CardLimit()
        {
            return 1500000;
        }

        public string GetCardType()
        {
            return "Credit Card Platinum";
        }

        public int Validity()
        {
            return 2030;
        }
    }
}
