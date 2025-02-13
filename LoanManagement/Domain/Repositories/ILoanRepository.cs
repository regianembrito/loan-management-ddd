using LoanManagement.Domain.Entities;

namespace LoanManagement.Domain.Repositories
{
    // O repositório abstrai o acesso ao banco de dados.
    public interface ILoanRepository
    {
        Task<Loan?> GetByIdAsync(Guid id);
        Task AddAsync(Loan loan);
    }
}
