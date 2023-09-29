using NUnitFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFramework.Core.Consts
{
    public static class TestData
    {
        public static UserModel VaildUser = new UserModel
        {
            Username = "Admin",
            Password = "admin123",
        };
    }
}


