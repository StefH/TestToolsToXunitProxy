#if DNXCORE50 || DNX451 || DNX452
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