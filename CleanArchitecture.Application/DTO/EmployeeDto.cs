﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTO
{
    public class EmployeeDto
    {
        public Int64 Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public DateTime DateOfBirth
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Email2
        {
            get;
            set;
        }
    }
}
