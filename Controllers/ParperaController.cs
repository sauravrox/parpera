using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parpera.DbContext;
using Parpera.Entities;
using Parpera.HelperClass;
using Parpera.Interface;
using System.Transactions;
using Transaction = Parpera.HelperClass.Transaction;

namespace Parpera.Controllers;

[ApiController]
[Route("[controller]")]
public class ParperaController : ControllerBase
{
    private readonly ILogger<ParperaController> _logger;
    private readonly ITransactionService service;
    private readonly ParperaDbContext _dbContext;

    public ParperaController(ILogger<ParperaController> logger, ITransactionService transactionService, ParperaDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
        service = transactionService;
    }

    [HttpGet]
    public async Task<ActionResult<Response>> GetTransactions()
    {
        try
        {
            var rv = await service.GetTransactions();
            return Ok(new Response
            {
                success = true,
                data = rv.transactions,
                message = "Transaction list fetch successfully"
            });
        }
        catch (Exception ex)
        {
            return Ok(new Response
            {
                success = false,
                message = ex.Message
            });
        }
    }


    [HttpPost]
    public IActionResult CreateTransaction([FromBody] TransactionEntity transaction)
    {
        _dbContext.Transaction.Add(transaction);
        _dbContext.SaveChanges();
        return Ok("Transaction created successfully");
    }


    [HttpPut("{id}/updateStatus")]
    //[Authorize(Policy = "RequireAuthenticatedUser")]
    public async Task<ActionResult<Response>> UpdateTransactionStatus(int id, [FromBody] UpdateStatusInput input)
    {
        try
        {
            var updated = await service.UpdateTransactionStatus(id, input);

            return Ok(new Response
            {
                success = true,
                data = updated,
                message = "Transaction updated successfully"
            });
        }
        catch (Exception ex)
        {
            return Ok(new Response
            {
                success = false,
                message = ex.Message
            });
        }

    }
}
