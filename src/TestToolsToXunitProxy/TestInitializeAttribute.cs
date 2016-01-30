#if DNXCORE50 || DNX451 || DNX452
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