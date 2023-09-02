namespace SourceCode
{
    internal sealed class Testee
    {
        private readonly TesteeDependency _testeeDependency;

        public Testee(TesteeDependency testeeDependency)
        {
            _testeeDependency = testeeDependency;
        }

        public void Execute()
        {
            _testeeDependency.ExecuteVoidMethodWithoutArguments();
            _testeeDependency.ExecuteVoidMethodWithArguments("myString", 42);
            _ = _testeeDependency.ExecuteMethodWithReturnValue();
        }
    }
}
