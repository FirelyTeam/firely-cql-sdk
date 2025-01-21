namespace CoreTests;

internal static class AssertExtensions
{
    public static void DoesNotThrow(
        this Assert assert,
        Action action)
    {
        try
        {
            action();
        }
        catch (Exception e)
        {
            throw new AssertFailedException("Assertion failed, an exception was not supposed to be thrown. See InnerException for details. ", e);
        }
    }

}