using System;
namespace Introduction2Classes
{
    public class BankAccount
    {
        public string Number { get;  }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            
        }

        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {
            
        }
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        private static int accountNumberSeed = 1234567890;
    }
}
