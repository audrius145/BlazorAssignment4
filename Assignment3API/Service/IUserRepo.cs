﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment3API.Model;

namespace Assignment3API.Data
{
    public interface IUserRepo
    {
        Task<User> ValidateUser(string userName, string passWord);
    }
}