using Microsoft.AspNetCore.Mvc;
using Parpera.Entities;
using Parpera.HelperClass;

namespace Parpera.Interface
{
    public interface ITransactionService
    {
        Task<(bool IsSuccess, List<Transaction> transactions, string ErrorMessage)> GetTransactions();
        Task<Transaction> UpdateTransactionStatus(int id, UpdateStatusInput input);

    }
}