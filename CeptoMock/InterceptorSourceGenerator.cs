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
        // Collect all Cepto.Mock statements via reflection
        var ceptoMockStatements = CollectCeptoMockStatements();
        // Iterate through the statements and analyze the important information:
        //   Type to Mock
        //   Method to Mock
        //   ExpectedInvocationsCount for method of type
        // These information should be stored in a DTO

        // Iterate through the DTOs to gather location information of the methods to mock:
        //   Get class and exact line of code in the source code via reflection
        //   Also add these information to the DTOs

        // Iterate again through the DTOs in order to generate the Interceptor classes
        //   TODO: More details
    }

    private IEnumerable<string> CollectCeptoMockStatements()
    {
        var ceptoMockStatements = new List<string>();

        return ceptoMockStatements;
    }
}
