using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public interface IAccount
    {
        string AccountName { get; }
        int ID { get; }
        Branch AccountBranch { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        string GenerateStatement();
    }
}