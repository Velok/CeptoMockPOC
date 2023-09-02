namespace CeptoMock
{
    public static class Cepto
    {
        public static void Mock<T>(Action<T> setupDeclaration, int expectedInvocationCount) { }
    }
}
