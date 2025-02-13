using LoanManagement.Domain.Entities;
using LoanManagement.Domain.Repositories;
using System;
using System.Data.Entity;

namespace LoanManagement.Infrastructure.Persistence
{
    // Implementação com Entity Framework Core
    public class LoanRepository : ILoanRepository
    {
        private readonly AppDbContext _context;
        public LoanRepository(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<Loan?> GetByIdAsync(Guid id)
        {
            return await _context.Loans.FindAsync(id);
        }

        public Task AddAsync(Loan loan)
        {
            throw new NotImplementedException();
        }
    }
}
