using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInjectorSample
{
    public interface ILogger
    {
        void Log<T>(T obj);
    }
}
