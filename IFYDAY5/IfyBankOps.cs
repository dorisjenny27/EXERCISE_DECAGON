using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class BankOps
    {
        public static decimal SenderBalance { get; set; }
        public static decimal ReceiverBalance { get; set; }

        public List<TransactionsHistory> Transactions { get; set; } = new List<TransactionsHistory>();

        public ResponseObject<decimal> Deposit(decimal amount, string note)
        {
            if (amount < 1)
            {
                return new ResponseObject<decimal>
                {
                    Success = false,
                    Message = "Failed to deposit",
                    Errors = new List<string> { "Amount should be more than 0!" }
                };
            }
            SenderBalance += amount;
           
            return new ResponseObject<decimal>
            {
                Success = true,
                Message = "Deposited successfully!",
                Data = SenderBalance
            };
        }

        public ResponseObject<decimal> Withdrawal(decimal amount, string note)
        {
            if (amount < 1)
            {
                return new ResponseObject<decimal>
                {
                    Success = false,
                    Message = "Failed to deposit",
                    Errors = new List<string> { "Amount should be more than 0!" }
                };
            }
            if (amount > SenderBalance)
            {
                return new ResponseObject<decimal>
                {
                    Success = false,
                    Message = "Failed to withdraw",
                    Errors = new List<string> { "Insufficient fund!" }
                };
            }
            SenderBalance -= amount;
            
            return new ResponseObject<decimal>
            {
                Success = true,
                Message = "Withdrawal is successful",
                Data = SenderBalance
            };
        }

        public ResponseObject<decimal> Transfer(decimal amount, string note)
        {
            this.Withdrawal(amount, note);
            this.Deposit(amount, note);
            return new ResponseObject<decimal>
            {
                Success = true,
                Message = "Transfer is successful",
                Data = SenderBalance
            };
        }
    }

    class ResponseObject<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public T Data { get; set; }
    }

    class TransactionsHistory
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime UpdateOn { get; set; }
        public string TransactionType { get; set; }
        public string Note { get; set; }
    }
}
/*
 
 
  Transactions.Add();
 */