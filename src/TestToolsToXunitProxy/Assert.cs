#if DNXCORE50 || DNX451 || DNX452
namespace TestToolsToXunitProxy
{
    public static class Assert
    {
        public static void Fail(string message)
        {
            Xunit.Assert.True(false, message);
        }

        public static void IsTrue(bool condition)
        {
            Xunit.Assert.True(condition);
        }

        public static void IsFalse(bool condition)
        {
            Xunit.Assert.False(condition);
        }

        public static void IsNull(object value)
        {
            Xunit.Assert.Null(value);
        }

        public static void IsNotNull(object value)
        {
            Xunit.Assert.NotNull(value);
        }

        public static void AreEqual<T>(T expected, T actual)
        {
            Xunit.Assert.Equal(expected, actual);
        }
    }
}
#endif