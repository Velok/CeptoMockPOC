namespace CeptoMock;

internal class MockInformation
{
    public Type TypeToMock { get; set; }
    public string MethodToMock { get; set; }
    public int ExpectedInvocationCount { get; set; }
}
