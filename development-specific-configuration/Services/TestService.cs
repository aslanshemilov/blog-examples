using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Services
{
    public class TestService : ITestService
    {
        public string GetImplementationName()
        {
            return "TestService";
        }
    }
}