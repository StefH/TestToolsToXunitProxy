#if NETSTANDARD || NETCOREAPP
using System.Collections;

namespace TestToolsToXunitProxy
{
    public static class CollectionAssert
    {
        public static void AreEqual(ICollection expected, ICollection actual)
        {
            Xunit.Assert.Equal(expected, actual);
        }
    }
}
#endif