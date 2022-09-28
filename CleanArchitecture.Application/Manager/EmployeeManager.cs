using AutoMapper;
using CleanArchitecture.Application.DTO;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Manager
{
    public class EmployeeManager : BaseManager<EmployeeDto, Employee>
    {
        public EmployeeManager(IRepository<Employee> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
