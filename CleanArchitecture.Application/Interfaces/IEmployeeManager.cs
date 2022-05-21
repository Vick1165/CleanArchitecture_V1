using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Application.Interfaces;

public interface IEmployeeManager
{
    Task<IReadOnlyList<Employee>> GetEmployee();
}
