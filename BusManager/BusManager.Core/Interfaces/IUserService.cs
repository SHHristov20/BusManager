﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Core.Interfaces
{
    internal interface IUserService
    {
        bool Login(string email, string password);
        bool Register(string fName, string lName, string email, string password, string repeatPassword);
        bool IsEmailAvailable(string email);
        bool PasswordValid(string password);
    }
}
