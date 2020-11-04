using Domain.Entities;
using Infrastructure.Persistense;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Employees.Commands.Create
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, bool>
    {
        private readonly EmployeeDbContext _dbContext;
        public CreateEmployeeCommandHandler(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        public async Task<bool> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emp = new Employee
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            };
            await _dbContext.Employees.AddAsync(emp);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
