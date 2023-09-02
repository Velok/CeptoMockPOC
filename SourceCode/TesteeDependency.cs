namespace SourceCode;

internal sealed class TesteeDependency
{
    public void ExecuteVoidMethodWithoutArguments()
    {
        GenerateConsoleOutput(nameof(ExecuteVoidMethodWithoutArguments));
    }

    public void ExecuteVoidMethodWithArguments(string stringArgument, int intArgument)
    {
        GenerateConsoleOutput(nameof(ExecuteVoidMethodWithArguments));
    }

    public string ExecuteMethodWithReturnValue()
    {
        GenerateConsoleOutput(nameof(ExecuteMethodWithReturnValue));

        return "Return value of method";
    }

    private void GenerateConsoleOutput(string nameOfMethod)
    {
        Console.WriteLine($"Method '{nameOfMethod}' in SourceCode project executed");
    }
}
