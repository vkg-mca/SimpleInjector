using Jil;
using System;
using System.IO;
using System.Text;

namespace SimpleInjectorSample
{

    public class ConsoleLogger : ILogger
    {
        private TextWriter writer;
        public ConsoleLogger()
        {
            writer = Console.Out;
        }
        public void Log<T>(T obj)
        {
            writer.WriteLine(JSON.Serialize(obj));
        }
    }
}
