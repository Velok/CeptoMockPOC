using Microsoft.CodeAnalysis;

namespace CeptoMock;

[Generator]
public class InterceptorSourceGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        
    }

    public void Execute(GeneratorExecutionContext context)
    {
        Console.WriteLine("Reaching Code Generation");
    }
}
