#if DNXCORE50 || DNX451 || DNX452 || NETSTANDARD || NETCOREAPP
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