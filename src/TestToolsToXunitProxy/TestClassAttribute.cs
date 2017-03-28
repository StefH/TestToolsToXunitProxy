#if NETSTANDARD || NETCOREAPP
using System;

namespace TestToolsToXunitProxy
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TestClassAttribute : Attribute
    {
        public TestClassAttribute()
        {
        }
    }
}
#endif