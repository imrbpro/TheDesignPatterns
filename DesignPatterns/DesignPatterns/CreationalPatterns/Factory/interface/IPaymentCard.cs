using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Factory
{
    public interface IPaymentCard
    {
        string GetCardType();
        int CardLimit();
        int AnnualCharges();
        int Validity();
    }
}
