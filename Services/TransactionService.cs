using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Parpera.HelperClass;
using Parpera.Interface;
using System.Net.Http.Headers;
using Parpera.HelperClass;
using Parpera.Entities;

namespace Parpera.Services
{
    public class TransactionService : ITransactionService
    {
        public async Task<(bool IsSuccess, List<Transaction> transactions, string ErrorMessage)> GetTransactions()
        {
            try
            {
                var transactionList = new TransactionList();
                // Additional logic if needed
                return (true, transactionList.Transactions, null);
            }
            catch (Exception e)
            {
                return (false, null, e.Message);
            }
        }

        public async Task<Transaction> UpdateTransactionStatus(int id, UpdateStatusInput input)
        {
            
            var transactions = TransactionList.GetTransactions();
            var transactionToUpdate = transactions.Find(t => t.ID == id);

            transactionToUpdate.Status = input.Status;

            return await Task.FromResult(transactionToUpdate);
            
        }
    }
}
