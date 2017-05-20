using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corefundamentals
{
    public interface IGreeter
    {
        string SayGreeting();

    }

    public class Greeter : IGreeter
    {
        public Greeter(IConfiguration configuration)
        {
            _greeting = configuration["Greeting"];
        }
        private string  _greeting{ get; set; }
        public string SayGreeting()
        {
            return _greeting;
        }
    }
}
