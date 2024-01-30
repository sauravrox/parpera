using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Parpera.DbContext;
using Parpera.Entities;
using Parpera.HelperClass;
using Parpera.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
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
    private readonly IConfiguration _configuration;

    public ParperaController(ILogger<ParperaController> logger, ITransactionService transactionService, ParperaDbContext dbContext, IConfiguration configuration)
    {
        _logger = logger;
        _dbContext = dbContext;
        service = transactionService;
        _configuration = configuration;
    }

    [HttpGet("AccessToken")]
    public IActionResult GetToken()
    {
        var claims = new[]
        {
        new Claim(ClaimTypes.Name, "Admin"),
        // Add other claims as needed (e.g., roles)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: "https://localhost:7124",
            audience: "https://localhost:7124",
            claims: claims,
            expires: DateTime.UtcNow.AddDays(7),
            signingCredentials: creds
        );

        var generatedToken = new JwtSecurityTokenHandler().WriteToken(token);

        return Ok(new { token = generatedToken });
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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
