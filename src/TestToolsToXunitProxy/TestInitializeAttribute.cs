#if NETSTANDARD || NETCOREAPP
using System;

namespace TestToolsToXunitProxy
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestInitialize : Attribute
    {
        public TestInitialize()
        {
        }
    }
}
#endif