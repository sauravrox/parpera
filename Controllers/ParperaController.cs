using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parpera.HelperClass;
using Parpera.Interface;
using System.Transactions;

namespace Parpera.Controllers;

[ApiController]
[Route("[controller]")]
public class ParperaController : ControllerBase
{
    private readonly ILogger<ParperaController> _logger;
    private readonly ITransactionService service;

    public ParperaController(ILogger<ParperaController> logger, ITransactionService transactionService)
    {
        _logger = logger;
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

    [HttpPut("{id}/updateStatus")]
    //[Authorize]
    public async Task<ActionResult<Response>> UpdateTransactionStatus(int id, [FromBody] UpdateStatusInput input)
    {
        try
        {
            var updated = service.UpdateTransactionStatus(id, input);

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
