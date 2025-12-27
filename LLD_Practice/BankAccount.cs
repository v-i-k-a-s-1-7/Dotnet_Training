using System;
using System.Collections.Generic;
using System.Text;

namespace LLD_Practice
{
    //public interface IBankAccount
    //{
    //    double Deposit(double amount);
    //    double WithDraw(double amount);

    //}

    public abstract class BankAccount 
    {
        int AccountNumber;
        double amount;
        
        public virtual double Deposit(double amount)
        {
            this.amount += amount;
            return this.amount;
        }

        public virtual double  WithDraw(double amount)
        {
            if (this.amount < amount)
            {
                throw new Exception("Insufficient Balance");
            }
            this.amount -= amount;
            return this.amount;
        }

    }

    public class SavingsAccount : BankAccount
    {
        double interestRate;
       

    }

    public class CurrentAccount : BankAccount
    {
        
        double OverDraftLimit;
        public override double WithDraw(double amount)
        {
            if (amount < amount)
            {
                throw new Exception("Insufficient Balance");
            }
            amount -= amount;
            return amount;
        } 


    }
}
