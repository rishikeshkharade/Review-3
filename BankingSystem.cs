using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3
{
    internal class BankingSystem
    {
        public static void BankingSystemMain()
        {
            BankAccount account = new BankAccount(1000);

            Console.WriteLine($"Your current balance is: {account.Balance}Rs");
            Console.WriteLine("Enter the amount you want to withdraw:");
            string input = Console.ReadLine();

            try
            {
                decimal amountToWithdraw = decimal.Parse(input);
                account.Withdraw(amountToWithdraw);
                Console.WriteLine($"Your Balance is: {account.Balance}Rs");
            }
            catch (InsufficientFundsException ie)
            {
                Console.WriteLine(ie.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientFundsException("Insufficent funds in bank account.");

            Balance -= amount;
        }
    }

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}