using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Factory.Implementation
{
    public class DebitCard : IPaymentCard
    {
        public int AnnualCharges()
        {
            return 1500;
        }

        public int CardLimit()
        {
            return 50000;
        }

        public string GetCardType()
        {
            return "Debit Card Silver";
        }

        public int Validity()
        {
            return 2021;
        }
    }
}
