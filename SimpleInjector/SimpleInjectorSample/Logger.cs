using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleInjectorSample
{
  
    public class Logger: ILogger
    {
        private TextWriter writer;
        public Logger()
        {
            writer = Console.Out;
        }
        public void Log(IEmployee employee)
        {
            writer.WriteLine($"Id={employee.Id}, Name={employee.Name}"); 
        }
       
    }
}
