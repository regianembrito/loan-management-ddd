using LoanManagement.Application.Dtos;
using LoanManagement.Application.UseCases;
using LoanManagement.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagement.API.Controllers
{
    // Agora, expomos a funcionalidade via Web API.
    [ApiController]
    [Route("api/loans")]
    public class LoanController : ControllerBase
    {
        private readonly RequestLoan _requestLoan;

        public LoanController(RequestLoan requestLoan)
        {
            _requestLoan = requestLoan;
        }

        [HttpPost]
        public async Task<IActionResult> RequestLoan([FromBody] RequestLoanDto request)
        {
            var loanId = await _requestLoan.Execute(request.Amount, request.TermInMonths, request.InterestRate, request.CustomerId);
            return CreatedAtAction(nameof(GetLoan), new { id = loanId }, null);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLoan(Guid id, [FromServices] ILoanRepository repository)
        {
            var loan = await repository.GetByIdAsync(id);
            if (loan == null)
            {
                return NotFound();
            }
            return Ok(loan);
        }
    }
}
