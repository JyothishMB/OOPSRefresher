using MediatorDemo.Infrastructure.Domain.Interfaces;
using MediatorDemo.Infrastructure.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Application.Employees.Query
{
    public class GetEmployeeQuery : IRequest<Employee>
    {
        public int Id { get; set; }
        public class Handler : IRequestHandler<GetEmployeeQuery, Employee>
        {
            private readonly IRepository<Employee> _repository;
            public Handler(IRepository<Employee> repository)
            {
                _repository = repository;   
            }
            public async Task<Employee> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
            {
                var result = await _repository.GetAsync(request.Id);
                return result;
            }
        }
    }
}
