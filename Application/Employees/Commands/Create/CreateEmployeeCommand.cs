using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Employees.Commands.Create
{
    public class CreateEmployeeCommand : IRequest<bool>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
