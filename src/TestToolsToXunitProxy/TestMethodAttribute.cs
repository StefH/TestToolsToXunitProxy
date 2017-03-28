#if NETSTANDARD || NETCOREAPP
using System;
using Xunit;

namespace TestToolsToXunitProxy
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestMethodAttribute : FactAttribute
    {
        public TestMethodAttribute() : base()
        {
        }
    }
}
#endif